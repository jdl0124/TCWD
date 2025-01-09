using bcsys.modules;
using bcsys.Reports;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.PivotGrid.SliceQueryDataSource;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
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

namespace bcsys.Forms.ReportForms
{
    public partial class tblotter : Form
    {
        string ssql = string.Empty;
        string bp;
        int retries,r;

        public tblotter()
        {
            InitializeComponent();
        }

		private void tblotter_Load(object sender, EventArgs e)
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
			rs.Dispose();
			rs = new DataTable();
			ssql = "SELECT * FROM bcdb.denomination order by pkno";
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				//cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
				using (rs = new DataTable())
				{
					rs = newdbcon.get_records(ssql, cmd);
					if (rs.Rows.Count > 0)
					{
						dgvd.Rows.Clear();

						foreach (DataRow dr in rs.Rows)
						{
							dgvd.Rows.Add();
							r = dgvd.Rows.Count - 1;
							dgvd.Rows[r].Cells[0].Value = dr["dvalue"];

						}
					}
					cmd.Dispose();
				}
			}
			rs.Dispose();




			newdbcon.CloseConnection();
		}
		string [] sorstart = new string[3];
		string [] sorstend = new string[3];
		decimal [] ncolamt = new decimal[3];
		int norno;
		int c;
		decimal ntotal;

		private void tsbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				ntotal = Convert.ToDecimal(dgvd.CurrentRow.Cells[0].Value) *  Convert.ToDecimal(dgvd.CurrentRow.Cells[1].Value);
				dgvd.CurrentRow.Cells[2].Value = ntotal;
				ntotal = 0;
				for (int i = 0; i < dgvd.Rows.Count; i++)
				{
					ntotal += Convert.ToDecimal(dgvd.Rows[i].Cells[2].Value);
				}
				nudtotal.Value = ntotal;
				nuddiff.Value = nudtotalcash.Value - nudtotalcheck.Value - nudtotalonline.Value - nudtotal.Value ;
			}
		}

		private void tsbPrint_Click(object sender, EventArgs e)
		{
			try
			{
				ObjectPositions newpos = new ObjectPositions();
				frmDashboard fdash = new frmDashboard();
				tblotter  mainfrm = new tblotter();
				frmloading frm = new frmloading();

				string thirdParam = string.Empty;
				//string myparamtest1 = "Confidential";

				DataSet ds = new DataSet2();

				ds.Tables["blotter"].Rows.Clear();
				ds.Tables["cash"].Rows.Clear();
				ds.Tables["check"].Rows.Clear();
				ds.Tables["online"].Rows.Clear();
				ds.Tables["deno"].Rows.Clear();

				XtraReport rpt = new xrtellerblotter ();
				var labelReceiver = (XRLabel)rpt.FindControl("testlabel", false);

				Application.DoEvents();

				newpos.CenterObj(fdash, frm);
				this.Cursor = Cursors.AppStarting;

				frm.BringToFront();
				frm.Show(mainfrm);

				frm.Refresh();
				
				DataRow r1 = ds.Tables["blotter"].NewRow();
				r1["bdate"] = dtpDate.Value.ToString();
				r1["teller"] = cbteller.Text;
				r1["cashier"] = "Cecily";
				r1["total"] = nudtotalcash.Value;
				r1["blotterID"] = "1";
				ds.Tables["blotter"].Rows.Add(r1);
		
				for (int i = 0; i < dgvc.Rows.Count; i++)
				{
					DataRow r2 = ds.Tables["cash"].NewRow();
					r2["blotterID"] = "1";
					r2["sorno"] = dgvc.Rows[i].Cells[0].Value;
					r2["eorno"] = dgvc.Rows[i].Cells[1].Value;
					r2["amount"] = dgvc.Rows[i].Cells[2].Value;
					ds.Tables["cash"].Rows.Add(r2);
				}

				rpt.DataSource = ds;
				rpt.CreateDocument();
				fdash.pgpanel.SendToBack();
				fdash.pgpanel.Visible = false;
				ReportPrintTool preView = new ReportPrintTool(rpt);
				preView.PreviewRibbonForm.SaveState = false;
				preView.PreviewRibbonForm.WindowState = FormWindowState.Maximized;

				preView.ShowRibbonPreview();
				this.Cursor = Cursors.Default;
				frm.SendToBack();
				frm.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			ssql = "SELECT * FROM bcdb.pay_h where teller=@tel and tdate=@dt order by orno";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);

			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{c = 0;
				cmd.Parameters.AddWithValue("@tel", cbteller.Text);
				cmd.Parameters.AddWithValue("@dt", dtpDate.Value.ToString("yyyy-MM-dd"));
				using (rs = new DataTable())
				{
					ncolamt[c] = 0;
					sorstart[c] = "";
					sorstend[c] = "";
					norno = 0;

					rs = newdbcon.get_records(ssql, cmd);
					
					if (rs.Rows.Count > 0)
					{
						DataRow dataRow = rs.Rows[0];
						norno = Convert.ToInt32(dataRow["orno"]);
						sorstart[c] = dataRow["orno"].ToString();
						foreach (DataRow dr in rs.Rows)
						{
							if (norno == Convert.ToInt32(dr["orno"]))
							{
								ncolamt[c] += Convert.ToDecimal(dr["amtdue"]);
								norno++;
								sorstend[c] = dr["orno"].ToString();
							}
							else 
							{ 
								c++;
								sorstend[c] = dr["orno"].ToString();
								ncolamt[c] += Convert.ToDecimal(dr["amtdue"]);
							}
						}
						ntotal = 0;
						dgvc.Rows.Clear();
						for (int i = 0; i < ncolamt.Length; i++) 
						{
							dgvc.Rows.Add();
							r = dgvc.Rows.Count - 1;
							dgvc.Rows[r].Cells[0].Value = sorstart[i];
							dgvc.Rows[r].Cells[1].Value = sorstend[i];
							dgvc.Rows[r].Cells[2].Value = ncolamt[i];
							ntotal += ncolamt[i];
						}
						nudtotalcash.Value = ntotal;
						nudtotalcollection.Value = ntotal;
					}
					cmd.Dispose();
				}
			}
			//check payment
			rs = new DataTable();
			ssql = "select * from bcdb.paychk_d a,bcdb.banks b where a.bankcode=b.code and a.teller=@tel and a.tdate=@tdt and a.ptype='2' order by b.bankname";

			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@tel", cbteller.Text);
				cmd.Parameters.AddWithValue("@tdt", dtpDate.Value.ToString("yyyy-MM-dd"));
				using (rs = new DataTable())
				{
				
					rs = newdbcon.get_records(ssql, cmd);

					if (rs.Rows.Count > 0)
					{
						dgvoc.Rows.Clear();
						foreach (DataRow dr in rs.Rows)
						{
							dgvoc.Rows.Add();
							r = dgvoc.Rows.Count - 1;
							dgvoc.Rows[r].Cells[0].Value = dr["shortname"].ToString();
							dgvoc.Rows[r].Cells[1].Value = dr["checkdate"].ToString();
							dgvoc.Rows[r].Cells[2].Value = dr["checkno"].ToString();
							dgvoc.Rows[r].Cells[3].Value = dr["amount"].ToString();
						}
						ntotal = 0;
						
						for (int i = 0; i < dgvoc.Rows.Count; i++)
						{
							ntotal += Convert.ToDecimal(dgvoc.Rows[i].Cells[3].Value);
						}
						nudtotalcheck.Value = ntotal;
					}
					cmd.Dispose();
				}
			}
			rs = new DataTable();
			ssql = "select * from bcdb.paychk_d a,bcdb.banks b where a.bankcode=b.code and a.teller=@tel and a.tdate=@tdt and a.ptype='3' order by b.bankname";

			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@tel", cbteller.Text);
				cmd.Parameters.AddWithValue("@tdt", dtpDate.Value.ToString("yyyy-MM-dd"));
				using (rs = new DataTable())
				{

					rs = newdbcon.get_records(ssql, cmd);

					if (rs.Rows.Count > 0)
					{
						dgvod.Rows.Clear();
						foreach (DataRow dr in rs.Rows)
						{
							dgvod.Rows.Add();
							r = dgvoc.Rows.Count - 1;
							dgvod.Rows[r].Cells[0].Value = dr["shortname"].ToString();
							dgvod.Rows[r].Cells[1].Value = dr["checkdate"].ToString();
							dgvod.Rows[r].Cells[2].Value = dr["checkno"].ToString();
							dgvod.Rows[r].Cells[3].Value = dr["amount"].ToString();
						}
						ntotal = 0;

						for (int i = 0; i < dgvod.Rows.Count; i++)
						{
							ntotal += Convert.ToDecimal(dgvod.Rows[i].Cells[3].Value);
						}
						nudtotalonline.Value = ntotal;
					}
					cmd.Dispose();
				}
			}
			newdbcon.CloseConnection();
		}
	}
}
