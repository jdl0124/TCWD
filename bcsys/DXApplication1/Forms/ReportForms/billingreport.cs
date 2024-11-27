using bcsys.modules;
using DevExpress.CodeParser;
using DevExpress.XtraCharts;
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

namespace bcsys.Forms.Reports
{
	

	public partial class billingreport : Form
	{
		int retries, r;
		string ssql;
		public billingreport()
		{
			InitializeComponent();
		}

		private void dgvBrgy_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				if (Convert.ToBoolean(dgvBrgy.CurrentRow.Cells[0].Value) == false)
				{
					dgvBrgy.CurrentRow.Cells[0].Value = true;
				}
				else
				{
					dgvBrgy.CurrentRow.Cells[0].Value = false;
				}
			}
		}

		private void dgvZnBk_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				if (Convert.ToBoolean(dgvZnBk.CurrentRow.Cells[0].Value) == false)
				{
					dgvZnBk.CurrentRow.Cells[0].Value = true;
				}
				else
				{
					dgvZnBk.CurrentRow.Cells[0].Value = false;
				}
			}
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (Program.reporttype == "Unbilled")
			{
				sunbilled();
			}
			else if (Program.reporttype == "Disconnection")
			{

			}

		}
		private void sunbilled()
		{
			
			if (xtabpage.SelectedTabPageIndex == 0)
			{
				ssql = "select a.*,b.name,b.mascode from bcdb.reading_bc a, bcdb.master b where a.mascode=b.mascode and b.bgycode=@bgy and a.billperiod=@bp and (a.present=0 or a.present is null)";
				//MessageBox.Show("barangay");
				for (int i = 0; i < dgvBrgy.Rows.Count; i++)
				{
					if (Convert.ToBoolean(dgvBrgy.Rows[i].Cells[0].Value) == true)
					{
						sunbilleddisplay();
					}
				}
			}
			else if (xtabpage.SelectedTabPageIndex == 1)
			{
				ssql = "select a.*,b.name,b.mascode from bcdb.reading_bc a, bcdb.master b where a.mascode=b.mascode and b.zn=@zn and b.bk=@bk and a.billperiod=@bp and (a.present=0 or a.present is null)";
			}

			
		}
		private void sunbilleddisplay()
		{
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				using (dtb = new DataTable())
				{
					cmd.Parameters.AddWithValue("@bgy",dgvBrgy.CurrentRow.Cells[2].Value);
					cmd.Parameters.AddWithValue("@bp", dtpBP.Value.ToString("yyyyMMM"));
					dtb = dbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count > 0)
					{
						dgvUnbilled.Rows.Clear();
						foreach (DataRow dr in dtb.Rows)
						{
							dgvUnbilled.Rows.Add();
							r = dgvUnbilled.Rows.Count - 1;
							dgvUnbilled.Rows[r].Cells[0].Value = r + 1;
							dgvUnbilled.Rows[r].Cells[1].Value = dgvBrgy.CurrentRow.Cells[1];
							dgvUnbilled.Rows[r].Cells[2].Value = dr["meterno"].ToString();
							dgvUnbilled.Rows[r].Cells[3].Value = dr["name"].ToString();
						}
					}
					dtb.Dispose();
				}
				cmd.Dispose();
			}
			dbcon.CloseConnection();
		}
		private void sdisconnection()
		{
			ssql = "select * from bcdb.reading_bc a, bcdb.master b where a.mascode=b.mascode and (totbill>payment or payment is null)";
		}

		private void billingreport_Load(object sender, EventArgs e)
		{
			if (Program.reporttype == "Unbilled")
			{
				gc1.Text = "Unbilled Consumers";
			}
			else if (Program.reporttype == "Disconnection")
			{
				gc1.Text = "Consumer with Disconnectin Notice";
			}

			string qry = "select * FROM bcdb.barangay order by name";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(qry, cmd);
					if (dtb.Rows.Count > 0)
					{
						dgvBrgy.Rows.Clear();
						foreach (DataRow dr in dtb.Rows)
						{
							dgvBrgy.Rows.Add();
							r = dgvBrgy.Rows.Count - 1;
							dgvBrgy.Rows[r].Cells[1].Value = dr["name"].ToString();
							dgvBrgy.Rows[r].Cells[2].Value = dr["code"].ToString();
						}
					}
					dtb.Dispose();
				}
				cmd.Dispose();
			}
			

			qry = "select zone,book,lbp,rday FROM bcdb.zonebk order by zone,book";
			newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
			{
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(qry, cmd);
					if (dtb.Rows.Count > 0)
					{
						dgvZnBk.Rows.Clear();
						foreach (DataRow dr in dtb.Rows) 
						{ 
							dgvZnBk.Rows.Add();
							r = dgvZnBk.Rows.Count - 1;
							dgvZnBk.Rows[r].Cells[1].Value = dr["zone"].ToString();
							dgvZnBk.Rows[r].Cells[2].Value = dr["book"].ToString();
						}
					}
				}
			}
			//get barangay

			newdbcon.CloseConnection();

		}
	}
}
