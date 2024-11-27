using bcsys.modules;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export.Pdf;
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

namespace bcsys.Forms.ReportForms
{
	public partial class dlybillingsummary : DevExpress.XtraEditors.XtraForm
	{
		int retries, r, i;
		string ssql, sorno, sname, bp, lznbk;
		DataTable dtb = new DataTable();
		private DataGridView[] dgvzn;

		public dlybillingsummary()
		{
			InitializeComponent();
		}

		private void tsbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			i = 0;
			bp = dtpDate.Value.ToString("yyyyMM");
			sbillingsummary();
			
		}
		private void sbillingsummary()
		{
			ssql = "select zn,bk,sum(cumused) as cu,sum(billamt) as ba,sum(ftax) as ft,sum(wmf) as wm,sum(penalty) as pn,count(mascode) as cnt from reading_bc where rdgdate=@dd group by zn,bk";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd1.Parameters.AddWithValue("@dd", dtpDate.Value.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						decimal ntotal;
						int ncnt;
						ntotal = 0;ncnt = 0;
						dgv.Rows.Clear();
						foreach (DataRow rs in dt.Rows)
						{

							dgv.Rows.Add();
							r = dgv.Rows.Count - 1;
							dgv.Rows[r].Cells[0].Value = rs["zn"].ToString() + rs["bk"].ToString();
							dgv.Rows[r].Cells[1].Value = rs["cu"];
							dgv.Rows[r].Cells[2].Value = rs["ba"];
							dgv.Rows[r].Cells[3].Value = rs["ft"];
							dgv.Rows[r].Cells[4].Value = rs["pn"];
							dgv.Rows[r].Cells[5].Value = rs["wm"];
							dgv.Rows[r].Cells[6].Value = rs["cnt"];
							dgv.Rows[r].Cells[7].Value = rs["cnt"];
							if (rs["ba"] != DBNull.Value)
							{
								ntotal += Convert.ToDecimal(rs["ba"]);
							}
							if (rs["ft"] != DBNull.Value)
							{
								ntotal += Convert.ToDecimal(rs["ft"]);
							}
							if (rs["wm"] != DBNull.Value)
							{
								ntotal += Convert.ToDecimal(rs["wm"]);
							}
							if (rs["cnt"] != DBNull.Value)
							{
								ncnt += Convert.ToInt32(rs["cnt"]);
							}
						}
						dgvt.Rows.Clear();
						dgvt.Rows.Add();
						dgvt.Rows[0].Cells[0].Value = "TANGUB, MISOCC";
						dgvt.Rows[0].Cells[1].Value = "1";
						dgvt.Rows[0].Cells[2].Value = ntotal;
						dgvt.Rows[0].Cells[3].Value = ncnt;
					}
				}
				cmd1.Dispose();
			}
			
			dbcon.CloseConnection();
		}

	}
}