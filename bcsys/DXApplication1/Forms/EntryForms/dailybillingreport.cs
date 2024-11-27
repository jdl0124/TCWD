using bcsys.modules;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using PriorityTextToSpeech.modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;
using System.Drawing.Text;

namespace bcsys.Forms.EntryForms
{
	public partial class dailybillingreport : DevExpress.XtraEditors.XtraForm
	{
		int retries, r, i;
		string ssql, sorno, sname, bp, lznbk;
		DataTable dtb = new DataTable();
		private DataGridView[] dgvzn;

		private void gcdly_Paint(object sender, PaintEventArgs e)
		{

		}

		public dailybillingreport()
		{
			InitializeComponent();
		}

		private void billingreport_Load(object sender, EventArgs e)
		{


		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			i = 0;
			bp = dtpDate.Value.ToString("yyyyMM");
			for (int i = xtc1.TabPages.Count - 1; i > 0; i--)
			{
				xtc1.TabPages.RemoveAt(i);
			}
			sbillingreport();
			//MessageBox.Show(dgvzn[0].Rows[0].Cells[0].Value.ToString());
			sgetclassdata();

			
		}
		private void sgetclassdata()
		{
			ssql = "select b.zn,b.bk,a.desc0,a.desc1,sum(b.cumused) as cu,sum(b.billamt) as ba,sum(b.ftax) as ft,sum(b.wmf) as wm, " +
				"sum(b.srdisc) as sr, count(a.`code`) as cnt " +
				" from bcdb.rates a,bcdb.reading_bc b,bcdb.`master` c where b.rdgdate=@dd and " +
				"b.mascode=c.MASCODE and a.`code`= c.CLASSCODE and a.msize=c.MSIZE GROUP BY c.zn,c.bk,a.code,a.msize ORDER BY c.zn,c.bk";
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
						int ncu, nba, ncnt;
						decimal ntotbill = 0;
						decimal nbill, nft, npn, nwm, nsr;
						nbill = 0;nft = 0;npn = 0;nwm = 0;nsr = 0;
						ncu = 0;nba = 0;ncnt = 0;
						dgvc.Rows.Clear();
						dgvctotal.Rows.Clear();
						foreach (DataRow rs in dt.Rows)
						{
							dgvc.Rows.Add();
							r = dgvc.Rows.Count - 1;
							dgvc.Rows[r].Cells[0].Value = rs["zn"];
							dgvc.Rows[r].Cells[1].Value = rs["bk"];
							dgvc.Rows[r].Cells[2].Value = rs["desc0"];
							dgvc.Rows[r].Cells[3].Value = rs["desc1"];
							dgvc.Rows[r].Cells[4].Value = rs["cu"];
							if (rs["ba"] != DBNull.Value)
							{
								nbill = Convert.ToDecimal(rs["ba"]);
							}
							if (rs["ft"] != DBNull.Value)
							{
								nft = Convert.ToDecimal(rs["ft"]);
							}
							if (rs["wm"] != DBNull.Value)
							{
								nwm = Convert.ToDecimal(rs["wm"]);
							}
							if (rs["sr"] != DBNull.Value)
							{
								nsr = Convert.ToDecimal(rs["sr"]);
							}
							ntotbill = nbill + nft - nsr;
							dgvc.Rows[r].Cells[5].Value = ntotbill;
							dgvc.Rows[r].Cells[6].Value = rs["cnt"];
							ncu +=  Convert.ToInt32(dgvc.Rows[r].Cells[4].Value);
							nba += Convert.ToInt32(dgvc.Rows[r].Cells[5].Value);
							ncnt += Convert.ToInt32(dgvc.Rows[r].Cells[6].Value);
						}
						dgvctotal.Rows.Clear();
						dgvctotal.Rows.Add();
						dgvctotal.Rows[0].Cells[2].Value = "Total";
						dgvctotal.Rows[0].Cells[4].Value = ncu;
						dgvctotal.Rows[0].Cells[5].Value = nba;
						dgvctotal.Rows[0].Cells[6].Value = ncnt;
					}
				}
				cmd1.Dispose();
			}
			dbcon.CloseConnection();

		}

		private void tsbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void sbillingreport()
		{
			saddtagpages();
			ssql = "select concat(b.zn,b.bk,'-',b.classcode,b.msize,'-',left(b.acc,3)) as acctno,b.name,a.pkno,a.arrears,a.present,a.cumused," +
				"a.billamt,a.ftax,a.penalty,a.srdisc,a.wmf from bcdb.reading_bc a, bcdb.master b where a.mascode=b.mascode and a.billperiod=@bp " +
				"and a.rdgdate=@dd order by b.name";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd1.Parameters.AddWithValue("@bp", bp);
				cmd1.Parameters.AddWithValue("@dd", dtpDate.Value.ToString("yyyy-MM-dd"));
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
							//dgv.Rows[r].Cells[2].Value = rs["orno"];
							dgv.Rows[r].Cells[4].Value = rs["arrears"];
							dgv.Rows[r].Cells[5].Value = rs["present"];
							dgv.Rows[r].Cells[6].Value = rs["cumused"];
							dgv.Rows[r].Cells[7].Value = rs["billamt"];
							dgv.Rows[r].Cells[8].Value = rs["ftax"];
							dgv.Rows[r].Cells[9].Value = rs["penalty"];
							dgv.Rows[r].Cells[10].Value = rs["srdisc"];
							dgv.Rows[r].Cells[11].Value = rs["wmf"];
						}
					}
				}
				cmd1.Dispose();

				ssql = "select sum(arrears) as arrears,sum(cumused) as cumused," +
				"sum(billamt) as billamt,sum(ftax) as ftax,sum(penalty) as penalty, " +
				"sum(srdisc) as srdisc,sum(wmf) as wmf from bcdb.reading_bc " +
				"where billperiod=@bp " +
				"and rdgdate=@dd group by billperiod";
				dt = new DataTable();
				using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
				{
					cmd.Parameters.AddWithValue("@bp", bp);
					cmd.Parameters.AddWithValue("@dd", dtpDate.Value.ToString("yyyy-MM-dd"));
					using (dt = new DataTable())
					{
						dt = dbcon.get_records(ssql, cmd);
						if (dt.Rows.Count > 0)
						{
							dgvt.Rows.Clear();
							foreach (DataRow rs in dt.Rows)
							{
								dgvt.Rows.Add();
								r = dgvt.Rows.Count - 1;
								dgvt.Rows[r].Cells[1].Value = "T O T A L";
								dgvt.Rows[r].Cells[4].Value = rs["arrears"];
								//dgv.Rows[r].Cells[5].Value = rs["present"];
								dgvt.Rows[r].Cells[6].Value = rs["cumused"];
								dgvt.Rows[r].Cells[7].Value = rs["billamt"];
								dgvt.Rows[r].Cells[8].Value = rs["ftax"];
								dgvt.Rows[r].Cells[9].Value = rs["penalty"];
								dgvt.Rows[r].Cells[10].Value = rs["srdisc"];
								dgvt.Rows[r].Cells[11].Value = rs["wmf"];
							}
						}
					}
					cmd1.Dispose();
				}
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