using bcsys.modules;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace bcsys.Forms.EntryForms
{
	public partial class changeform : DevExpress.XtraEditors.XtraForm
	{
		int retries,r;
		string ssql;
		public changeform()
		{
			InitializeComponent();
		}

		private void changeform_Load(object sender, EventArgs e)
		{
			gbname.Parent = this;
			gbaccount.Parent = this;
			if (Program.acct == "Change Account")
			{
				gbname.Visible = false;
				gbaccount.Visible = true;

			}
			else if (Program.acct == "Change Name/Address")
			{
				gbaccount.Visible = false;
				gbpullout.Visible = false;
				gbname.Location = new Point(7, 120);
				gbname.Height = 228;
				gbname.Visible = true;
				
			}
			else if (Program.acct == "Pull Out Meter")
			{
				this.Height = 358;
				gbname.Visible = false;	
				gbaccount.Visible = false;
			}
			sloadbrand();
			this.Tag = "0";
			SLoadClassMeterType();
			this.Tag = "1";

		}
		private void sloadbrand()
		{
			ssql = "SELECT brand,code FROM bcdb.meters order by code";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				//cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
				using (rs = new DataTable())
				{
					rs = newdbcon.get_records(ssql, cmd);
					if (rs.Rows.Count > 0)
					{
						cbBrand.Items.Clear();
						cbBrand.DisplayMember = rs.Columns[0].ToString();
						cbBrand.ValueMember = rs.Columns[1].ToString();
						cbBrand.DataSource = rs.DefaultView;
					}
				}
			}
			newdbcon.CloseConnection();
		}
		private void SLoadClassMeterType()
		{
			string qry = "SELECT * FROM bcdb.classification order by classcode";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable result = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				//cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
				using (result = new DataTable())
				{
					result = newdbcon.get_records(qry, cmd);
					if (result.Rows.Count > 0)
					{
						cbClass.Items.Clear();
						cbClass.DisplayMember = result.Columns[1].ToString();
						cbClass.ValueMember = result.Columns[0].ToString();
						cbClass.DataSource = result.DefaultView;
					}

				}
			}
			qry = "SELECT * FROM bcdb.metersize order by code";
			result = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				//cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
				using (result = new DataTable())
				{
					result = newdbcon.get_records(qry, cmd);
					if (result.Rows.Count > 0)
					{
						cbMSize.Items.Clear();
						cbMSize.DisplayMember = result.Columns[1].ToString();
						cbMSize.ValueMember = result.Columns[0].ToString();
						cbMSize.DataSource = result.DefaultView;
					}

				}
			}
			qry = "SELECT * FROM bcdb.bgyzn where bgycode=@bgy order by bgycode";
			result = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@bgy", 0);
				using (result = new DataTable())
				{
					result = newdbcon.get_records(qry, cmd);
					if (result.Rows.Count > 0)
					{
						cbZone.Items.Clear();
						foreach (DataRow rw in result.Rows)
						{
							cbZone.Items.Add(rw["zn"]);
						}

					}

				}
			}
			newdbcon.CloseConnection();
		}
		private void btnConSearch_Click(object sender, EventArgs e)
		{
			Form consearch = new consearch();
			changeIcon.SetApplicationIcon(Application.StartupPath + @"\24x24.ico", consearch);
			consearch.Text = this.Text;
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

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.Tag.ToString() == "1")
			{
				if (cbClass.SelectedIndex >= 0)
				{
					tbCMCode.Text = cbClass.SelectedValue.ToString() + cbMSize.SelectedValue.ToString();
				}

			}
			Tag = "1";
		}

		private void cbMSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.Tag.ToString() == "1")
			{
				if (cbMSize.SelectedIndex >= 0)
				{
					tbCMCode.Text = cbClass.SelectedValue.ToString() + cbMSize.SelectedValue.ToString();
				}
				Tag = "1";
			}
		}
		int napno;
		private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbznbk.Text = cbZone.Text + cbBook.Text;
			string qry = "SELECT acc FROM bcdb.master where zn=@zn and bk=@bk order by acc desc limit 1";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable result = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				//cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
				using (result = new DataTable())
				{
					cmd.Parameters.AddWithValue("@zn", cbZone.Text);
					cmd.Parameters.AddWithValue("@bk", cbBook.Text);
					result = newdbcon.get_records(qry, cmd);
					if (result.Rows.Count > 0)
					{
						foreach (DataRow row in result.Rows)
						{
							napno = Convert.ToInt32(row["acc"].ToString().Substring(0, 3));
							napno++;
							tbAcc.Text = napno.ToString().PadLeft(3, '0') + "-0";
						}

					}
					else
					{
						tbAcc.Text = "001-0";
					}

				}
			}
			newdbcon.CloseConnection();
		}

		private void tsbSave_Click(object sender, EventArgs e)
		{
			if (Program.acct == "Change Account")
			{
				ssavechangeaccount();

			}
			else if (Program.acct == "Change Name/Address")
			{
				ssavenameaddress ();


			}
			else if(Program.acct == "Pull Out Meter")
			{
				
			}
		}

		private void ssavechangeaccount()
		{
			DBConnect ndbcon = new DBConnect();
			ndbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			ssql = "update bcdb.master set znacc12=@zb,zn=@zn,bk=@bk,acc=@ac,classcode=@cc,msize=@ms where mascode=@mc";
			using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
			{
				cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
				cmd2.Parameters.AddWithValue("@zb", tbznbk.Text + tbCMCode.Text + tbAcc.Text);
				cmd2.Parameters.AddWithValue("@zn", cbZone.Text);
				cmd2.Parameters.AddWithValue("@bk", cbBook.Text);
				cmd2.Parameters.AddWithValue("@acc", tbAcc.Text);
				cmd2.Parameters.AddWithValue("@cc", cbClass.SelectedValue);
				cmd2.Parameters.AddWithValue("@ms", cbMSize.SelectedValue);
				cmd2.Prepare();
				cmd2.ExecuteNonQuery();
				cmd2.Dispose();
			}
			ndbcon.CloseConnection();
		}
		private void ssavenameaddress()
		{
			DBConnect ndbcon = new DBConnect();
			ndbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			ssql = "update bcdb.master set name=@na,address=@ad where mascode=@mc";
			using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
			{
				cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
				cmd2.Parameters.AddWithValue("@na", tbnewname.Text );
				cmd2.Parameters.AddWithValue("@ad", tbnewaddress.Text);
				cmd2.Prepare();
				cmd2.ExecuteNonQuery();
				cmd2.Dispose();
			}
			ndbcon.CloseConnection();
		}

		private void ssavepulledoutmeter()
		{
			DBConnect ndbcon = new DBConnect();
			ndbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			ssql = "update bcdb.master set name=@na,address=@ad where mascode=@mc";
			using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
			{
				cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
				cmd2.Parameters.AddWithValue("@na", tbnewname.Text);
				cmd2.Parameters.AddWithValue("@ad", tbnewaddress.Text);
				cmd2.Prepare();
				cmd2.ExecuteNonQuery();
				cmd2.Dispose();
			}
			ndbcon.CloseConnection();
		}
		private void sdisplayname()
		{
			ssql = "select a.*,b.previous,b.present,b.cumused from bcdb.master a,bcdb.reading_bc b where a.mascode=b.mascode and left(znacc12,6)=@zn order by billperiod desc limit 1";
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
						foreach (DataRow dr in rs.Rows)
						{
							tbmascode.Text = dr["mascode"].ToString();
							tbAcctno.Text = dr["znacc12"].ToString();
							tbName.Text = dr["Name"].ToString();
							tbAddress.Text = dr["address"].ToString();
							Program.zone = dr["zn"].ToString();
							Program.book = dr["bk"].ToString();
							tbometerno.Text = dr["m_no"].ToString();
							tboldrdg.Text = dr["previous"].ToString();
							tboprdg.Text = dr["present"].ToString();
							tbocode.Text = dr["m_brand"].ToString();
							cbBrand.SelectedValue = tbocode.Text;
							tbcumused.Text = (Convert.ToInt32(dr["present"].ToString()) - Convert.ToInt32(dr["previous"].ToString())).ToString();

							dgvh.Rows.Clear();
							//get history
							ssql = "select * from bcdb.changemeter where mascode=@mc order by cdate desc";
							DBConnect ndbcon = new DBConnect();
							ndbcon.OpenConnection(retries);
							DataTable dt = new DataTable();
							using (MySqlCommand cmd1 = new MySqlCommand(ssql, ndbcon.database_connection))
							{
								cmd1.Parameters.AddWithValue("@mc", tbAcctno.Text.Substring(0, 6));
								using (dt = new DataTable())
								{
									dt = ndbcon.get_records(ssql, cmd1);
									if (dt.Rows.Count > 0)
									{

										foreach (DataRow dtr in dt.Rows)
										{
											dgvh.Rows.Add();
											r = dgvh.Rows.Count - 1;
											dgvh.Rows[r].Cells[0].Value = dtr["meterno"].ToString();
											dgvh.Rows[r].Cells[1].Value = dtr["changedate"].ToString();
										}
									}
								}
								cmd1.Dispose();
							}
							ndbcon.CloseConnection();
						}
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
	}
}