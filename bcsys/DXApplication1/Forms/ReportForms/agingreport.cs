using bcsys.modules;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
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
	public partial class agingreport : DevExpress.XtraEditors.XtraForm
	{
		int retries, r, i;
		string ssql, sorno, sname, bp, lznbk;

		private void btnGo_Click(object sender, EventArgs e)
		{
			i = 0;
			bp = dtpDate.Value.ToString("yyyyMM");
			for (int i = xtc1.TabPages.Count - 1; i > 0; i--)
			{
				xtc1.TabPages.RemoveAt(i);
			}
			sagingreport();
			//MessageBox.Show(dgvzn[0].Rows[0].Cells[0].Value.ToString());
			//sgetclassdata();
		}

		DataTable dtb = new DataTable();
		private DataGridView[] dgvzn;
		public agingreport()
		{
			InitializeComponent();
		}

		private void agingreport_Load(object sender, EventArgs e)
		{

		}
		private void sagingreport()
		{
			//all per zone
			//string ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-" + DateTime.DaysInMonth(dtpDate.Value.Year,dtpDate.Value.Month);
			string ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-01";
			//DateTime sdate = Convert.ToDateTime(ssdate);
			DateTime sdate = dtpDate.Value;
			DateTime edate = sdate.AddDays(-(DateTime.DaysInMonth(sdate.Year,sdate.Month) - dtpDate.Value.Day));
			ssql = "select zn,sum(billamt-payment) as ba from bcdb.reading_bc where duedate<=@ed and (payment<billamt) and billamt<>0 group by zn order by zn";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				//cmd1.Parameters.AddWithValue("@bp", bp);
				//cmd1.Parameters.AddWithValue("@sd", dtpDate.Value.ToString("yyyy-MM-dd"));
				//cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				cmd1.Parameters.AddWithValue("@ed", dtpDate.Value.ToString("yyyy-MM-dd"));
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
							dgv.Rows[r].Cells[0].Value = rs["zn"];
							dgv.Rows[r].Cells[1].Value = rs["ba"];
							
							//dgv.Rows[r].Cells[4].Value = rs["arrears"];
							//dgv.Rows[r].Cells[5].Value = rs["present"];
							//dgv.Rows[r].Cells[6].Value = rs["cumused"];
							//dgv.Rows[r].Cells[7].Value = rs["billamt"];
							//dgv.Rows[r].Cells[8].Value = rs["ftax"];
							//dgv.Rows[r].Cells[9].Value = rs["penalty"];
							//dgv.Rows[r].Cells[10].Value = rs["srdisc"];
							//dgv.Rows[r].Cells[11].Value = rs["wmf"];
						}
					}
				}
				cmd1.Dispose();


				////ssql = "select sum(arrears) as arrears,sum(cumused) as cumused," +
				////"sum(billamt) as billamt,sum(ftax) as ftax,sum(penalty) as penalty, " +
				////"sum(srdisc) as srdisc,sum(wmf) as wmf from bcdb.reading_bc " +
				////"where billperiod=@bp " +
				////"and rdgdate=@dd group by billperiod";
				////dt = new DataTable();
				////using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
				////{
				////	cmd.Parameters.AddWithValue("@bp", bp);
				////	cmd.Parameters.AddWithValue("@dd", dtpDate.Value.ToString("yyyy-MM-dd"));
				////	using (dt = new DataTable())
				////	{
				////		dt = dbcon.get_records(ssql, cmd);
				////		if (dt.Rows.Count > 0)
				////		{
				////			dgvt.Rows.Clear();
				////			foreach (DataRow rs in dt.Rows)
				////			{
				////				dgvt.Rows.Add();
				////				r = dgvt.Rows.Count - 1;
				////				dgvt.Rows[r].Cells[1].Value = "T O T A L";
				////				dgvt.Rows[r].Cells[4].Value = rs["arrears"];
				////				//dgv.Rows[r].Cells[5].Value = rs["present"];
				////				dgvt.Rows[r].Cells[6].Value = rs["cumused"];
				////				dgvt.Rows[r].Cells[7].Value = rs["billamt"];
				////				dgvt.Rows[r].Cells[8].Value = rs["ftax"];
				////				dgvt.Rows[r].Cells[9].Value = rs["penalty"];
				////				dgvt.Rows[r].Cells[10].Value = rs["srdisc"];
				////				dgvt.Rows[r].Cells[11].Value = rs["wmf"];
				////			}
				////		}
				////	}
				////	cmd1.Dispose();
				//}
			}
			//current/15 days
			ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-01";
			sdate = dtpDate.Value;
			edate = sdate.AddDays(-15);
			ssql = "select zn,sum(billamt-payment) as ba from bcdb.reading_bc where duedate>=@ed and duedate<=@sd and (payment<billamt) and billamt<>0 group by zn order by zn";
			dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				//cmd1.Parameters.AddWithValue("@bp", bp);
				cmd1.Parameters.AddWithValue("@sd", dtpDate.Value.ToString("yyyy-MM-dd"));
				//cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						foreach (DataRow rs in dt.Rows)
						{
							for (int i = 0; i < dgv.Rows.Count; i++)
							{
								if (dgv.Rows[i].Cells[0].Value.ToString() == rs["zn"].ToString())
								{
									dgv.Rows[i].Cells[2].Value = rs["ba"];
									break;
								}
							}


						}
					}
				}
				cmd1.Dispose();
			}
			//16-30 days
			ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-01";
			sdate = dtpDate.Value.AddDays(-16);
			edate = sdate.AddDays(-30);
			ssql = "select zn,sum(billamt-payment) as ba from bcdb.reading_bc where duedate>=@ed and duedate<=@sd and (payment<billamt) and billamt<>0 group by zn order by zn";
			dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				//cmd1.Parameters.AddWithValue("@bp", bp);
				cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				//cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						foreach (DataRow rs in dt.Rows)
						{
							for (int i = 0; i < dgv.Rows.Count; i++)
							{
								if (dgv.Rows[i].Cells[0].Value.ToString() == rs["zn"].ToString())
								{
									dgv.Rows[i].Cells[3].Value = rs["ba"];
									break;
								}
							}
							
							
						}
					}
				}
				cmd1.Dispose();
			}
			//31-60 days
			ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-01";
			sdate = dtpDate.Value.AddDays(-46);
			edate = sdate.AddDays(-30);
			ssql = "select zn,sum(billamt-payment) as ba from bcdb.reading_bc where duedate>=@ed and duedate<=@sd and (payment<billamt) and billamt<>0 group by zn order by zn";
			dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				//cmd1.Parameters.AddWithValue("@bp", bp);
				cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				//cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						foreach (DataRow rs in dt.Rows)
						{
							for (int i = 0; i < dgv.Rows.Count; i++)
							{
								if (dgv.Rows[i].Cells[0].Value.ToString() == rs["zn"].ToString())
								{
									dgv.Rows[i].Cells[4].Value = rs["ba"];
									break;
								}
							}


						}
					}
				}
				cmd1.Dispose();
			}
			//61-90 days
			ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-01";
			sdate = dtpDate.Value.AddDays(-76);
			edate = sdate.AddDays(-30);
			ssql = "select zn,sum(billamt-payment) as ba from bcdb.reading_bc where duedate>=@ed and duedate<=@sd and (payment<billamt) and billamt<>0 group by zn order by zn";
			dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				//cmd1.Parameters.AddWithValue("@bp", bp);
				cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				//cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						foreach (DataRow rs in dt.Rows)
						{
							for (int i = 0; i < dgv.Rows.Count; i++)
							{
								if (dgv.Rows[i].Cells[0].Value.ToString() == rs["zn"].ToString())
								{
									dgv.Rows[i].Cells[5].Value = rs["ba"];
									break;
								}
							}


						}
					}
				}
				cmd1.Dispose();
			}
			//91-120
			ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-01";
			sdate = dtpDate.Value.AddDays(-106);
			edate = sdate.AddDays(-30);
			ssql = "select zn,sum(billamt-payment) as ba from bcdb.reading_bc where duedate>=@ed and duedate<=@sd and (payment<billamt) and billamt<>0 group by zn order by zn";
			dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				//cmd1.Parameters.AddWithValue("@bp", bp);
				cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				//cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						foreach (DataRow rs in dt.Rows)
						{
							for (int i = 0; i < dgv.Rows.Count; i++)
							{
								if (dgv.Rows[i].Cells[0].Value.ToString() == rs["zn"].ToString())
								{
									dgv.Rows[i].Cells[6].Value = rs["ba"];
									break;
								}
							}


						}
					}
				}
				cmd1.Dispose();
			}
			//over
			ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-01";
			sdate = dtpDate.Value.AddDays(-136);
			edate = sdate.AddDays(-30);
			ssql = "select zn,sum(billamt-payment) as ba from bcdb.reading_bc where duedate<=@sd and (payment<billamt) and billamt<>0 group by zn order by zn";
			dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				//cmd1.Parameters.AddWithValue("@bp", bp);
				cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				//cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				//cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						foreach (DataRow rs in dt.Rows)
						{
							for (int i = 0; i < dgv.Rows.Count; i++)
							{
								if (dgv.Rows[i].Cells[0].Value.ToString() == rs["zn"].ToString())
								{
									dgv.Rows[i].Cells[7].Value = rs["ba"];
									break;
								}
							}


						}
					}
				}
				cmd1.Dispose();
			}
			dbcon.CloseConnection();
		}

		private void saddtagpages()
		{
			ssql = "select distinct zn,bk from bcdb.reading_bc where rdgdate=@dt order by zn,bk";
			DBConnect dbcon = new DBConnect();
			DataTable dt = new DataTable();
			dbcon.OpenConnection(retries);
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd1.Parameters.AddWithValue("@bp", bp);
				cmd1.Parameters.AddWithValue("@dt", dtpDate.Value.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{

						dgvzn = new DataGridView[dt.Rows.Count];
						foreach (DataRow rs in dt.Rows)
						{
							Program.zone = rs["zn"].ToString();
							Program.book = rs["bk"].ToString();
							lznbk = rs["zn"].ToString() + rs["bk"].ToString();

							AddDataGridViewToTabPage();

						}
					}
					cmd1.Dispose();
				}
			}
			dbcon.CloseConnection();
		}

		private void AddDataGridViewToTabPage()
		{

			// Create a new TabPage
			XtraTabPage newTabPage = new XtraTabPage
			{

				Text = lznbk.ToString(),

			};

			// Reference your existing DataGridView
			DataGridView znbk = this.dgv;

			// Clone the DataGridView
			DataGridView newDataGridView = CloneDataGridView(znbk);
			newTabPage.Controls.Add(newDataGridView);

			dgvzn[i] = newDataGridView;
			i += 1;
			znbk.Dock = DockStyle.Top;
			sgetdata(newDataGridView);
			DataGridView dgvtotal = this.dgvt;
			dgvtotal.ColumnHeadersVisible = false;
			dgvtotal.Dock = DockStyle.Bottom;
			DataGridView newdgvt = CloneDataGridView(dgvtotal);
			sgettotal(newdgvt);
			newTabPage.Controls.Add(newdgvt);

			// Reference your existing XtraTabControl
			XtraTabControl xtraTabControl = this.xtc1;

			// Add the TabPage to the XtraTabControl
			xtraTabControl.TabPages.Add(newTabPage);
		}
		//private void InteractWithClonedDataGridViews()
		//{
		//	if (ndgv != null)
		//	{ // Example: Add a new row to the first cloned DataGridView
		//		clonedDataGridView1.Rows.Add("New Row 1 - Col 1", "New Row 1 - Col 2");
		//	}
		//	if (clonedDataGridView2 != null)
		//	{ // Example: Add a new row to the second cloned DataGridView
		//		clonedDataGridView2.Rows.Add("New Row 2 - Col 1", "New Row 2 - Col 2");
		//	}
		//}
		private DataGridView CloneDataGridView(DataGridView original)
		{
			DataGridView copy = new DataGridView
			{
				Dock = original.Dock,
				AutoSizeColumnsMode = original.AutoSizeColumnsMode,
				ColumnHeadersHeightSizeMode = original.ColumnHeadersHeightSizeMode,
				ReadOnly = original.ReadOnly,
				AllowUserToAddRows = original.AllowUserToAddRows,
				AllowUserToDeleteRows = original.AllowUserToDeleteRows,
				AllowUserToOrderColumns = original.AllowUserToOrderColumns,
				RowHeadersWidth = original.RowHeadersWidth,
				Name = original.Name + lznbk,
				Size = original.Size,
				DefaultCellStyle = original.DefaultCellStyle,
				ColumnHeadersDefaultCellStyle = original.ColumnHeadersDefaultCellStyle,
			};

			foreach (DataGridViewColumn col in original.Columns)
			{
				copy.Columns.Add((DataGridViewColumn)col.Clone());
			}

			foreach (DataGridViewRow row in original.Rows)
			{
				if (!row.IsNewRow)
				{
					DataGridViewRow newRow = (DataGridViewRow)row.Clone();
					for (int i = 0; i < row.Cells.Count; i++)
					{
						newRow.Cells[i].Value = row.Cells[i].Value;
					}
					copy.Rows.Add(newRow);
				}
			}
			return copy;
		}
		private void sgettotal(DataGridView ndgvtot)
		{
			ssql = "select sum(arrears) as arrears,sum(cumused) as cumused," +
				"sum(billamt) as billamt,sum(ftax) as ftax,sum(penalty) as penalty, " +
				"sum(srdisc) as srdisc,sum(wmf) as wmf from bcdb.reading_bc " +
				"where billperiod=@bp " +
				"and rdgdate=@dd and zn=@zn and bk=@bk group by billperiod";
			DataTable dt = new DataTable();
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@bp", bp);
				cmd.Parameters.AddWithValue("@dd", dtpDate.Value.ToString("yyyy-MM-dd"));
				cmd.Parameters.AddWithValue("@zn", Program.zone);
				cmd.Parameters.AddWithValue("@bk", Program.book);
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd);
					if (dt.Rows.Count > 0)
					{
						ndgvtot.Rows.Clear();
						ndgvtot.ColumnHeadersVisible = false;
						foreach (DataRow rs in dt.Rows)
						{
							ndgvtot.Rows.Add();
							r = ndgvtot.Rows.Count - 1;
							ndgvtot.Rows[r].Cells[1].Value = "T O T A L";
							ndgvtot.Rows[r].Cells[4].Value = rs["arrears"];
							//dgv.Rows[r].Cells[5].Value = rs["present"];
							ndgvtot.Rows[r].Cells[6].Value = rs["cumused"];
							ndgvtot.Rows[r].Cells[7].Value = rs["billamt"];
							ndgvtot.Rows[r].Cells[8].Value = rs["ftax"];
							ndgvtot.Rows[r].Cells[9].Value = rs["penalty"];
							ndgvtot.Rows[r].Cells[10].Value = rs["srdisc"];
							ndgvtot.Rows[r].Cells[11].Value = rs["wmf"];
						}
					}
				}
				cmd.Dispose();
			}
			dbcon.CloseConnection();
		}

		private void sgetdata(DataGridView dtgridv)
		{
			ssql = "select concat(b.zn,b.bk,'-',b.classcode,b.msize,'-',left(b.acc,3)) as acctno,b.name,a.pkno,a.arrears,a.present,a.cumused," +
				"a.billamt,a.ftax,a.penalty,a.srdisc,a.wmf from bcdb.reading_bc a, bcdb.master b where a.mascode=b.mascode and a.billperiod=@bp " +
				"and a.rdgdate=@dd and a.zn=@zn and a.bk=@bk order by b.name";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			dtb = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd1.Parameters.AddWithValue("@bp", bp);
				cmd1.Parameters.AddWithValue("@dd", dtpDate.Value.ToString("yyyy-MM-dd"));
				cmd1.Parameters.AddWithValue("@zn", Program.zone);
				cmd1.Parameters.AddWithValue("@bk", Program.book);
				using (dtb = new DataTable())
				{
					dtb = dbcon.get_records(ssql, cmd1);
					if (dtb.Rows.Count > 0)
					{
						dtgridv.Rows.Clear();
						foreach (DataRow rw in dtb.Rows)
						{
							dtgridv.Rows.Add();
							r = dtgridv.Rows.Count - 1;
							dtgridv.Rows[r].Cells[0].Value = rw["acctno"].ToString();
							dtgridv.Rows[r].Cells[1].Value = rw["name"];
							//dgv.Rows[r].Cells[2].Value = rs["orno"];
							dtgridv.Rows[r].Cells[4].Value = rw["arrears"];
							dtgridv.Rows[r].Cells[5].Value = rw["present"];
							dtgridv.Rows[r].Cells[6].Value = rw["cumused"];
							dtgridv.Rows[r].Cells[7].Value = rw["billamt"];
							dtgridv.Rows[r].Cells[8].Value = rw["ftax"];
							dtgridv.Rows[r].Cells[9].Value = rw["penalty"];
							dtgridv.Rows[r].Cells[10].Value = rw["srdisc"];
							dtgridv.Rows[r].Cells[11].Value = rw["wmf"];
						}
					}

				}
			}
			dbcon.CloseConnection();
		}
	}
}