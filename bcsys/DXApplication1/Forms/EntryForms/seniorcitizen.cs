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

namespace bcsys.Forms.EntryForms
{
	public partial class seniorcitizen : DevExpress.XtraEditors.XtraForm
	{
		string ssql;
		int retries;
		public seniorcitizen()
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
						foreach (DataRow dr in rs.Rows)
						{
							tbmascode.Text = dr["mascode"].ToString();
							tbAcctno.Text = dr["znacc12"].ToString();
							tbName.Text = dr["Name"].ToString();
							tbAddress.Text = dr["address"].ToString();
							Program.zone = dr["zn"].ToString();
							Program.book = dr["bk"].ToString();
							tbtin.Text = dr["tin"].ToString();
							tbidno.Text = dr["scid"].ToString();
							if (dr["withscdisc"] != DBNull.Value)
							{
								dtps.Value = Convert.ToDateTime(dr["scstart"]);
								dtpe.Value = Convert.ToDateTime(dr["scend"]);
								if (Convert.ToInt32(dr["withscdisc"]) == 0)
								{
									cbsc.Checked = false;
									lblstat.Text = "Expired";
								}
								else
								{
									cbsc.Checked = true;
									lblstat.Text = "Current";
								}
							}
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

		private void dtps_ValueChanged(object sender, EventArgs e)
		{
			dtpe.Value = dtps.Value.AddYears(1);
			dtpe.Value = dtpe.Value.AddDays(-1);
		}

		private void tsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			this .Close();

		}

		private void btnPost_Click(object sender, EventArgs e)
		{
			string qry = "select * from bcdb.master where mascode=@mc";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(qry, cmd);
					if (dtb.Rows.Count > 0)
					{
						//update
						ssql = "update bcdb.master set tin=@tin,scid=@id,scstart=@sdt,scend=@edt,withscdisc=@sc) " +
							"where mascode=@mc";
						using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
						{
							cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
							cmd2.Parameters.AddWithValue("@tin", tbtin.Text);
							cmd2.Parameters.AddWithValue("@id", tbidno.Text);
							cmd2.Parameters.AddWithValue("@sdt", dtps.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@edt", dtpe.Value.ToString("yyyy-MM-dd"));
							if (cbsc.Checked)
							{
								cmd2.Parameters.AddWithValue("@sc", 1);
							}
							else
							{
								cmd2.Parameters.AddWithValue("@sc", 0);
							}
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();
							cmd2.Dispose();
						}
					}
					dtb.Dispose();
				}
				MessageBox.Show("Senior Citizen status has been saved!");
				//sinit();

				newdbcon.CloseConnection();
			}
		}
	}
}