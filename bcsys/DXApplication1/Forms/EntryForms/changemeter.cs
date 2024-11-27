using bcsys.modules;
using DevExpress.CodeParser;
using DevExpress.Web.Internal.XmlProcessor;
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
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace bcsys.Forms.EntryForms
{
	public partial class changemeter : DevExpress.XtraEditors.XtraForm
	{
		int retries, r;
		string ssql;
		public changemeter()
		{
			InitializeComponent();
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
									dt = dbcon.get_records(ssql, cmd1);
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

		private void changemeter_Load(object sender, EventArgs e)
		{
			sloadbrand();
		}

		private void btnchange_Click(object sender, EventArgs e)
		{
			ssql = "select * from bcdb.changemeter where mascode=@mc and meterno=@mn and changedate=@cdt";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
				cmd.Parameters.AddWithValue("@cdt", dtpreplaced.Value.ToString("yyyy-MM-dd"));
				cmd.Parameters.AddWithValue("@mn", tbometerno.Text);
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count == 0)
					{
						//insert
						ssql = "insert into bcdb.changemeter (mascode,cdate,oldmeterno,oldbrand,oldpreviousrdg,oldpresentrdg,cumused," +
							"newmeterno,newbrand,newreading,changedate,reason,usr) " +
							"values(@mc,@ddt,@mn,@br,@pv,@pr,@cmu,@nmn,@nbr,@nrdg," +
							"@cdt,@rea,@usr)";
						using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
						{
							cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
							cmd2.Parameters.AddWithValue("@ddt", DateTime.Now.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@mn", tbometerno.Text);
							cmd2.Parameters.AddWithValue("@br", tbocode.Text);
							cmd2.Parameters.AddWithValue("@pv", tboldrdg.Text);
							cmd2.Parameters.AddWithValue("@pr", tboprdg.Text);
							cmd2.Parameters.AddWithValue("@cmu", tbcumused.Text);

							cmd2.Parameters.AddWithValue("@nmn", tbnmeterno.Text);
							cmd2.Parameters.AddWithValue("@nbr", tbncode.Text);
							cmd2.Parameters.AddWithValue("@nrdg", tbinitrdg.Text);
							cmd2.Parameters.AddWithValue("@cdt", dtpreplaced.Value.ToString("yyyy-MM-dd"));
							cmd2.Parameters.AddWithValue("@rea", tbreason.Text);
							cmd2.Parameters.AddWithValue("@usr", Program.usr);
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();
							cmd2.Dispose();
						}

						//update master file
						ssql = "update bcdb.master set brand=@nbr,m_no@nmn,m_prdg=@nrdg where mascode=@mc";
						using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
						{
							cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
							cmd2.Parameters.AddWithValue("@nmn", tbnmeterno.Text);
							cmd2.Parameters.AddWithValue("@nbr", tbncode.Text);
							cmd2.Parameters.AddWithValue("@nrdg", tbinitrdg.Text);
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();
							cmd2.Dispose();
						}

					}
				}
			}
			MessageBox.Show("New meter has been saved!");
			newdbcon.CloseConnection();
		}

		private void cbnewbrand_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbncode.Text = cbnewbrand.SelectedValue.ToString();
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
					rs = newdbcon.get_records(ssql , cmd);
					if (rs.Rows.Count > 0)
					{
						cbBrand.Items.Clear();
						cbBrand.DisplayMember = rs.Columns[0].ToString();
						cbBrand.ValueMember = rs.Columns[1].ToString();
						cbBrand.DataSource = rs.DefaultView;
						cbnewbrand.Items.Clear();
						cbnewbrand.DisplayMember = rs.Columns[0].ToString();
						cbnewbrand.ValueMember = rs.Columns[1].ToString();
						cbnewbrand.DataSource = rs.DefaultView;
					}
				}
			}
			newdbcon.CloseConnection();
		}
		private void sinit()
		{
			tbAcctno.Text = "";
			tbmascode.Text = "";
			tbAddress.Text = "";
			tbName.Text = "";
			cbBrand.SelectedIndex = -1;
			dgvh.Rows.Clear();
			tbreason.Text = string.Empty;

		}
	}
}