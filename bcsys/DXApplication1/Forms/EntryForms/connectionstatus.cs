using bcsys.modules;
using DevExpress.Charts.Native;
using DevExpress.CodeParser;
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
using bcsys.modules;

namespace bcsys.Forms.EntryForms
{
	public partial class connectionstatus : DevExpress.XtraEditors.XtraForm
	{
		int retries, mstat,r;
		string ssql;
		public connectionstatus()
		{
			InitializeComponent();
		}

		private void tsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			this.Close();

		}

		private void btnConSearch_Click(object sender, EventArgs e)
		{
			Form consearch = new consearch();
			changeIcon.SetApplicationIcon(Application.StartupPath + @"\24x24.ico",consearch);
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
		private void sdisplayname()
		{
			ssql = "select a.*,b.previous,b.present,b.cumused from bcdb.master a,bcdb.reading_bc b where a.mascode=b.mascode and a.mascode=@mc order by billperiod desc limit 1";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
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
							tbmeterno.Text = dr["m_no"].ToString();
							tbpr.Text = dr["previous"].ToString();
							tbcr.Text = dr["present"].ToString();
							tbbrand.Text = dr["m_brand"].ToString();
							cbBrand.SelectedValue = tbbrand.Text;
							tbcmu.Text =  (Convert.ToInt32(dr["present"].ToString()) - Convert.ToInt32(dr["previous"].ToString())).ToString();
							if (dr["cust_stat"] != DBNull.Value)
							{
								if (Convert.ToInt32(dr["cust_stat"]) == 1)
								{
									dtpdc.Value = Convert.ToDateTime(dr["mark4disdate"]);
									dtpord.Value = Convert.ToDateTime(dr["pay_date"]);
									mstat = Convert.ToInt32(dr["meter_stat"]);
									if (mstat == 0) { rbna.Checked = true; }
									else if (mstat == 1) { rbplocked.Checked = true; }
									else if (mstat == 2) { rbpout.Checked = true; }
									else if (mstat == 3) { rbukey.Checked = true; }
									else if (mstat == 4) { rbseal.Checked = true; }
									else if (mstat == 5) { rbplug.Checked = true; }
									else if (mstat == 6) { rbtaping.Checked = true; }
								}
							}
							dgvh.Rows.Clear();
							//get history
							ssql = "select * from bcdb.disconhistory where mascode=@mc order by hdate desc";
							DBConnect ndbcon = new DBConnect();
							ndbcon.OpenConnection(retries);
							DataTable dt = new DataTable();
							using (MySqlCommand cmd1 = new MySqlCommand(ssql, ndbcon.database_connection))
							{
								cmd1.Parameters.AddWithValue("@mc", tbAcctno.Text.Substring(0, 6));
								using (dt = new DataTable())
								{
									rs = dbcon.get_records(ssql, cmd1);
									if (dt.Rows.Count > 0)
									{
										
										foreach (DataRow dtr in dt.Rows)
										{
											dgvh.Rows.Add();
											r = dgvh.Rows.Count - 1;
											dgvh.Rows[r].Cells[0].Value = dtr["meterno"].ToString();
											dgvh.Rows[r].Cells[1].Value = dtr["datediscon"].ToString();
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

		private void connectionstatus_Load(object sender, EventArgs e)
		{
			rbpout.Checked = true;
			sloadbrand();
			if (this.Text == "Reconnection")
			{
				gbRecon.Visible = true;
				gbdisconnect.Visible = false;
				btnRecon.Visible =true;
				btnPost.Visible = false;
				btnmark.Visible = false;	
			}
			else
			{
				gbRecon.Visible = false;
				gbdisconnect.Visible = true;
				btnRecon.Visible = false;
				btnPost.Visible = true;
				btnmark.Visible = true;
			}
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
		private void btnRecon_Click(object sender, EventArgs e)
		{
			string qry = "select * from bcdb.disconhistory where mascode=@mc and meterno=@mn and datediscon=@ddt";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
				cmd.Parameters.AddWithValue("@bp", dtpdc.Value.ToString("yyyy-MM-dd"));
				cmd.Parameters.AddWithValue("@mn", tbmeterno.Text);
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(qry, cmd);
					if (dtb.Rows.Count > 0)
					{
						ssql = "update bcdb.master set cust_stat='0',daterec=@rdt,activedate=@adt where mascode=@mc";
						using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
						{
							cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
							cmd2.Parameters.AddWithValue("@rdt", dtprecon.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@adt", dtpactivate.Value.ToString("yyyy-MM-dd"));
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();
							cmd2.Dispose();
						}
						ssql = "update bcdb.disconhistory set daterecon=@rdt,activedate=@adt,reconor=@or,reconamt=@ramt," +
							"reconordate=@odt,meterstat=0 where mascode=@mc and meterno=@mn";
						using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
						{
							cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
							cmd2.Parameters.AddWithValue("@mn", tbmeterno.Text);
							cmd2.Parameters.AddWithValue("@rdt", dtprecon.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@adt", dtpactivate.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@odt", dtpord.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@ramt", tbramt.Text);
							cmd2.Parameters.AddWithValue("@or", tbror.Text);
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();
							cmd2.Dispose();
						}
					}
					dtb.Dispose();
				}
			}
			MessageBox.Show("Consumer's Account has been reconnected!");
			newdbcon.CloseConnection();
		}

		private void btnPost_Click(object sender, EventArgs e)
		{
			string qry = "select * from bcdb.disconhistory where mascode=@mc and meterno=@mn and datediscon=@ddt";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
				cmd.Parameters.AddWithValue("@bp", dtpdc.Value.ToString("yyyy-MM-dd"));
				cmd.Parameters.AddWithValue("@mn", tbmeterno.Text);
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(qry, cmd);
					if (dtb.Rows.Count == 0)
					{
						ssql = "update bcdb.master set cust_stat='1',datediscon=@dt where mascode=@mc";
						using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
						{
							cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
							cmd2.Parameters.AddWithValue("@dt", dtpdc.Value.ToString("yyyy-MM-dd"));
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();
							cmd2.Dispose();
						}

						ssql = "insert into bcdb.disconhistory (mascode,hdate,meterno,brand,rprevious,rpresent,datediscon,disconamt,disconor,disconordate,meterstat,usr) " +
							"values(@mc,@hdt,@mn,@br,@pv,@pr,@ddt,@damt,@dor,@dord,@ms,@usr)";
						using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
						{
							cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
							cmd2.Parameters.AddWithValue("@hdt", DateTime.Now.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@mn", tbmeterno.Text);
							cmd2.Parameters.AddWithValue("@br", tbbrand.Text);
							cmd2.Parameters.AddWithValue("@pv", tbpr.Text);
							cmd2.Parameters.AddWithValue("@pr", tbcr.Text);
							cmd2.Parameters.AddWithValue("@ddt", dtpdc.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@damt", tbdamt.Text);
							cmd2.Parameters.AddWithValue("@dor", tbdorno.Text);
							cmd2.Parameters.AddWithValue("@dord", dtpord.Value.ToString("yyyy-MM-dd"));
							if (rbna.Checked == true) { mstat = 0; }
							else if (rbplocked.Checked == true ) { mstat = 1; }
							else if (rbpout.Checked == true) { mstat = 2; }
							else if (rbukey.Checked == true ) { mstat = 3; }
							else if (rbseal.Checked == true ) { mstat = 4; }
							else if (rbplug.Checked == true) { mstat = 5; }
							else if (rbtaping.Checked == true) { mstat = 6; }

							cmd2.Parameters.AddWithValue("@ms", mstat);
							cmd2.Parameters.AddWithValue("@usr", Program.usr);
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();
							cmd2.Dispose();
						}
					}
					dtb.Dispose();
				}
				MessageBox.Show("Consumer Disconnection status has been saved!");
				sinit();
				newdbcon.CloseConnection();
				tbAcctno.Focus();
			}
		}
		private void sinit()
		{
			tbAcctno.Text = "";
			tbmascode.Text = "";
			tbAddress.Text = "";
			tbName.Text = "";
			tbcmu.Text = "";
			tbbalance.Text = "";
			tbbcode.Text = "";
			tbbrand.Text = "";
			cbBrand.SelectedIndex = -1;
			tbcr.Text = "";
			tbdamt.Text = "";
			tbdorno.Text = "";
			tbinitrdg.Text = "";
			tbmeterno.Text = "";
			tbpr.Text = "";
			tbramt.Text = "";
			tbror.Text = "";
			dgvh.Rows.Clear();

		}
	}
}