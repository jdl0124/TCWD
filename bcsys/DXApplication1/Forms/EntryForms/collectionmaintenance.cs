using bcsys.modules;
using DevExpress.Data.Svg;
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
	public partial class collectionmaintenance : DevExpress.XtraEditors.XtraForm
	{
		string ssql, bp;
		int retries;
		public collectionmaintenance()
		{
			InitializeComponent();
		}

		private void collectionmaintenance_Load(object sender, EventArgs e)
		{
			bp = dtpDate.Value.ToString("yyyyMM");
			sloadtellers();
		}
		private void sloadtellers()
		{
			ssql = "SELECT * FROM bcdb.users where utype=2 order by username";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);

			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				//cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
				using (rs = new DataTable())
				{

					rs = newdbcon.get_records(ssql, cmd);
					if (rs.Rows.Count > 0)
					{
						foreach (DataRow dr in rs.Rows)
						{
							cbteller.Items.Add(dr["username"]);
						}


					}
					cmd.Dispose();
				}
			}
			newdbcon.CloseConnection();
		}
		private void tsbClose_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void sdisplaycollection()
		{

			ssql = "select a.tdate,a.orno,b.name,a.amtdue,b.mascode from bcdb.pay_h a,bcdb.master b " +
				"where a.mascode=b.mascode and a.teller=@tel and a.tdate=@dt " +
				"order by orno";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@tel", cbteller.Text);
				cmd.Parameters.AddWithValue("@dt", dtpDate.Value.ToString("yyyy-MM-dd"));
				using (rs = new DataTable())
				{
					rs = dbcon.get_records(ssql, cmd);
					if (rs.Rows.Count > 0)
					{
						dgv.Columns.Clear();
						dgv.DataSource = rs;
						sformatdgv();
					}
				}
				cmd.Dispose();
			}
			dbcon.CloseConnection();

		}

		private void tsbCancel_Click(object sender, EventArgs e)
		{
			if (Program.usr == "juvy" || Program.usr == "1")
			{
				DialogResult ans = MessageBox.Show("Are you sure?", "Collection", MessageBoxButtons.YesNo);
				if (ans == DialogResult.Yes)
				{
					//update pay_,pay_d

					DBConnect dbcon = new DBConnect();
					dbcon.OpenConnection(retries);
					// newdbcon.mytable = "master.mastfile";
					
					ssql = "update bcdb.pay_h set amtdue=0,iscanceled='1',canceleddate=@dt,remarks=@rem where orno=@or";
					using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
					{
						cmd.Parameters.AddWithValue("@or", dgv.CurrentRow.Cells[1].Value);
						cmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyyy-MM-dd"));
						cmd.Parameters.AddWithValue("@rem", "Canceled-" + dgv.CurrentRow.Cells[3].Value);
						cmd.Prepare();
						cmd.ExecuteNonQuery();
						cmd.Dispose();

					}

					DataTable rs = new DataTable();
					ssql = "select * from bcdb.pay_d where orno=@or and ttype='1'";
					using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
					{
						cmd.Parameters.AddWithValue("@or", dgv.CurrentRow.Cells[1].Value.ToString());
						using (rs = new DataTable())
						{

							rs = dbcon.get_records(ssql, cmd);
							if (rs.Rows.Count > 0)
							{
								foreach (DataRow rw in rs.Rows)
								{
									ssql = "update bcdb.reading_bc set payment=null where mascode=@mc and billperiod=@bp";
									using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
									{
										cmd1.Parameters.AddWithValue("@mc", rw["mascode"]);
										cmd1.Parameters.AddWithValue("@bp", rw["billperiod"]);
										cmd1.Prepare();
										cmd1.ExecuteNonQuery();
										cmd1.Dispose();

									}

								}

							}
						}
						cmd.Dispose();

					}
					ssql = "update bcdb.pay_d set paidamount=0 where orno=@or";
					using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
					{
						cmd.Parameters.AddWithValue("@or", dgv.CurrentRow.Cells[1].Value);
						//cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
						//cmd2.Parameters.AddWithValue("@bp", dgvPayment.CurrentRow.Cells[16].Value);
						//cmd2.Parameters.AddWithValue("@amt", namt);

						cmd.Prepare();
						cmd.ExecuteNonQuery();
						cmd.Dispose();

					}
					rs.Dispose();
					dbcon.CloseConnection();

				}
			}
		}

		private void btnGo_Click_1(object sender, EventArgs e)
		{
			sdisplaycollection();
		}

		private void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				foreach (DataGridViewRow row in dgv.Rows)
				{
					if (row.Cells[1].Value.ToString() == tbSearch.Text)
					{
						dgv.CurrentCell = row.Cells[1];
						return;
					}
				}
			}
			
		}

		private void tsbClose_Click_1(object sender, EventArgs e)
		{
			this.Close();

		}

		private void sformatdgv()
		{
			dgv.Columns[0].HeaderText = "Date";
			dgv.Columns[1].HeaderText = "ORNo.";
			dgv.Columns[2].HeaderText = "Consumer Name";
			dgv.Columns[3].HeaderText = "Amount Paid";
			dgv.Columns[4].HeaderText = "MasCode";
			dgv.Columns[0].Width = 70;
			dgv.Columns[0].DefaultCellStyle.Format = "d";
			//dgv.Columns[0].Visible = false;
			dgv.Columns[1].Width = 70;
			dgv.Columns[2].Width = 200;
			dgv.Columns[3].Width = 70;
			dgv.Columns[3].DefaultCellStyle.Format = "N2";
			dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgv.Columns[4].Visible = false;
		}
	}
}