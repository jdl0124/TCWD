using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using bcsys.modules;
using bcsys.Reports;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.CodeParser;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using bcsys.Properties;
using DevExpress.XtraRichEdit.Import.Doc;
using DevExpress.Utils.About;
using Mirabeau.Sql;
using DevExpress.DashboardCommon.Viewer;
using DevExpress.ExpressApp;
using DevExpress.XtraExport.Helpers;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts;
using DevExpress.DataAccess.Native.Sql.ConnectionProviders;
using DevExpress.Utils.Serializing;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Globalization;
using CrystalDecisions.CrystalReports.Engine;
using DevExpress.DashboardCommon.DataProcessing;
using DevExpress.Printing.Core.PdfExport.Metafile;
using DevExpress.Persistent.Base.General;
using DevExpress.DataAccess.Native.EntityFramework;
using DevExpress.Utils.Extensions;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.Web.Internal.XmlProcessor;
//using DevExpress.DataAccess.Native.Data;
using System.Web.UI.WebControls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using bcsys.Forms.ReportForms;
using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraEditors.TextEditController.Win32;
using static DevExpress.CodeParser.CodeStyle.Formatting.Rules;

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

		private void btnGo_Click(object sender, EventArgs e)
		{

            nudAdd.Value = 0;
            nudLess.Value = 0;
            nudAmount.Value = 0;
            nudTotal.Value = 0;
            nudDeposits.Value = 0;

			if (this.Text == "Daily Collection Report")
			{
				stellerblotter();
				sdailycollectionreport();
				sdcreportmiscellaneous();


			}
			else
			{

			}
		}

        decimal[]msc = new decimal[10];
       
        private void sprn_collection()
        {
            try
            {
                for (int i = 0; i < msc.Length; i++)
                {
                    msc[i] = 0;
                }

                ObjectPositions newpos = new ObjectPositions();
                frmDashboard fdash = new frmDashboard();
                agingreport mainfrm = new agingreport();
                frmloading frm = new frmloading();

                string thirdParam = string.Empty;
                //string myparamtest1 = "Confidential";

                DataSet ds = new DataSet2();

                //ds.Tables.Clear();
                ds.Tables["billhead"].Rows.Clear();
                ds.Tables["billdtl"].Rows.Clear();
                XtraReport rpt = new xrdlycollectionreport();
                var labelReceiver = (XRLabel)rpt.FindControl("testlabel", false);

                Application.DoEvents();

                newpos.CenterObj(fdash, frm);
                this.Cursor = Cursors.AppStarting;

                frm.BringToFront();
                frm.Show(mainfrm);

                frm.Refresh();
                Random rnd = new Random();
                Random rnd2 = new Random();
                DataRow r1 = ds.Tables["billhead"].NewRow();
                r1["acctname"] = "Tangub City Water District";
                r1["address"] = "Aging Report";
                r1["acctno"] = "1";
                r1["billdate"] = dtpDate.Value;
                r1["sig1"] = Program.sig1;
                r1["sig2"] = Program.sig2;
                r1["sig3"] = Program.sig3;
                r1["sig4"] = Program.sig4;
				r1["penalty"] = "Penalty";
				r1["wmf"] = "WMF";
				r1["srdisc"] = "Senior Discount";
				r1["penamt"] = dgvt.Rows[0].Cells[8].Value;
				r1["wmfamt"] = dgvt.Rows[0].Cells[9].Value;
				r1["srdisamt"] = dgvt.Rows[0].Cells[10].Value;

				r1["m1"] = "618-1:" + " Inspection Fee";
                r1["m2"] = "618-1:" + " Reconnection Fee";
                r1["m3"] = "618-1:" + " Demand Fee";
                r1["m4"] = "618-1:" + " Senior Citizen";
                r1["m5"] = "618-1:" + " Transfer Fee";
                r1["m6"] = "618-1:" + " Change Name";
                r1["m7"] = "618-1:" + " Application Fee";
                r1["m8"] = "134:" + " Advances to Off. & Emp.";
                r1["m9"] = "618-4:" + " Materials";
                r1["m10"] = "618:" + " Others";

				//get details of payment
				DBConnect newdbcon = new DBConnect();
				newdbcon.OpenConnection(retries);

				rs = new DataTable();
				ssql = "select ttype,sum(paidamount) as pa from bcdb.pay_d where left(pdate,10)=@dt and ttype<>'1' and teller=@tel GROUP BY ttype";
				
				using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
				{
					cmd2.Parameters.AddWithValue("@dt", dtpDate.Value.ToString("yyyy-MM-dd"));
					cmd2.Parameters.AddWithValue("@tel", cbteller.Text);
					cmd2.Prepare();
                    cmd2.ExecuteNonQuery();


					rs = newdbcon.get_records(ssql, cmd2);

					if (rs.Rows.Count > 0)
					{
                        foreach (DataRow dr in rs.Rows)
                        {
                            if (dr["ttype"].ToString() == "60")
                            {
                                r1["ma1"] = dr["pa"];
                                msc[0] = Convert.ToDecimal(dr["pa"]);
                            }
                            else if (dr["ttype"].ToString() == "61")
                            {
								r1["ma2"] = dr["pa"];
								msc[1] = Convert.ToDecimal(dr["pa"]);
							}
							else if (dr["ttype"].ToString() == "62")
							{
								r1["ma3"] = dr["pa"];
								msc[2] = Convert.ToDecimal(dr["pa"]);
							}
							else if (dr["ttype"].ToString() == "63")
							{
								r1["ma4"] = dr["pa"];
								msc[3] = Convert.ToDecimal(dr["pa"]);
							}
							else if (dr["ttype"].ToString() == "64")
							{
								r1["ma5"] = dr["pa"];
								msc[4] = Convert.ToDecimal(dr["pa"]);
							}
							else if (dr["ttype"].ToString() == "65")
							{
								r1["ma6"] = dr["pa"];
								msc[5] = Convert.ToDecimal(dr["pa"]);
							}
							else if (dr["ttype"].ToString() == "66")
							{
								r1["ma7"] = dr["pa"];
								msc[6] = Convert.ToDecimal(dr["pa"]);
							}
							else if (dr["ttype"].ToString() == "67")
							{
								r1["ma8"] = dr["pa"];
								msc[7] = Convert.ToDecimal(dr["pa"]);
							}
							else if (dr["ttype"].ToString() == "68")
							{
								r1["ma9"] = dr["pa"];
								msc[8] = Convert.ToDecimal(dr["pa"]);
							}
							else if (dr["ttype"].ToString() == "69")
							{
								r1["ma10"] = dr["pa"];
								msc[9] = Convert.ToDecimal(dr["pa"]);
							}

						}

					}
                    namt = 0;
                    for (int i = 0; i < msc.Length; i++)
                    {
                        namt += msc[i];
                    }
                    r1["arbalance"] = Convert.ToDecimal(dgvt.Rows[0].Cells[4].Value) + Convert.ToDecimal(dgvt.Rows[0].Cells[5].Value)
                    + Convert.ToDecimal(dgvt.Rows[0].Cells[6].Value);
					r1["aramount"] = Convert.ToDecimal(dgvt.Rows[0].Cells[4].Value) + Convert.ToDecimal(dgvt.Rows[0].Cells[5].Value)
					+ Convert.ToDecimal(dgvt.Rows[0].Cells[6].Value) + Convert.ToDecimal(dgvt.Rows[0].Cells[8].Value) + Convert.ToDecimal(dgvt.Rows[0].Cells[9].Value) + namt - Convert.ToDecimal(dgvt.Rows[0].Cells[10].Value);

					cmd2.Dispose();
				}
                rs.Dispose();


                //newdbcon = new DBConnect();
                newdbcon.CloseConnection();
				ds.Tables["billhead"].Rows.Add(r1);
				if (xtc1.SelectedTabPageIndex == 0)
                {

                    for (int i = 0; i <= dgv.RowCount - 1; i++)
                    {
                        DataRow r2 = ds.Tables["billdtl"].NewRow();
                        r2["acctno"] = "1";
                        r2["nno"] = i + 1;
                        r2["refno"] = dgv.Rows[i].Cells[0].Value;
                        if (dgv.Rows[i].Cells[1].Value.ToString().Length > 30)
                        {
                            r2["acctname"] = dgv.Rows[i].Cells[1].Value.ToString().Substring(0, 30);
                        }
                        else
                        {
                            r2["acctname"] = dgv.Rows[i].Cells[1].Value.ToString();
                        }
                        
                        r2["orno"] = dgv.Rows[i].Cells[2].Value;
                        //r2["amount"] = dgv.Rows[i].Cells[2].Value;
                        if (dgv.Rows[i].Cells[3].Value != null)
                        {
                            r2["amount"] = dgv.Rows[i].Cells[3].Value;
                        }
                        else
                        {
                            r2["amount"] = null;
                        }

                        if (dgv.Rows[i].Cells[4].Value != null)
                        {
                            r2["amt1"] = dgv.Rows[i].Cells[4].Value;
                        }
                        else
                        {
                            r2["amt1"] = 0;
                        }
                        if (dgv.Rows[i].Cells[5].Value != null)
                        {
                            r2["amt2"] = dgv.Rows[i].Cells[5].Value;
                        }
                        else
                        {
                            r2["amt2"] = 0;
                        }
                        if (dgv.Rows[i].Cells[6].Value != null)
                        {
                            r2["amt3"] = dgv.Rows[i].Cells[6].Value;
                        }
                        else
                        {
                            r2["amt3"] = 0;
                        }

                        if (dgv.Rows[i].Cells[8].Value != null)
                        {
                            r2["amt4"] = dgv.Rows[i].Cells[8].Value;
                        }
                        else
                        {
                            r2["amt4"] = 0;
                        }
                        if (dgv.Rows[i].Cells[9].Value != null)
                        {
                            r2["amt5"] = dgv.Rows[i].Cells[9].Value;
                        }
                        else
                        {
                            r2["amt5"] = 0;
                        }
                        if (dgv.Rows[i].Cells[10].Value != null)
                        {
                            r2["amt6"] = dgv.Rows[i].Cells[10].Value;
                        }
                        else
                        {
                            r2["amt6"] = 0;
                        }

                        ds.Tables["billdtl"].Rows.Add(r2);
                    }
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
        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (xtc1.SelectedTabPageIndex == 1)
            {
                sprn_tblotter();
            }
            else if (xtc1.SelectedTabPageIndex == 0) 
            {
                sprn_collection();
                
            }

            
        }

        private void sprn_tblotter()
        {
            try
            {
                ObjectPositions newpos = new ObjectPositions();
                frmDashboard fdash = new frmDashboard();
                collectionreport mainfrm = new collectionreport();
                frmloading frm = new frmloading();

                string thirdParam = string.Empty;
                //string myparamtest1 = "Confidential";

                DataSet ds = new DataSet2();

                //ds.Tables.Clear();
                ds.Tables["billhead"].Rows.Clear();
                ds.Tables["billdtl"].Rows.Clear();
                ds.Tables["deposit"].Rows.Clear();

                //XtraReport rpt = new xrtblotters1 ();
                XtraReport rpt = new xrtblotter();
                var labelReceiver = (XRLabel)rpt.FindControl("testlabel", false);

                Application.DoEvents();

                newpos.CenterObj(fdash, frm);
                this.Cursor = Cursors.AppStarting;

                frm.BringToFront();
                frm.Show(mainfrm);

                frm.Refresh();
                Random rnd = new Random();
                Random rnd2 = new Random();
                DataRow r1 = ds.Tables["billhead"].NewRow();
                r1["acctname"] = "Tangub City Water District";
                r1["address"] = "Aging Report";
                r1["acctno"] = 1;
                r1["billdate"] = dtpDate.Value;
                r1["sig1"] = Program.sig1;
                r1["sig2"] = Program.sig2;
                r1["sig3"] = Program.sig3;

                ds.Tables["billhead"].Rows.Add(r1);
                
                    for (int i = 0; i <= dgvb.RowCount - 1; i++)
                    {
                        
                    }
                DataRow r2 = ds.Tables["billdtl"].NewRow();
                r2["acctno"] = 1;
                r2["nno"] = 1;
                r2["part1"] = dgvb.Rows[0].Cells[0].Value;
                if (dgvb.Rows.Count >=2)
                {
                    r2["part2"] = dgvb.Rows[1].Cells[0].Value;
                }
                if (dgvb.Rows.Count >=3)
                {
                    r2["part3"] = dgvb.Rows[2].Cells[0].Value;
                }
                
                r2["total"] = nudTotal.Value;
                r2["arbalance"] = nudDeposits.Value;
                //r2["amt1"] = dgv.Rows[i].Cells[1].Value;

                if (dgvb.Rows[0].Cells[0].Value != null)
                {
                    r2["amt1"] = dgvb.Rows[0].Cells[1].Value;
                }
                else
                {
                    r2["amt1"] = 0;
                }
                if (dgvb.Rows.Count >= 2)
                {
                    if (dgvb.Rows[1].Cells[0].Value != null)
                    {
                        r2["amt2"] = dgvb.Rows[1].Cells[1].Value;
                    }
                    else
                    {
                        r2["amt2"] = 0;
                    }

                    if (dgvb.Rows[2].Cells[0].Value != null)
                    {
                        r2["amt3"] = dgvb.Rows[2].Cells[1].Value;
                    }
                    else
                    {
                        r2["amt3"] = 0;
                    }
                }

                

                ds.Tables["billdtl"].Rows.Add(r2);

                for (int i = 0; i <= dgvDeposit.RowCount - 1; i++)
                {
                    DataRow r3 = ds.Tables["deposit"].NewRow();
                    r3["acctno"] = 1;
                    
                    r3["part"] = dgvDeposit .Rows[i].Cells[0].Value;
                    //r2["amt1"] = dgv.Rows[i].Cells[1].Value;

                    if (dgvDeposit .Rows[i].Cells[2].Value != null)
                    {
                        r3["ncr"] = dgvDeposit .Rows[i].Cells[2].Value;
                    }
                    else
                    {
                        r3["ncr"] = 0;
                    }
                    if (dgvDeposit.Rows[i].Cells[1].Value != null)
                    {
                        r3["ndr"] = dgvDeposit.Rows[i].Cells[1].Value;
                    }
                    else
                    {
                        r3["ndr"] = 0;
                    }

                    ds.Tables["deposit"].Rows.Add(r3);
                }
                
               // XRSubreport subReport = (XRSubreport)rpt.FindControl("xrblotter1", true);
               //((xrtblotters1)subReport.ReportSource).DataSource = ds;

               // XRSubreport subReport2 = (XRSubreport)rpt.FindControl("xrblotter2", true);
               // ((xrtblotters2)subReport2.ReportSource).DataSource = ds;

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



        string optor;
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            tsbSave.Enabled = true;
            tsbDelete.Enabled = true;
            optor = "+";
            saddtogrid(ref optor);
        }
        private void saddtogrid(ref string optr)
        {
            dgvDeposit.Rows.Add();
            r = dgvDeposit.RowCount - 1;
            if (optor.ToString() == "-")
            {
                dgvDeposit.Rows[r].Cells[0].Value = tbRemarks.Text.Trim().PadLeft(10);
            }
            else
            {
                dgvDeposit.Rows[r].Cells[0].Value = tbRemarks.Text;
            }

            if (optr == "+")
            {
                dgvDeposit.Rows[r].Cells[2].Value = nudAmount.Value.ToString("###,###,##0.00");
            }
            else
            {
                dgvDeposit.Rows[r].Cells[1].Value = nudAmount.Value.ToString("###,###,##0.00");
            }
            nudAmount.Value = 0;
            ncr = 0;ndr = 0;
            for (int i = 1; i < dgvDeposit.Rows.Count; i++)
            {
                ncr += Convert.ToDecimal ( dgvDeposit.Rows[i].Cells[2].Value);
                ndr += Convert.ToDecimal(dgvDeposit.Rows[i].Cells[1].Value);

            }
            nudAdd.Value = ncr;
            nudLess.Value = ndr;
            nudDeposits.Value = nTBalance + nudTotal.Value + nudAdd.Value - nudLess.Value;
        }

        private void tsbLess_Click(object sender, EventArgs e)
        {

            tsbSave.Enabled = true;
            tsbDelete.Enabled = true;
            optor = "-";
            saddtogrid(ref optor);
        }

        DataTable rs;
        string sguid;
        decimal namt;
        private void tsbSave_Click(object sender, EventArgs e)
        {
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            DataTable rs = new DataTable();
            for (int i = 0; i <= dgvDeposit.Rows.Count - 1; i++)
            {
                //get guid
                
                rs = new DataTable();
                if (dgvDeposit.Rows[i].Cells[3].Value == null)
                {
                    sguid = "";
                    bool naa = true;
                    while (naa == true)
                    {
                        sguid = System.Guid.NewGuid().ToString();
                        sguid = sguid.Substring(0, 10);
                        rs = new DataTable();
                        ssql = "Select * from bcdb.tblotter where pkno=@pk";
                        using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
                        {
                            cmd.Parameters.AddWithValue("@pk", sguid);
                            cmd.Prepare();
                            rs = newdbcon.get_records(ssql, cmd);
                            if (rs.Rows.Count == 0)
                            {
                                naa = false;
                                //break;

                            }

                        }
                        rs.Dispose();
                    }
                }
                else
                {
                    sguid = dgvDeposit.Rows[i].Cells[3].Value.ToString();
                }

                //save
                rs = new DataTable();
                ssql = "Select * from bcdb.tblotter where pkno=@pk";
                using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
                {
                    cmd.Parameters.AddWithValue("@pk", sguid);
                    cmd.Prepare();
                    rs = newdbcon.get_records (ssql, cmd);
                    if (rs.Rows.Count <= 0)
                    {
                        //insert to bremarks
                        ssql = "INSERT INTO bcdb.tblotter(teller,bdate,brem,bamt,pkno,seqno) VALUES(@tel,@dte,@br,@ba,@pk,@sq)";
                        using (MySqlCommand cmd3 = new MySqlCommand(ssql, newdbcon.database_connection  ))
                        {
                            if (Convert.ToDecimal(dgvDeposit.Rows[i].Cells[1].Value) > 0)
                            {
                                namt = -Convert.ToDecimal(dgvDeposit.Rows[i].Cells[1].Value);
                            }
                            else
                            {
                                namt = Convert.ToDecimal(dgvDeposit.Rows[i].Cells[2].Value);
                            }
                            cmd3.Parameters.AddWithValue("@tel", Program.usr);
                            cmd3.Parameters.AddWithValue("@dte", dtpDate.Value.ToString("yyyy-MM-dd"));
                            cmd3.Parameters.AddWithValue("@br", dgvDeposit.Rows[i].Cells[0].Value);
                            cmd3.Parameters.AddWithValue("@ba", namt);
                            cmd3.Parameters.AddWithValue("@pk", sguid);
                            cmd3.Parameters.AddWithValue("@sq", i);
                            cmd3.Prepare();
                            cmd3.ExecuteNonQuery();

                        }
                    }
                    else
                    {
                        ssql = "update bcdb.tblotter set seqno=@sq where pkno=@pk";
                        using (MySqlCommand cmd4 = new MySqlCommand(ssql, newdbcon.database_connection  ))
                        {
                            cmd4.Parameters.AddWithValue("@pk", sguid);
                            cmd4.Parameters.AddWithValue("@sq", i);
                            cmd4.Prepare();
                            cmd4.ExecuteNonQuery();
                        }
                    }
                }
            }

            supdatedeposit();
            DateTime tdate;
            if (dtpDate.Value.DayOfWeek.ToString() == DayOfWeek.Saturday.ToString())
            {
                tdate = dtpDate.Value.AddDays(2);
            }
            else
            {
                tdate = dtpDate.Value.AddDays(1);
            }
            ssql = "update bcdb.tblotter set bamt=@dep where teller=@tel and seqno=0 and bdate=@dte";
            using (MySqlCommand cmd3 = new MySqlCommand(ssql, newdbcon.database_connection ))
            {
                cmd3.Parameters.AddWithValue("@tel", Program.usr );
                cmd3.Parameters.AddWithValue("@dep", nudDeposits.Value);
                cmd3.Parameters.AddWithValue("@dte", tdate);
                cmd3.Prepare();
                cmd3.ExecuteNonQuery();
            }

            sgetdeposit();
        }

        private void spaydetails()
        {
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            rs = new DataTable();
            ssql = "select ttype,sum(paidamount) as pa from bcdb.pay_d where left(pdate,10)=@dt GROUP BY ttype";
            dgvDeposit.Rows.Clear();
            using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
            {
                
                
                cmd2.Parameters.AddWithValue("dte", dtpDate.Value.ToString("yyyy-MM-dd"));
                cmd2.Prepare();

                rs = newdbcon.get_records(ssql, cmd2);
                
                if (rs.Rows.Count > 0)
                {

                }
            }
            newdbcon = new DBConnect();

        }
        private void sgetdeposit()
        {
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            rs = new DataTable();
            ssql = "select * from bcdb.tblotter where teller=@tel and bdate=@dte order by seqno";
            dgvDeposit.Rows.Clear();
            using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection ))
            {
                nudLess.Value = 0;
                cmd2.Parameters.AddWithValue("@tel", Program.usr );
                cmd2.Parameters.AddWithValue("dte", dtpDate.Value.ToString("yyyy-MM-dd"));
                cmd2.Prepare();
                
                rs = newdbcon.get_records(ssql, cmd2);
                dgvDeposit.Rows.Clear();
                if (rs.Rows.Count > 0)
                {
                    //dgvDeposit.DataSource = rs;
                    ndr = 0; ncr = 0;
                    foreach (DataRow rw in rs.Rows)
                    {
                        dgvDeposit.Rows.Add();
                        r = dgvDeposit.RowCount - 1;

                        string rem = rw["brem"].ToString();
                        decimal bamt = string.IsNullOrEmpty(rw["bamt"].ToString()) ? 0 : Decimal.Parse(rw["bamt"].ToString());
                        //MessageBox.Show(bamt.ToString());
                        dgvDeposit.Rows[r].Cells[0].Value = rem;
                        decimal namt = bamt;
                        if (namt < 0)
                        {
                            dgvDeposit.Rows[r].Cells[1].Value = Math.Abs(namt).ToString("###,###,##0.00");
                            ndr += Math.Abs(namt);
                        }
                        else
                        {
                            if (rem != "Beginning Balance")
                            {
                                ncr += namt;
                            }
                            dgvDeposit.Rows[r].Cells[2].Value = Math.Abs(namt).ToString("###,###,##0.00");

                        }
                        dgvDeposit.Rows[r].Cells[3].Value = rw["pkno"].ToString();

                    }
                    naddamt = 0; nlessamt = 0;
                    for (int i = 0; i <= dgvDeposit.RowCount - 1; i++)
                    {
                        if (dgvDeposit.Rows[i].Cells[1].Value != null)
                        {
                            nlessamt += string.IsNullOrEmpty(dgvDeposit.Rows[i].Cells[1].Value.ToString()) ? 0 : Decimal.Parse(dgvDeposit.Rows[i].Cells[1].Value.ToString());
                        }
                        if (dgvDeposit.Rows[i].Cells[2].Value != null)
                        {
                            naddamt += string.IsNullOrEmpty(dgvDeposit.Rows[i].Cells[2].Value.ToString()) ? 0 : Decimal.Parse(dgvDeposit.Rows[i].Cells[2].Value.ToString());
                        }

                    }
                    //nudDeposits.Value = naddamt - nlessamt;
                    nudDeposits.Value = nudTotal.Value + (naddamt - nlessamt);
                    //For i = 0 To dgvDeposit.RowCount - 1

                    //Next
                    nudLess.Value = ndr;
                    nudAdd.Value = ncr;
                }
                else
                {
                    dgvDeposit.Rows.Add();
                    r = dgvDeposit.RowCount - 1;
                    dgvDeposit.Rows[r].Cells[0].Value = "Beginning Balance:";
                    dgvDeposit.Rows[r].Cells[2].Value = nTBalance.ToString("###,###,##0.00");
                }
            }
            nudDeposits.Value = nudTotal.Value + nudAdd.Value - nudLess.Value;
            rs.Dispose();
        }
        decimal  ndr,ncr,nTBalance,naddamt,nlessamt;

        private void tbRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                nudAmount.Focus();
                nudAmount.Select(0, nudAmount.Value.ToString().Length + 3);

            }

        }

        private void cbteller_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get tbalance
            sgettbalance();
        }
        private void sgettbalance()
        {
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            rs = new DataTable();
            ssql = "select * from bcdb.users where username=@tel";
            dgvDeposit.Rows.Clear();
            using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
            {
                cmd2.Parameters.AddWithValue("@tel", Program.usr);
                cmd2.Prepare();

                rs = newdbcon.get_records(ssql, cmd2);
                dgvDeposit.Rows.Clear();
                if (rs.Rows.Count > 0)
                {
                    DataRow dr = rs.Rows[0];
                    nTBalance = Convert.ToDecimal(dr["tbalance"]);

                }
                cmd2.Dispose();
            }
            newdbcon.CloseConnection();
        }

        private void supdatedeposit()
        {
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            string qry = "UPDATE bcdb.users SET tbalance=@ntb WHERE username=@telno";
            using (MySqlCommand cmd2 = new MySqlCommand(qry, newdbcon.database_connection  ))
            {
                cmd2.Parameters.AddWithValue("@telno", Program.usr);
                cmd2.Parameters.AddWithValue("@ntb", nudDeposits.Value);
                cmd2.Prepare();
                cmd2.ExecuteNonQuery();

            }
        }
        string sptype;
		private void stellerblotter()
		{
            sgettbalance();
            ssql = "select ptype,sum(amtdue) as amt from pay_h where teller=@tel and tdate=@dt group by ptype order by ptype";
            DBConnect dbcon = new DBConnect();
            dbcon.OpenConnection(retries);
            DataTable dt = new DataTable();
            using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
            {
                cmd1.Parameters.AddWithValue("@tel", cbteller.Text);
                cmd1.Parameters.AddWithValue("@dt", dtpDate.Value.ToString("yyyy-MM-dd"));
                using (dt = new DataTable())
                {
                    dgvb.Rows.Clear();
                    dt = dbcon.get_records(ssql, cmd1);
                    if (dt.Rows.Count > 0)
                    {
                        
                        namt = 0;
                        foreach (DataRow rs in dt.Rows)
                        {
                            dgvb.Rows.Add();
                            r = dgvb.Rows.Count - 1;
							if (rs["ptype"].ToString() == "1")
							{
								sptype = "CASH";

							}
							else if (rs["ptype"].ToString()=="2")
							{
								sptype = "CHECK";
							}
							else { sptype = "ONLINE"; }
                            dgvb.Rows[r].Cells[0].Value = sptype;
                            dgvb.Rows[r].Cells[1].Value = rs["amt"];
                            namt += Convert.ToDecimal(rs["amt"]);

                        }
                        nudTotal.Value = namt;
                        namt = 0;
                    }
                }
                cmd1.Dispose();
            }
            ssql = "select a.ptype,sum(b.billamt) as ba,sum(b.ftax) as ft,sum(b.wmf) as wm,sum(b.penalty) as su,sum(b.srdisc) as sr," +
				" sum(b.wtax) as wt from pay_h a,pay_d b where a.teller=@tel and a.tdate=@dt and a.orno=b.orno group by a.ptype order by a.ptype";
            //DBConnect dbcon = new DBConnect();
            //dbcon.OpenConnection(retries);
            //DataTable dt = new DataTable();
            using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
            {
                cmd1.Parameters.AddWithValue("@tel", cbteller.Text);
                cmd1.Parameters.AddWithValue("@dt", dtpDate.Value.ToString("yyyy-MM-dd"));
                using (dt = new DataTable())
                {
                    dt = dbcon.get_records(ssql, cmd1);
                    if (dt.Rows.Count > 0)
                    {
                        //dgvb.Rows.Clear();
                        foreach (DataRow rs in dt.Rows)
                        {
                            //if (dgvb.Rows.Count == 1)
                            //{
                            //    break;
                            //}
                           
                            if (rs["ptype"].ToString() == "1")
                            {
								r = 0;


                            }
                            else if (rs["ptype"].ToString() == "2")
                            {
                                r = 1;
                            }
                            else { r = 2; }
                            if(rs["ba"] != DBNull.Value)
                            {
                                //MessageBox.Show(rs["ba"].ToString());
                                dgvb.Rows[r].Cells[2].Value = rs["ba"];
                            }
                            else
                            {
                                dgvb.Rows[r].Cells[2].Value = 0;
                            }
                            if (rs["ft"] != DBNull.Value)
                            {
                                dgvb.Rows[r].Cells[3].Value = rs["ft"];
                            }
                            else
                            {
                                dgvb.Rows[r].Cells[3].Value = 0;
                            }
                            if (rs["wm"] != DBNull.Value)
                            {
                                dgvb.Rows[r].Cells[4].Value = rs["wm"];
                            }
                            else
                            {
                                dgvb.Rows[r].Cells[4].Value = 0;
                            }
                            if (rs["su"] != DBNull.Value)
                            {
                                dgvb.Rows[r].Cells[5].Value = rs["su"];
                            }
                            else
                            {
                                dgvb.Rows[r].Cells[5].Value = 0;
                            }

                            if (rs["sr"] != DBNull.Value)
                            {
                                dgvb.Rows[r].Cells[6].Value = rs["sr"];
                            }
                            else
                            {
                                dgvb.Rows[r].Cells[6].Value = 0;
                            }
                            if (rs["wt"] != DBNull.Value)
                            {
                                dgvb.Rows[r].Cells[7].Value = rs["wt"];
                            }
                            else
                            {
                                dgvb.Rows[r].Cells[7].Value = 0;
                            }

						}
                    }
                }
                cmd1.Dispose();
            }
            dbcon.CloseConnection();
            sgetdeposit();


        }

		private void sdcreportmiscellaneous()
		{
			ssql = "select a.acctname,b.* from pay_h a,pay_d b where a.teller=@tel and a.tdate=@dt and b.ttype<>'1' and a.orno=b.orno order by orno";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd1.Parameters.AddWithValue("@tel", cbteller.Text);
				cmd1.Parameters.AddWithValue("@dt", dtpDate.Value.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						dgvm.Rows.Clear();
						foreach (DataRow rs in dt.Rows)
						{
							dgvm.Rows.Add();
							r = dgvm.Rows.Count - 1;
							dgvm.Rows[r].Cells[1].Value = rs["acctno"];
							dgvm.Rows[r].Cells[0].Value = rs["acctname"];
							dgvm.Rows[r].Cells[1].Value = rs["orno"];
							dgvm.Rows[r].Cells[2].Value = rs["paidamount"];
							if (rs["ttype"].ToString() == "60")
							{
								dgvm.Rows[r].Cells[3].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "61")
							{
								dgvm.Rows[r].Cells[4].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "62")
							{
								dgvm.Rows[r].Cells[5].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "63")
							{
								dgvm.Rows[r].Cells[6].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "64")
							{
								dgvm.Rows[r].Cells[7].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "65")
							{
								dgvm.Rows[r].Cells[8].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "66")
							{
								dgvm.Rows[r].Cells[9].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "67")
							{
								dgvm.Rows[r].Cells[10].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "68")
							{
								dgvm.Rows[r].Cells[11].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "69")
							{
								dgvm.Rows[r].Cells[12].Value = rs["paidamount"];
							}
						}
					}
				}
				cmd1.Dispose();
			}
			dbcon.CloseConnection();
		}
        decimal npay, ncurent, ncuyr, npyr, nftax, nwmf,npenalty, nsrdisc, nwtax;

        int nbp;
		private void sdailycollectionreport()
		{
            nbp = 202501;
			ssql = "select a.*,b.* from pay_h a,pay_d b where a.teller=@tel and a.tdate=@dt and a.orno=b.orno order by a.orno";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd1.Parameters.AddWithValue("@tel", cbteller.Text);
				cmd1.Parameters.AddWithValue("@dt", dtpDate.Value.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						dgv.Rows.Clear();
                        namt = 0;
						foreach (DataRow rs in dt.Rows)
						{
                            if (rs["orno"].ToString() == "026646")
                            {
                                //namt++;
                            }

							dgv.Rows.Add();
							r = dgv.Rows.Count - 1;
							dgv.Rows[r].Cells[0].Value = rs["acctno"];
							dgv.Rows[r].Cells[1].Value = rs["acctname"];
                            //MessageBox.Show(rs["iscanceled"].ToString());
							if (rs["iscanceled"] != DBNull.Value)
                            {
                                if (Convert.ToInt32(rs["iscanceled"]) == 1)
                                {
									dgv.Rows[r].Cells[1].Value = "Cancelded-" + rs["acctname"];
								}
								
							}

							
							dgv.Rows[r].Cells[2].Value = rs["orno"];
							
                            if (rs["paidamount"] != DBNull.Value)
                            {
                                dgv.Rows[r].Cells[3].Value = rs["paidamount"];
                                namt += Convert.ToDecimal(rs["paidamount"]);
                            }
                            else
                            {
                                dgv.Rows[r].Cells[3].Value = 0;
                            }

                            
                            //if (bp == rs["billperiod"].ToString())
                            //{
                            //	dgv.Rows[r].Cells[4].Value = Convert.ToDecimal( rs["paidamount"]);
                            //}
                            //else if (Convert.ToInt32(rs["billperiod"].ToString().Substring(0, 4)) < Convert.ToInt32(bp.ToString().Substring(0, 4)))
                            //{
                            //	dgv.Rows[r].Cells[5].Value = Convert.ToDecimal(rs["paidamount"]); ;
                            //}
                            //else if (Convert.ToInt32(rs["billperiod"]) < Convert.ToInt32(bp))
                            //{
                            //	dgv.Rows[r].Cells[6].Value = Convert.ToDecimal(rs["paidamount"]); ;
                            //}
                            //ssql = rs["billperiod"].ToString();
                            if (rs["ttype"].ToString() == "1")
                            {
                                if (rs["iscanceled"] == DBNull.Value)
                                {
									if (nbp == Convert.ToInt32( rs["billperiod"].ToString()))
									{
										dgv.Rows[r].Cells[4].Value = Convert.ToDecimal(rs["billamt"]) + Convert.ToDecimal(rs["ftax"]);
									}
									else if (Convert.ToInt32(rs["billperiod"].ToString().Substring(0, 4)) < Convert.ToInt32(bp.ToString().Substring(0, 4)))
									{


										dgv.Rows[r].Cells[6].Value = Convert.ToDecimal(rs["billamt"]) + Convert.ToDecimal(rs["ftax"]); ;
									}
									else if (Convert.ToInt32(rs["billperiod"]) < Convert.ToInt32(bp))
									{
										dgv.Rows[r].Cells[5].Value = Convert.ToDecimal(rs["billamt"]) + Convert.ToDecimal(rs["ftax"]); ;
									}
								}
                               
                            }
                            else
                            {
								dgv.Rows[r].Cells[4].Value = 0;
							    dgv.Rows[r].Cells[6].Value = 0;
							    dgv.Rows[r].Cells[5].Value = 0;
							}
                            dgv.Rows[r].Cells[8].Value = rs["penalty"];
                            dgv.Rows[r].Cells[7].Value = rs["ftax"];
                            dgv.Rows[r].Cells[9].Value = rs["wmf"];
                            dgv.Rows[r].Cells[10].Value = rs["srdisc"];
                            dgv.Rows[r].Cells[11].Value = rs["wtax"];
                            dgv.Rows[r].Cells[12].Value = rs["billperiod"];

                            //dgv.Rows[r].Cells[8].Value = 0;
                            //dgv.Rows[r].Cells[7].Value = 0;
                            //dgv.Rows[r].Cells[9].Value = 0;
                            //dgv.Rows[r].Cells[10].Value = 0;
                            //dgv.Rows[r].Cells[11].Value = 0;
                            //if (rs["iscanceled"] == DBNull.Value)
                            //                     {

                            //                     }
                            //                     else
                            //                     {

                            //}
                            //dgv.Rows[r].Cells[11].Value = rs["advance"];
                            //dgv.Rows[r].Cells[12].Value = rs["others"];
                            //dgv.Rows[r].Cells[13].Value = rs["stubno"];

                        }
						nudTotal.Value = namt;
                        namt = 0;
                        npay = 0; npenalty = 0;
                        ncurent = 0;ncuyr = 0; npyr = 0;nftax = 0;nwmf = 0;nsrdisc = 0;nwtax = 0;

                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            npay  += Convert.ToDecimal( dgv.Rows[i].Cells[3].Value);
                            ncurent  += Convert.ToDecimal(dgv.Rows[i].Cells[4].Value);
                            ncuyr += Convert.ToDecimal(dgv.Rows[i].Cells[5].Value);
                            npyr += Convert.ToDecimal(dgv.Rows[i].Cells[6].Value);
                            if (dgv.Rows[i].Cells[7].Value != DBNull.Value)
                            {
								nftax += Convert.ToDecimal(dgv.Rows[i].Cells[7].Value);
							}
                            if (dgv.Rows[i].Cells[8].Value != DBNull.Value)
                            {
								nwmf += Convert.ToDecimal(dgv.Rows[i].Cells[8].Value);
							}
							if (dgv.Rows[i].Cells[9].Value != DBNull.Value)
							{
								npenalty += Convert.ToDecimal(dgv.Rows[i].Cells[9].Value);
							}
							if (dgv.Rows[i].Cells[10].Value != DBNull.Value)
							{
								nsrdisc += Convert.ToDecimal(dgv.Rows[i].Cells[10].Value);
							}
							
                            //nwtax += Convert.ToDecimal(dgv.Rows[i].Cells[11].Value);
                        }
                        dgvt.Rows.Clear();
                        dgvt.Rows.Add();
                        dgvt.Rows[0].Cells[0].Value = dt.Rows.Count;
                        dgvt.Rows[0].Cells[1].Value = dgv.Rows.Count;
                        dgvt.Rows[0].Cells[3].Value = npay;
                        dgvt.Rows[0].Cells[4].Value = ncurent ;
                        dgvt.Rows[0].Cells[5].Value = ncuyr;
                        dgvt.Rows[0].Cells[6].Value = npyr;
                        dgvt.Rows[0].Cells[7].Value = nftax ;
                        dgvt.Rows[0].Cells[8].Value = nwmf ;
                        dgvt.Rows[0].Cells[9].Value = npenalty;
                        dgvt.Rows[0].Cells[10].Value = nsrdisc;
                        //dgvt.Rows[0].Cells[11].Value = nwtax ;

                    }
				}
				cmd1.Dispose();
			}
			dbcon.CloseConnection();

		}
	}
}