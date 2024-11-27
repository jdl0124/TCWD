using bcsys.modules;
using DevExpress.DataProcessing.InMemoryDataProcessor.GraphGenerator;
using DevExpress.Drawing.Internal.Fonts.Interop;
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
	public partial class collectionreport : DevExpress.XtraEditors.XtraForm
	{
		int retries, r;
		string ssql, sorno, sname, bp;
		public collectionreport()
		{
			InitializeComponent();
		}

		private void collectionreport_Load(object sender, EventArgs e)
		{
			bp = dtpDate.Value.ToString("yyyyMM");
		}

		private void tsbClose_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (this.Text == "Daily Collection Report")
			{
				sdailycollectionreport();
				sdcreportmiscellaneous();


			}
			else
			{

			}
		}

		private void sdcreportmiscellaneous()
		{
			ssql = "select a.*,b.name from pay_h a,pay_d b where teller=@tel and pdate=@dt and ttype<>'0' order by " + sorno;
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd1.Parameters.AddWithValue("@tel", cbteller.Text);
				cmd1.Parameters.AddWithValue("@dt", dtpDate.Value);
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						dgv.Rows.Clear();
						foreach (DataRow rs in dt.Rows)
						{
							dgv.Rows.Add();
							r = dgv.Rows.Count - 1;
							dgv.Rows[r].Cells[0].Value = rs["acctno"];
							dgv.Rows[r].Cells[1].Value = rs["name"];
							dgv.Rows[r].Cells[2].Value = rs["orno"];
							dgv.Rows[r].Cells[3].Value = rs["paidamount"];
							if (rs["ttype"].ToString() == "60")
							{
								dgv.Rows[r].Cells[4].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "61")
							{
								dgv.Rows[r].Cells[5].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "62")
							{
								dgv.Rows[r].Cells[6].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "63")
							{
								dgv.Rows[r].Cells[7].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "64")
							{
								dgv.Rows[r].Cells[8].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "65")
							{
								dgv.Rows[r].Cells[9].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "66")
							{
								dgv.Rows[r].Cells[10].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "67")
							{
								dgv.Rows[r].Cells[11].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "68")
							{
								dgv.Rows[r].Cells[12].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "69")
							{
								dgv.Rows[r].Cells[13].Value = rs["paidamount"];
							}
						}
					}
				}
				cmd1.Dispose();
			}
			dbcon.CloseConnection();
		}
		private void sdailycollectionreport()
		{
			ssql = "select a.*,b.name from pay_h a,pay_d b where teller=@tel and pdate=@dt order by " + sorno;
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd1.Parameters.AddWithValue("@tel", cbteller.Text);
				cmd1.Parameters.AddWithValue("@dt", dtpDate.Value);
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						dgv.Rows.Clear();
						foreach (DataRow rs in dt.Rows)
						{
							dgv.Rows.Add();
							r = dgv.Rows.Count - 1;
							dgv.Rows[r].Cells[0].Value = rs["acctno"];
							dgv.Rows[r].Cells[1].Value = rs["name"];
							dgv.Rows[r].Cells[2].Value = rs["orno"];
							dgv.Rows[r].Cells[3].Value = rs["paidamount"];
							if (bp == rs["billperiod"].ToString())
							{
								dgv.Rows[r].Cells[4].Value = rs["billamt"];
							}
							else if (Convert.ToInt16(rs["billperiod"].ToString().Substring(0, 4)) < Convert.ToInt16(bp.ToString().Substring(0, 4)))
							{
								dgv.Rows[r].Cells[6].Value = rs["billamt"];
							}
							else if (Convert.ToInt16(rs["billperiod"]) < Convert.ToInt16(bp))
							{
								dgv.Rows[r].Cells[5].Value = rs["billamt"];
							}
							dgv.Rows[r].Cells[6].Value = rs["penalty"];
							dgv.Rows[r].Cells[7].Value = rs["ftax"];
							dgv.Rows[r].Cells[8].Value = rs["wmf"];
							dgv.Rows[r].Cells[9].Value = rs["discount"];
							dgv.Rows[r].Cells[10].Value = rs["wtax"];
							dgv.Rows[r].Cells[11].Value = rs["advance"];
							dgv.Rows[r].Cells[12].Value = rs["others"];
							dgv.Rows[r].Cells[13].Value = rs["stubno"];

						}
					}
				}
				cmd1.Dispose();
			}
			dbcon.CloseConnection();

		}
	}
}