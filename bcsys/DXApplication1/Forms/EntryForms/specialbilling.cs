using bcsys.modules;
using DevExpress.CodeParser;
using DevExpress.Data.Mask.Internal;
using DevExpress.Web;
using DevExpress.Web.Internal.XmlProcessor;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcsys.Forms.EntryForms
{
	public partial class specialbilling : Form
	{
		Int32 retries, r, nclcode, nmsize;
		string ssql, smascode, smeterno;
		DataTable dtbrates;


		public specialbilling()
		{
			InitializeComponent();
		}

		private void btnConSearch_Click(object sender, EventArgs e)
		{
			Form consearch = new consearch();
			consearch.ShowDialog();
			tbmascode.Text = Program.smascode;
			tbAcctno.Text = Program.zna;
			tbAcctno.Focus();
			tbAcctno_KeyDown(1, new KeyEventArgs(Keys.Enter));
		}

		private void tbAcctno_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (tbAcctno.Text != "")
				{
					sdisplayname();
					//sdisplaydetails();
					//tsGL.Enabled = true;
				}
			}
			else if (e.KeyCode == Keys.F2)
			{
				Form consearch = new consearch();
				consearch.ShowDialog();
				tbmascode.Text = Program.smascode;
				tbAcctno.Text = Program.zna;
				sdisplayname();
				//sdisplaydetails();
			}
		}
		private void sdisplayname()
		{
			ssql = "select * from bcdb.master where left(znacc12,6)=@zn";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@zn", tbAcctno.Text.Substring(0, 6));
				using (rs = new DataTable())
				{
					rs = dbcon.get_records(ssql, cmd);
					if (rs.Rows.Count > 0)
					{
						cbRType.SelectedIndex = 0;
						foreach (DataRow dr in rs.Rows)
						{
							tbmascode.Text = dr["mascode"].ToString();
							tbAcctno.Text = dr["znacc12"].ToString();
							tbName.Text = dr["Name"].ToString();
							tbAddress.Text = dr["address"].ToString();
							nclcode = Convert.ToInt32(dr["classcode"]);
							nmsize = Convert.ToInt32(dr["msize"]);
							tbwmf.Text = nwmf.ToString("##,##0.00");
							Program.zone = dr["zn"].ToString();
							Program.book = dr["bk"].ToString();
							smeterno = dr["m_no"].ToString();
							cbRType.SelectedIndex = Convert.ToInt16(dr["ratetype"].ToString());
							sgetrates();
							//get previous reading from reading_bc of the previous reading period
							sgetpreviousreading();
							//get average and arrears
							sgetaveragecumused();
							sgetarrears();
							nbillamt = 0;
							for (int i = 0; i < dgva.Rows.Count; i++)
							{
								nbillamt += Convert.ToDecimal(dgva.Rows[i].Cells[1].Value);
							}
							tbarrears.Text = nbillamt.ToString("###,##0.00");

						}
						//sdisplaydetails();
						//get rates

					}
					else
					{
						MessageBox.Show("Account code is not valid!");
						tbAcctno.Focus();
					}
				}
				cmd.Dispose();
			}
			dbcon.CloseConnection();
		}
		private void sgetarrears()
		{
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dtb = new DataTable();
			ssql = "select billperiod,billamt,ftax,wmf,penalty,discount,payment from bcdb.reading_bc where mascode=@mc and (billamt>payment or payment is null) ";
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				using (dtb = new DataTable())
				{
					cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
					dtb = dbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count > 0)
					{
						dgva.Rows.Clear();
						foreach (DataRow rs in dtb.Rows)
						{
							dgva.Rows.Add();
							r = dgva.Rows.Count - 1;
							dgva.Rows[r].Cells[0].Value = rs["billperiod"].ToString();
							dgva.Rows[r].Cells[1].Value = rs["billamt"].ToString();
						}
					}
				}
			}
			dbcon.CloseConnection();

		}
		private void sgetaveragecumused()
		{
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dtb = new DataTable();
			ssql = "select count(billperiod) as nbp,sum(cumused) as cmused from bcdb.reading_bc where mascode=@mc";
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				using (dtb = new DataTable())
				{
					cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
					dtb = dbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count > 0)
					{
						foreach (DataRow rs in dtb.Rows)
						{
							if (rs["cmused"] != DBNull.Value && rs["nbp"] != DBNull.Value)
							{
								int nave = Convert.ToInt32(rs["cmused"]) / Convert.ToInt32(rs["nbp"]);
								tbavecmused.Text = nave.ToString();
							}

						}
					}
				}
			}
			dbcon.CloseConnection();
		}

		decimal nminrate, nrate1120, nrate2130, nrate30over;
		int ovalue;
		private void tbcr_KeyDown(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Enter && tbcr.Text != "")
			{
				if (Int32.TryParse(tbcr.Text, out ovalue))
				{
					if (ovalue >= Convert.ToInt32(tbpr.Text))
					{
						ncumu = 0; ncumu1120 = 0; ncumu2130 = 0; ncumu30o = 0;

						nminamt = 0; nminamt1120 = 0; nminamt2130 = 0; nminamt30o = 0;
						ncumu = Convert.ToInt32(tbcr.Text) - Convert.ToInt32(tbpr.Text);
						tbcmu.Text = ncumu.ToString();
						//compute bill amount
						scomputebillamount();
					}
					else
					{
						MessageBox.Show("Present reading must be higher than the previous reading!");
						tbcr.Focus();
					}
				}
				else
				{
					MessageBox.Show("Please input numbers only!");
					tbcr.Focus();
				}


			}

		}

		decimal nbillamt;

		private void btnPost_Click(object sender, EventArgs e)
		{
			string qry = "select * from bcdb.reading_bc where mascode=@mc and billperiod=@bp";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
				cmd.Parameters.AddWithValue("@bp", dtpBP.Value.ToString("yyyyMM"));
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(qry, cmd);
					if (dtb.Rows.Count == 0)
					{
						ssql = "insert into bcdb.reading_bc (mascode,zn,bk,meterno,billperiod,previous,present,cumused,billamt,ftax,wmf,discount,others,payment,ttype,refdate,duedate,startdate,enddate,usr,seqno) " +
							"values(@mc,@zn,@bk,@mn,@bp,@pv,@pr,@cu,@ba,@ft,@wm,@dc,@ot,@pay,@tt,@rdt,@ddt,@sdt,@edt,@usr,@sq)";
						using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
						{
							cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
							cmd2.Parameters.AddWithValue("@zn", Program.zone);
							cmd2.Parameters.AddWithValue("@bk", Program.book);
							cmd2.Parameters.AddWithValue("@mn", smeterno);
							cmd2.Parameters.AddWithValue("@bp", dtpBP.Value.ToString("yyyyMM"));
							cmd2.Parameters.AddWithValue("@pv", tbpr.Text);
							cmd2.Parameters.AddWithValue("@pr", tbcr.Text);
							cmd2.Parameters.AddWithValue("@cu", tbcmu.Text);
							cmd2.Parameters.AddWithValue("@ba", tbbillamt.Text);
							cmd2.Parameters.AddWithValue("@ft", tbftax.Text);
							cmd2.Parameters.AddWithValue("@wm", tbwmf.Text);
							cmd2.Parameters.AddWithValue("@dc", tbdisc.Text);
							cmd2.Parameters.AddWithValue("@ot", tbothers.Text);
							cmd2.Parameters.AddWithValue("@pay", 0);
							cmd2.Parameters.AddWithValue("@tt", "0");
							cmd2.Parameters.AddWithValue("@rdt", dtpRDate.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@ddt", dtpdue.Value.AddDays(10).ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@sdt", dtpStart.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@edt", dtpEnd.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@usr", Program.usr);
							cmd2.Parameters.AddWithValue("@sq", 1);
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();
							cmd2.Dispose();
						}
					}
					else
					{
						//update
						ssql = "update bcdb.reading_bc set present=@cr,cumused=@cu,billamt=@ba,ftax=@ft,wmf=@wm,discount=@dc,others@ot,refdate=@rdt,duedate=@ddt,startdate=@sdt,enddate=@edt,usr=@usr) " +
							"where mascode=@mc and billperiod=@bp";
						using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
						{
							cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
							cmd2.Parameters.AddWithValue("@pv", tbpr.Text);
							cmd2.Parameters.AddWithValue("@pr", tbcr.Text);
							cmd2.Parameters.AddWithValue("@cu", tbcmu.Text);
							cmd2.Parameters.AddWithValue("@ba", tbbillamt.Text);
							cmd2.Parameters.AddWithValue("@ft", tbftax.Text);
							cmd2.Parameters.AddWithValue("@wm", tbwmf.Text);
							cmd2.Parameters.AddWithValue("@dc", tbdisc.Text);
							cmd2.Parameters.AddWithValue("@ot", tbothers.Text);
							cmd2.Parameters.AddWithValue("@rdt", dtpRDate.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@ddt", dtpdue.Value.AddDays(10).ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@sdt", dtpStart.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@edt", dtpEnd.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@usr", Program.usr);
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();
							cmd2.Dispose();
						}
					}
					dtb.Dispose();
				}
				MessageBox.Show("Billing has been saved!");
				sinit();

				newdbcon.CloseConnection();
			}
		}

		private void sinit()
		{
			tbAcctno.Text = "";
			tbName.Text = "";
			tbAddress.Text = "";
			tbmascode.Text = "";
			tbpr.Text = "";
			tbcr.Text = "";
			tbcmu.Text = "";
			tbbillamt.Text = "";
			tbwmf.Text = "";
			tbftax.Text = "";
			tbdisc.Text = "0";
			tbothers.Text = "0";
			tbcmupr.Text = "";
			dgva.Rows.Clear();
			tbavecmused.Text = "0";
			tbarrears.Text = "0";
			tbsrdisc.Text = "0";
		}

		private void scomputebillamount()
		{
			if (ncumu >= nmin)
			{
				//1st 10
				nminamt = nminrate;
				ncumu = ncumu - Convert.ToInt32(nmin);
				if (ncumu >= nmin)
				{
					//2nd 10
					nminamt1120 = nmin * Convert.ToDecimal(nrate1120);
					ncumu  = ncumu - Convert.ToInt32(nmin);
					if (ncumu >= nmin)
					{
						//3rd 10
						nminamt2130 = nmin * Convert.ToDecimal(nrate2130);
						ncumu  = ncumu - Convert.ToInt32(nmin);
						if (ncumu >= 1)
						{
							nminamt30o = ncumu * Convert.ToDecimal(nrate30over);
						}
					}
					else
					{
						nminamt2130 = ncumu * Convert.ToDecimal(nrate2130);
					}
				}
				else
				{
					nminamt1120 = ncumu * Convert.ToDecimal(nrate1120);
				}
			}
			else
			{
				nminamt = Convert.ToDecimal(nminrate);
			}
			nbillamt = nminamt + nminamt1120 + nminamt2130 + nminamt30o;
			nftax = nbillamt * nftaxrate;
			tbbillamt.Text = nbillamt.ToString("###,##0.00");
			tbftax.Text = nftax.ToString("##,##0.00");
			tbwmf.Text = nwmf.ToString();
		}

		decimal nminamt, nminamt1120, nminamt2130, nminamt30o,nwmf,nftaxrate,nftax;
		Int32 nmin, ncumu, ncumu1120, ncumu2130, ncumu30o;

		private void sgetrates()
		{
			
			ncumu = 0; ncumu1120 = 0; ncumu2130 = 0; ncumu30o = 0; 
			nminamt = 0;nminamt1120 = 0;nminamt2130 = 0;nminamt30o = 0;
			//ncumu = Convert.ToInt32(tbcr.Text) - Convert.ToInt32(tbpr.Text);
			string codeValue = nclcode.ToString();
			string msizeValue = nmsize.ToString();
			DataRow[] dr = dtbrates.Select($"code = '{codeValue}' AND msize = '{msizeValue}'");
			nmin = Convert.ToInt32(dr[0]["min"]);
			nminrate = Convert.ToDecimal(dr[0]["minrate"]);
			nrate1120 = Convert.ToDecimal(dr[0]["rate1120"]);
			nrate2130 = Convert.ToDecimal(dr[0]["rate2130"]);
			nrate30over = Convert.ToDecimal(dr[0]["rate30up"]);
			nwmf = Convert.ToDecimal(dr[0]["wmf"]);
			nftaxrate = Convert.ToDecimal(dr[0]["ftax"]);
			
		}

		private void sgetpreviousreading()
		{
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dtb = new DataTable();
			ssql = "select * from bcdb.reading_bc where mascode=@mc order by billperiod desc limit 1";
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				using (dtb = new DataTable())
				{
					cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
					dtb = dbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count > 0)
					{
						foreach (DataRow rs in dtb.Rows)
						{
							if (rs["present"] != DBNull.Value)
							{
								if (Convert.ToInt32(rs["present"]) > 0)
								{
									tbpr.Text = rs["present"].ToString();
									string sdate = rs["billperiod"].ToString().Substring(0, 4) + "-" + rs["billperiod"].ToString().Substring(4, 2) + "-01";
									dtppbp.Value = Convert.ToDateTime(sdate);
									dtpBP.Value = dtppbp.Value.AddMonths(1);
								}
								else
								{
									tbpr.Text = rs["previous"].ToString();
									string sdate = rs["billperiod"].ToString().Substring(0, 4) + "-" + rs["billperiod"].ToString().Substring(4, 2) + "-01";
									dtppbp.Value = Convert.ToDateTime(sdate);
									dtpBP.Value = dtppbp.Value;
								}
							}
						}
					}
				}
			}
			dbcon.CloseConnection();
		}

		private void specialbilling_Load(object sender, EventArgs e)
		{
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			dtbrates = new DataTable();
			ssql = "select * from bcdb.rates order by code";
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				using (dtbrates = new DataTable())
				{
					dtbrates = dbcon.get_records(ssql, cmd);
					if (dtbrates.Rows.Count > 0)
					{

					}
				}
			}
			dbcon.CloseConnection();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();

		}
	}
}
