﻿using bcsys.Forms.ReportForms;
using bcsys.modules;
using bcsys.Reports;
using DevExpress.DataProcessing.InMemoryDataProcessor.GraphGenerator;
using DevExpress.Diagram.Core.Native;
using DevExpress.Drawing.Internal.Fonts.Interop;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectPositions newpos = new ObjectPositions();
                frmDashboard fdash = new frmDashboard();
                agingreport mainfrm = new agingreport();
                frmloading frm = new frmloading();

                string thirdParam = string.Empty;
                //string myparamtest1 = "Confidential";

                DataSet ds = new DataSet2();

                //ds.Tables.Clear();
                ds.Tables[3].Rows.Clear();
                ds.Tables[4].Rows.Clear();

                XtraReport rpt = new xrdlycollectionreport ();
                var labelReceiver = (XRLabel)rpt.FindControl("testlabel", false);

                Application.DoEvents();

                newpos.CenterObj(fdash, frm);
                this.Cursor = Cursors.AppStarting;

                frm.BringToFront();
                frm.Show(mainfrm);

                frm.Refresh();
                Random rnd = new Random();
                Random rnd2 = new Random();
                DataRow r1 = ds.Tables[4].NewRow();
                r1["acctname"] = "Tangub City Water District";
                r1["address"] = "Aging Report";
                r1["acctno"] = "1";
                r1["billdate"] = dtpDate.Value;
                r1["sig1"] = Program.sig1;
                r1["sig2"] = Program.sig2;
                r1["sig3"] = Program.sig3;

                ds.Tables[4].Rows.Add(r1);
                if (xtc1.SelectedTabPageIndex == 0)
                {
                    for (int i = 0; i <= dgv.RowCount - 1; i++)
                    {
                        DataRow r2 = ds.Tables[3].NewRow();
                        r2["acctno"] = "1";
                        r2["nno"] = i + 1;
                        r2["refno"] = dgv.Rows[i].Cells[0].Value;
                        r2["acctname"] = dgv.Rows[i].Cells[1].Value;
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

                        ds.Tables[3].Rows.Add(r2);
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
                        ssql = "INSERT INTO bcdb.tblotter(tellerno,bdate,brem,bamt,pkno,seqno) VALUES(@tel,@dte,@br,@ba,@pk,@sq)";
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
            ssql = "update bcdb.tblotter set bamt=@dep where tellerno=@tel and seqno=0 and bdate=@dte";
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

        private void sgetdeposit()
        {
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            rs = new DataTable();
            ssql = "select * from bcdb.tblotter where tellerno=@tel and bdate=@dte order by seqno";
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
            rs.Dispose();
        }
        decimal  ndr,ncr,nTBalance,naddamt,nlessamt;
        private void supdatedeposit()
        {
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            string qry = "UPDATE bcdb.user SET tbalance=@ntb WHERE tellerno=@telno";
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
                    dt = dbcon.get_records(ssql, cmd1);
                    if (dt.Rows.Count > 0)
                    {
                        dgvb.Rows.Clear();
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
                            

                        }
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
                           
                            if (rs["ptype"].ToString() == "1")
                            {
								r = 0;


                            }
                            else if (rs["ptype"].ToString() == "2")
                            {
                                r = 1;
                            }
                            else { r = 2; }
							dgvb.Rows[r].Cells[2].Value = rs["ba"];
							dgvb.Rows[r].Cells[3].Value = rs["ft"];
							dgvb.Rows[r].Cells[4].Value = rs["wm"];
							dgvb.Rows[r].Cells[5].Value = rs["su"];
							dgvb.Rows[r].Cells[6].Value = rs["sr"];
							dgvb.Rows[r].Cells[7].Value = rs["wt"];

						}
                    }
                }
                cmd1.Dispose();
            }
            dbcon.CloseConnection();

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
							dgvm.Rows[r].Cells[2].Value = rs["orno"];
							dgvm.Rows[r].Cells[3].Value = rs["paidamount"];
							if (rs["ttype"].ToString() == "60")
							{
								dgvm.Rows[r].Cells[4].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "61")
							{
								dgvm.Rows[r].Cells[5].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "62")
							{
								dgvm.Rows[r].Cells[6].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "63")
							{
								dgvm.Rows[r].Cells[7].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "64")
							{
								dgvm.Rows[r].Cells[8].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "65")
							{
								dgvm.Rows[r].Cells[9].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "66")
							{
								dgvm.Rows[r].Cells[10].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "67")
							{
								dgvm.Rows[r].Cells[11].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "68")
							{
								dgvm.Rows[r].Cells[12].Value = rs["paidamount"];
							}
							else if (rs["ttype"].ToString() == "69")
							{
								dgvm.Rows[r].Cells[13].Value = rs["paidamount"];
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
			ssql = "select b.*,a.acctname from pay_h a,pay_d b where a.teller=@tel and a.tdate=@dt and a.orno=b.orno order by a.orno";
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
						foreach (DataRow rs in dt.Rows)
						{
							dgv.Rows.Add();
							r = dgv.Rows.Count - 1;
							dgv.Rows[r].Cells[0].Value = rs["acctno"];
							dgv.Rows[r].Cells[1].Value = rs["acctname"];
							dgv.Rows[r].Cells[2].Value = rs["orno"];
							dgv.Rows[r].Cells[3].Value = rs["paidamount"];
							if (bp == rs["billperiod"].ToString())
							{
								dgv.Rows[r].Cells[4].Value = Convert.ToDecimal( rs["billamt"]) + Convert.ToDecimal(rs["ftax"]);
							}
							else if (Convert.ToInt32(rs["billperiod"].ToString().Substring(0, 4)) < Convert.ToInt32(bp.ToString().Substring(0, 4)))
							{
								dgv.Rows[r].Cells[5].Value = Convert.ToDecimal(rs["billamt"]) + Convert.ToDecimal(rs["ftax"]); ;
							}
							else if (Convert.ToInt32(rs["billperiod"]) < Convert.ToInt32(bp))
							{
								dgv.Rows[r].Cells[6].Value = Convert.ToDecimal(rs["billamt"]) + Convert.ToDecimal(rs["ftax"]); ;
							}
							dgv.Rows[r].Cells[8].Value = rs["penalty"];
							dgv.Rows[r].Cells[7].Value = rs["ftax"];
							dgv.Rows[r].Cells[9].Value = rs["wmf"];
							dgv.Rows[r].Cells[10].Value = rs["srdisc"];
							dgv.Rows[r].Cells[11].Value = rs["wtax"];
							//dgv.Rows[r].Cells[11].Value = rs["advance"];
							//dgv.Rows[r].Cells[12].Value = rs["others"];
							//dgv.Rows[r].Cells[13].Value = rs["stubno"];

						}
					}
				}
				cmd1.Dispose();
			}
			dbcon.CloseConnection();

		}
	}
}