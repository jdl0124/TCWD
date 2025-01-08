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
//using DataTable = DevExpress.DataAccess.Native.Data.DataTable;

namespace bcsys.Forms.EntryForms
{
    public partial class collection : Form
    {
        string ssql;
        int retries = 1;
        int r;string sguid;
        decimal namount, npenalty, ndiscount;
        public int nain;


        public collection()
        {
            InitializeComponent();
        }

        private void collection_Load(object sender, EventArgs e)
        {
            tsGL.Enabled = false;
            tbTeller.Text = Program.usr;
            sgetlastorno();
            cboFilter.SelectedIndex = 0;
            sdisplaycollection();
            sloadbanks();
            rbCash.Checked = true;
		}
        int norno;
        private void sgetlastorno()
        {
            ssql = "select * from pay_h where teller=@tel order by orno desc limit 1";
            DBConnect dbcon = new DBConnect();
            dbcon.OpenConnection(retries);
            DataTable rs = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
            {
                cmd.Parameters.AddWithValue("@tel", Program.usr);
                using (rs = new DataTable())
                {
                    rs = dbcon.get_records(ssql, cmd);
                    if (rs.Rows.Count > 0)
                    {
                        DataRow dr = rs.Rows[0];
                        norno = Convert.ToInt16(dr["orno"].ToString()) + 1;
                        //MessageBox.Show(dr["orno"].ToString());
						tbOrNo.Text = norno.ToString().PadLeft(6, '0');
                    }
                    else
                    {
                        tbOrNo.Text = "000001";
                    }
                }
                cmd.Dispose();
            }
            dbcon.CloseConnection();
        }

        private void sdisplaycollection()
        {
            
			ssql = "select a.tdate,a.orno,b.name,a.amtdue,b.mascode from bcdb.pay_h a,bcdb.master b " +
                "where a.mascode=b.mascode and a.teller=@tel and a.tdate=@dt and a.iscanceled is null " +
                "order by orno desc";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@tel", Program.usr);
				cmd.Parameters.AddWithValue("@dt", dtpCollection.Value.ToString("yyyy-MM-dd"));
				using (rs = new DataTable())
				{
					rs = dbcon.get_records(ssql, cmd);
					if (rs.Rows.Count > 0)
					{
                        dgvItem.Columns.Clear();
                        dgvItem.DataSource = rs;
                        sformatdgv();
					}
				}
				cmd.Dispose();
			}
			dbcon.CloseConnection();

		}

        private void sformatdgv()
        {
            dgvItem.Columns[0].HeaderText = "Date";
            dgvItem.Columns[1].HeaderText = "ORNo.";
            dgvItem.Columns[2].HeaderText = "Consumer Name";
            dgvItem.Columns[3].HeaderText = "Amount Paid";
            dgvItem.Columns[4].HeaderText = "MasCode";
            dgvItem.Columns[0].Width = 70;
            dgvItem.Columns[0].DefaultCellStyle.Format = "d";
            dgvItem.Columns[0].Visible = false; 
            dgvItem.Columns[1].Width = 70;
            dgvItem.Columns[2].Width = 200;
            dgvItem.Columns[3].Width = 70;
            dgvItem.Columns[3].DefaultCellStyle.Format = "N2";
            dgvItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItem.Columns[4].Visible = false;
        }
        private void btnConSearch_Click(object sender, EventArgs e)
        {
            Form consearch = new consearch();
            consearch.ShowDialog();
            tbmascode.Text = Program.smascode;
            tbAcctno.Text = Program.accno;
            tbAcctno.Focus();
            tbAcctno_KeyDown(1, new KeyEventArgs(Keys.Enter));
            //display details

        }

        private void tbAcctno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbAcctno.Text != "")
                {
                    sdisplayname();
                    sdisplaydetails();
                    tsGL.Enabled = true;
                }
            }
            else if (e.KeyCode == Keys.F2) 
            {
                Form consearch = new consearch();
                consearch.ShowDialog();
                tbmascode.Text = Program.smascode;
                tbAcctno.Text = Program.accno;
                sdisplayname();
                sdisplaydetails();
            }
        }
        private void sdisplayname()
        {
            ssql = "select * from bcdb.master where accno=@zn";
            DBConnect dbcon = new DBConnect();
            dbcon.OpenConnection(retries);
            DataTable rs = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
            {
                cmd.Parameters.AddWithValue("@zn", tbAcctno.Text);
                using (rs = new DataTable())
                {
                    rs = dbcon.get_records(ssql, cmd);
                    if (rs.Rows.Count > 0)
                    {
                        foreach (DataRow dr in rs.Rows)
                        {
                            tbmascode.Text = dr["mascode"].ToString();
                            tbAcctno.Text = dr["accno"].ToString();
                            tbName.Text = dr["Name"].ToString();
                            tbAddress.Text = dr["address"].ToString();
                            tbtin.Text = dr["tin"].ToString();
                            nain = Convert.ToInt32 (dr["cust_stat"].ToString());
                            if (tbtin.Text.Length > 0)
                            {
                                tbtin.Visible = true;
                                nudwtax.ReadOnly = false;
                            }
                            else{ tbtin.Visible = false; nudwtax.ReadOnly = true;
                            }  

                        }
                        sdisplaydetails();
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
        public decimal nbillamt, nftax, nwmf, npayment, ntotalbill, nbalance;

        private void nudRendered_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudChange.Value = nudTendered.Value - nudamtdue.Value;
                tsbSave.Select();
                tsTeller.Focus();
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (tbAcctno.Text == "")
            {
                tbAcctno.Focus();
                return;

            }
            if (nudTotal.Value <= 0)
            {
                dgvPayment.Focus();
                return;
            }
            if (dgvPayment.RowCount <= 0)
            {
                tbAcctno.Focus();
                return;
            }
            if (tbOrNo.Text == "")
            {
                tbOrNo.Focus(); return; 
            }
            if (counttrue() > 7)
            {
                //dgvPayment.CurrentRow.Cells[1].Value = false;
                MessageBox.Show("You cannot select more than 3 items from the list.");
                return;
            }

            ssavepayment();
            //sprintor();
            sprnorxr();
            tbOrNo.Text = (Convert.ToInt16(tbOrNo.Text) + 1).ToString().PadLeft(6,'0');
            sinit();
            sdisplaycollection();

        }

        private void sinit()
        {
            tbAcctno.Text = string.Empty;
            //tbOrNo.Text = string.Empty;
            tbName.Text = string.Empty;
            tbmascode.Text = string.Empty;
            tbAddress.Text = string.Empty;
            nudamtdue.Value = 0;
            nudTotal.Value = 0;
            nudwtax.Value = 0;
            nudTendered.Value = 0;
            nudamtdue.Value = 0;
            nudChange.Value = 0;
            dgvPayment.Rows.Clear();

        }
        int iptype;
        private void ssavepayment()
        {
            ssql = "select * from pay_h where teller=@tel and orno=@or";
            DBConnect dbcon = new DBConnect();
            dbcon.OpenConnection(retries);
            DataTable rs = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
            {
                cmd.Parameters.AddWithValue("@tel", tbTeller.Text);
                cmd.Parameters.AddWithValue("@or", tbOrNo.Text);
                using (rs = new DataTable())
                {
                    rs = dbcon.get_records(ssql, cmd);
                    if (rs.Rows.Count <= 0)
                    {
                        //save payment header
                        DBConnect ndbcon = new DBConnect(); ndbcon.OpenConnection(retries);
                        ssql = "insert into bcdb.pay_h (tdate,date,orno,mascode,acctno,acctname,totamt,wtax,amtdue,rendered,teller,remarks,ptype) " +
                            "values (@tdt,@dta,@or,@mc,@acn,@ana,@tot,@wt,@ad,@ren,@tel,@rm,@pt)";
                        using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                        {
                            cmd2.Parameters.AddWithValue("@tdt", dtpCollection.Value.ToString("yyyy-MM-dd"));
                            cmd2.Parameters.AddWithValue("@dta", dtpCollection.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd2.Parameters.AddWithValue("@or", tbOrNo.Text);
                            cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
                            cmd2.Parameters.AddWithValue("@acn", tbAcctno.Text);
                            cmd2.Parameters.AddWithValue("@ana", tbName.Text);
                            cmd2.Parameters.AddWithValue("@tot", nudTotal.Value);
							cmd2.Parameters.AddWithValue("@wt", nudwtax.Value);
							cmd2.Parameters.AddWithValue("@ad", nudamtdue.Value);
							cmd2.Parameters.AddWithValue("@ren", nudTendered.Value);
                            cmd2.Parameters.AddWithValue("@tel", tbTeller.Text);
                            cmd2.Parameters.AddWithValue("@rm", tbRemarks.Text);
                            if (rbCash.Checked)
                            {
                                iptype = 1;
                            }
                            else if (rbCheck.Checked)
                                {
                                    iptype = 2;
                                }
                            else if (rbOnline.Checked)
                            {
                                iptype = 3;
                            }

                            cmd2.Parameters.AddWithValue("@pt", iptype);
                            cmd2.Prepare();
                            cmd2.ExecuteNonQuery();
                            cmd2.Dispose();
                        }

                        //save payment details
                        for (int i = 0;i <= dgvPayment.RowCount -1;i++)
                        {
                            if (Convert.ToBoolean(dgvPayment.Rows[i].Cells[1].Value) == true)
                            {
                                sguid = "";
                                bool naa = true;
                                while (naa == true)
                                {
                                    sguid = System.Guid.NewGuid().ToString();
                                    sguid = sguid.Substring(0, 10);
                                    rs = new DataTable();
                                    ssql = "Select * from bcdb.pay_d where paycntr=@pk";
                                    using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                                    {
                                        cmd2.Parameters.AddWithValue("@pk", sguid);
                                        cmd2.Prepare();
                                        rs = ndbcon.get_records(ssql, cmd2);
                                        cmd2.Dispose();
                                        if (rs.Rows.Count == 0)
                                        {
                                            naa = false;
                                            //break;

                                        }

                                    }
                                    rs.Dispose();
                                }
                                //save
                                ssql = "insert into bcdb.pay_d (paycntr,pdate,teller,orno,mascode,acctno,billperiod,billamount,paidamount,ttype,remark,billamt,ftax,wmf,penalty,srdisc,wtax) " +
                                    "values(@pc,@pd,@tel,@or,@mc,@acn,@bp,@bamt,@pamt,@tt,@rem,@ba,@ft,@wm,@pen,@srd,@wtax)";
                                using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                                {
                                    cmd2.Parameters.AddWithValue("@pc", sguid);
                                    cmd2.Parameters.AddWithValue("@pd", dtpCollection.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                                    cmd2.Parameters.AddWithValue("@tel", tbTeller.Text);
                                    cmd2.Parameters.AddWithValue("@or", tbOrNo.Text);
                                    cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
                                    cmd2.Parameters.AddWithValue("@acn", tbAcctno.Text);
                                    cmd2.Parameters.AddWithValue("@bp", dgvPayment.Rows[i].Cells[16].Value);
                                    cmd2.Parameters.AddWithValue("@bamt", dgvPayment.Rows[i].Cells[8].Value);
                                    cmd2.Parameters.AddWithValue("@pamt", dgvPayment.Rows[i].Cells[12].Value);
                                    cmd2.Parameters.AddWithValue("@tt", dgvPayment.Rows[i].Cells[15].Value);
                                    cmd2.Parameters.AddWithValue("@rem", dgvPayment.Rows[i].Cells[14].Value);
                                    cmd2.Parameters.AddWithValue("@ba", dgvPayment.Rows[i].Cells[4].Value);
                                    cmd2.Parameters.AddWithValue("@ft", dgvPayment.Rows[i].Cells[5].Value);
                                    cmd2.Parameters.AddWithValue("@wm", dgvPayment.Rows[i].Cells[6].Value);
                                    cmd2.Parameters.AddWithValue("@pen", dgvPayment.Rows[i].Cells[7].Value);
                                    cmd2.Parameters.AddWithValue("@srd", dgvPayment.Rows[i].Cells[10].Value);
									cmd2.Parameters.AddWithValue("@wtax", dgvPayment.Rows[i].Cells[11].Value);

									cmd2.Prepare();
                                    cmd2.ExecuteNonQuery();
                                    cmd2.Dispose();
                                }
                                //save tin to master
                                if (tbtin.Text.Length > 0)
                                {
                                    ssql = "update bcdb.master set tin=@tin where mascode=@mc";
									using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
									{
										cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
										cmd2.Parameters.AddWithValue("@tin", tbtin.Text);
										cmd2.Prepare();
										cmd2.ExecuteNonQuery();
										cmd2.Dispose();
									}
								}
                                //save to reading
                                namt = 0;
                                if (dgvPayment.Rows[i].Cells[15].Value.ToString() == "1")
                                {
                                    ssql = "update bcdb.reading_bc set payment=@pa where mascode=@mc and billperiod=@bp";
                                    using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                                    {
                                        namt = Convert.ToDecimal(dgvPayment.Rows[i].Cells[9].Value) + Convert.ToDecimal(dgvPayment.Rows[i].Cells[12].Value);
                                        cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
                                        cmd2.Parameters.AddWithValue("@pa", namt);
                                        cmd2.Parameters.AddWithValue("@bp", dgvPayment.Rows[i].Cells[16].Value);
                                        cmd2.Prepare();
                                        cmd2.ExecuteNonQuery();
                                        cmd2.Dispose();
                                    }
                                }
								
                                namt = 0;
                                //save penalty date payment
                                namt = Convert.ToDecimal(dgvPayment.Rows[i].Cells[7].Value);

								if (namt > 0)
                                {
									ssql = "update bcdb.penalty set payment=@pa,pdate=@dt where mascode=@mc and billperiod=@bp";
									using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
									{
										cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
										cmd2.Parameters.AddWithValue("@pa", namt);
                                        cmd2.Parameters.AddWithValue("@dt", dtpCollection.Value.ToString("yyyy-MM-dd"));
										cmd2.Parameters.AddWithValue("@bp", dgvPayment.Rows[i].Cells[16].Value);
										cmd2.Prepare();
										cmd2.ExecuteNonQuery();
										cmd2.Dispose();
									}
								}
								namt = 0;
							}
                        }
                        //save bank details
                        if (iptype == 2)
                        {
                            ssql = "insert into bcdb.paychk_d (teller,mascode,tdate,orno,amount,bankcode,checkno,checkdate,ptype) " +
                            "values (@tel,@mc,@tdt,@or,@amt,@bc,@ckn,@ckdt,@pt)";
                            using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                            {
                                cmd2.Parameters.AddWithValue("@tel", tbTeller.Text);
                                cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
                                cmd2.Parameters.AddWithValue("@tdt", dtpCollection.Value.ToString("yyyy-MM-dd"));
                                cmd2.Parameters.AddWithValue("@or", tbOrNo.Text);
                               
                                cmd2.Parameters.AddWithValue("@amt", nudamtdue.Value);
                                cmd2.Parameters.AddWithValue("@bc", cbBank.SelectedValue);

                                cmd2.Parameters.AddWithValue("@ckn", tbCheckNo.Text);
                                cmd2.Parameters.AddWithValue("@ckdt",dtpchkdate.Value.ToString("yyyy-MM-dd"));
                                
                                cmd2.Parameters.AddWithValue("@pt", iptype);
                                cmd2.Prepare();
                                cmd2.ExecuteNonQuery();
                                cmd2.Dispose();
                            }
                        }
                        else if (iptype == 3)
                        {
                            ssql = "insert into bcdb.paychk_d (teller,mascode,tdate,orno,amount,checkdate,bankcode,ptype) " +
                            "values (@tel,@mc,@tdt,@or,@amt,@ckdt,@bc,@pt)";
                            using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                            {
                                cmd2.Parameters.AddWithValue("@tel", tbTeller.Text);
                                cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
                                cmd2.Parameters.AddWithValue("@tdt", dtpCollection.Value.ToString("yyyy-MM-dd"));
                                cmd2.Parameters.AddWithValue("@or", tbOrNo.Text);

                                cmd2.Parameters.AddWithValue("@amt", nudamtdue.Value);
                                cmd2.Parameters.AddWithValue("@bc", cbBank.SelectedValue);
                                cmd2.Parameters.AddWithValue("@ckdt", dtpchkdate.Value.ToString("yyyy-MM-dd"));

                                cmd2.Parameters.AddWithValue("@pt", iptype);
                                cmd2.Prepare();
                                cmd2.ExecuteNonQuery();
                                cmd2.Dispose();
                            }
                        }
                        
                        ndbcon.CloseConnection();
                    }
                }
            }
        }

        DataSet ds;
        ReportDocument rpt;

        private void tsbGLAdd_Click(object sender, EventArgs e)
        {
            Form ms = new mischarges();
            ms.Text = "Miscellaneous Charges";
            ms.ShowDialog();
            if (Program.nmisamount > 0)
            {
                dgvPayment.Rows.Add();
                r = dgvPayment.Rows.Count - 1;
                dgvPayment.Rows[r].Cells[1].Value = true;
                dgvPayment.Rows[r].Cells[2].Value = DateTime.Now.ToString("MMM-yyyy");
                dgvPayment.Rows[r].Cells[3].Value = 0;
                dgvPayment.Rows[r].Cells[4].Value = Program.rate;
                dgvPayment.Rows[r].Cells[5].Value = 0;
                dgvPayment.Rows[r].Cells[6].Value = 0;
                dgvPayment.Rows[r].Cells[7].Value = 0;
                dgvPayment.Rows[r].Cells[8].Value = Program.rate;
                dgvPayment.Rows[r].Cells[9].Value = 0;
                dgvPayment.Rows[r].Cells[10].Value = 0;
                dgvPayment.Rows[r].Cells[11].Value = 0;
                dgvPayment.Rows[r].Cells[12].Value = Program.rate;
                dgvPayment.Rows[r].Cells[13].Value = 0;
                dgvPayment.Rows[r].Cells[14].Value = Program.desc0;
                dgvPayment.Rows[r].Cells[15].Value = Program.ttype;
                dgvPayment.Rows[r].Cells[16].Value = DateTime.Now.ToString("yyyyMM");
                scomputetotal();

            }
            
        }

        decimal namt;
        private void scomputetotal()
        {
            nudTotal.Value = 0;
            namt = 0;
            for (int i = 0; i < dgvPayment.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvPayment.Rows[i].Cells[1].Value) == true)
                {
                    namt += Convert.ToDecimal(dgvPayment.Rows[i].Cells[12].Value);
                }
                
            }
            nudTotal.Value = namt;
            nudamtdue.Value = namt - nudwtax.Value;
            nudChange.Value = nudTendered.Value - nudamtdue.Value; 
           
        }

		private void dtpCollection_ValueChanged(object sender, EventArgs e)
		{
			//check if date is greater than the close collection from tellerlog
			ssql = "select * from bcdb.tellerlog where teller=@tel and cdate>=@cdt and cstatus=1 order by cdate desc limit 1";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@tel", Program.usr);
				cmd.Parameters.AddWithValue("@cdt", dtpCollection.Value.ToString("yyyy-MM-dd"));
				using (rs = new DataTable())
				{
					rs = dbcon.get_records(ssql, cmd);
					if (rs.Rows.Count > 0)
					{
                        MessageBox.Show("You cannot select the date lesser than or equal to closed collection dates.");
                        dtpCollection.Focus();
					}
				}
				cmd.Dispose();
			}
			dbcon.CloseConnection();
		}

		private void tsbTClose_Click(object sender, EventArgs e)
		{
            DialogResult ans = MessageBox.Show("Are you sure?", "Collection", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                ssql = "update bcdb.tellerlog set dtclose=@dt,status=1 where teller=@tel and cdate=@cdt";
                DBConnect dbcon = new DBConnect();
                dbcon.OpenConnection(retries);
				using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
				{
					cmd.Parameters.AddWithValue("@tel", Program.usr);
					cmd.Parameters.AddWithValue("@cdt", dtpCollection.Value.ToString("yyyy-MM-dd"));
					cmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("HH:mm:ss tt"));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose ();
				}
                dtpchkdate.Value.AddDays(1);
				dbcon.CloseConnection();
                dtpCollection.Value.AddDays(1);
			}
		}

		private void sbtntin_Click(object sender, EventArgs e)
		{
            tbtin.Visible = true;
            tbtin.Focus();
		}

		private void tbtin_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode  == Keys.Enter)
            {
                if (tbtin.Text != string.Empty)
                {
					nudwtax.ReadOnly = false;
                    nudwtax.Select(0, nudwtax.Value.ToString().Length + 3);
					nudwtax.Focus();
				}
            }
		}

		private void nudwtax_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
                nudamtdue.Value = nudTotal.Value - nudwtax.Value;
				nudTendered.Select(0, nudTendered.Value.ToString().Length + 3);
				nudTendered.Focus();
            }
		}


		private void tsbSurcharge_Click(object sender, EventArgs e)
		{
            //check if duedate
            DateTime ddate = new DateTime();
            ddate = Convert.ToDateTime(dgvPayment.CurrentRow.Cells[19].Value);
            if (ddate < DateTime.Now)
            {
                namt = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[7].Value);
                if (namt <= 0)
                {
                    namt = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[4].Value) * .1m;
                    dgvPayment.CurrentRow.Cells[7].Value = namt;
                    nbillamt = Convert.ToDecimal( dgvPayment.CurrentRow.Cells[4].Value);
                    nftax = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[5].Value);
                    nwmf = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[7].Value);
                    ntotalbill = namt + nbillamt + nftax + nwmf;
                    dgvPayment.CurrentRow.Cells[8].Value = ntotalbill ;
                    dgvPayment.CurrentRow.Cells[9].Value = 0;
                    dgvPayment.CurrentRow.Cells[10].Value = 0;
                    dgvPayment.CurrentRow.Cells[12].Value = ntotalbill ;
                    dgvPayment.CurrentRow.Cells[13].Value = 0;
                    //add to penalty table
                    DBConnect dbcon = new DBConnect();
                    dbcon.OpenConnection(retries);
                    ssql = "insert into bcdb.penalty (hdate,mascode,acctno,billperiod,amount,payment,user) " +
                                            "values(@hdt,@mc,@acn,@bp,@amt,@pay,@usr)";
                    using (MySqlCommand cmd2 = new MySqlCommand(ssql, dbcon.database_connection))
                    {
                        cmd2.Parameters.AddWithValue("@hdt", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
                        cmd2.Parameters.AddWithValue("@acn", tbAcctno.Text);
                        cmd2.Parameters.AddWithValue("@bp", dgvPayment.CurrentRow.Cells[16].Value);
                        cmd2.Parameters.AddWithValue("@amt", namt);
                        cmd2.Parameters.AddWithValue("@pay", 0);
                        cmd2.Parameters.AddWithValue("@usr", Program.usr);
                        cmd2.Prepare();
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();
                       
                    }
                    //update surcahge
                    ssql = "update bcdb.reading_bc set penalty=@amt where mascode=@mc and billperiod=@bp";

                    using (MySqlCommand cmd2 = new MySqlCommand(ssql, dbcon.database_connection))
                    {
                        cmd2.Parameters.AddWithValue("@mc", tbmascode.Text);
                        cmd2.Parameters.AddWithValue("@bp", dgvPayment.CurrentRow.Cells[16].Value);
                        cmd2.Parameters.AddWithValue("@amt", namt);
                        
                        cmd2.Prepare();
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();
                       
                    }
                    namt = 0;


                    dbcon.CloseConnection();
                    scomputetotal();

                }
            }
            else
            {
                MessageBox.Show("Due date for this billing is " + ddate);
            }
		}

		private void tsbDiscount_Click(object sender, EventArgs e)
		{
            gbdiscount.Visible = true;
		}

		private void gbdiscount_Paint(object sender, PaintEventArgs e)
		{
           //MessageBox.Show(gbdiscount.CustomHeaderButtons[0].ToString());
            //e.Button.Properties
            ////if (e. == "Post")
            ////gbdiscount.Visible = false;
		}
		private void gbdiscount_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
		{
			MessageBox.Show("Button caption: " + e.Button.Properties.Caption);
		}

		private void bpost_Click(object sender, EventArgs e)
		{
            if (nudsenior.Value > 0)
            {
				dgvPayment.CurrentRow.Cells[10].Value = nudsenior.Value;
			}
            if (nudother.Value > 0)
            {
				dgvPayment.CurrentRow.Cells[11].Value = nudother.Value;
                
			}
            nudsenior.Value = 0;
            nudother.Value = 0;
            gbdiscount.Visible = false;
            sdgvrowtotal();
		}
        decimal ntotalwt;
        private void stotalwtax()
            {
            for (int i = 0; i < dgvPayment.Rows.Count; i++)
            {
                ntotalwt += Convert.ToDecimal( dgvPayment.Rows[i].Cells[11].Value);

            }
            nudwtax.Value = ntotalwt;
            }

        int rp;
		private void sprintor()
        {
            ds = new DataSet2();

            rpt = new serviceinvoice();

            DataTable dt1 = ds.Tables["billdtl"];
            dt1.Clear();
            
            DataRow r1;
            r1 = dt1.NewRow();
            r1["duedate"] = dtpCollection.Value.ToString();
            r1["acctname"] = tbName.Text;
            r1["barangay"] = tbAddress.Text;
            rp = 1;
            for (int i = 0; i <= dgvPayment.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dgvPayment.Rows[i].Cells[1].Value) == true)
                {
                    //r0["meterno"] = "";
                    r1["part" + rp.ToString()] = dgvPayment.Rows[i].Cells[2].Value + " (" + dgvPayment.Rows[i].Cells[3].Value + ";" +
                        dgvPayment.Rows[i].Cells[4].Value + ";" + dgvPayment.Rows[i].Cells[5].Value + ";" + dgvPayment.Rows[i].Cells[6].Value +
                        ";" + dgvPayment.Rows[i].Cells[7].Value + ")";
                    r1["q" + rp.ToString()] = 1;
                    r1["amt" + rp.ToString()] = Convert.ToDecimal(dgvPayment.Rows[i].Cells[8].Value);
                    rp++;
                }
            }
            //r1 = dt1.NewRow();
            r1["total"] = nudTotal.Value;
			r1["wtax"] = nudwtax.Value;
			r1["arbalance"] = nudamtdue.Value;
            dt1.Rows.Add(r1);
            
            rpt.SetDataSource(ds);
            var report_viewer = new Forms.reportviewer();
            report_viewer.crv1.ReportSource = rpt;
            report_viewer.crv1.Refresh();
            report_viewer.WindowState = FormWindowState.Maximized;
            report_viewer.ShowDialog();
        }

		private void bcancel_Click(object sender, EventArgs e)
		{
			nudsenior.Value = 0;
			nudother.Value = 0;
			gbdiscount.Visible = false;

		}
        int rw;
        private void sprnorxr()
        {
			try
			{
				ObjectPositions newpos = new ObjectPositions();
				frmDashboard fdash = new frmDashboard();
				frminterviews mainfrm = new frminterviews();
				frmloading frm = new frmloading();

				string thirdParam = string.Empty;
				//string myparamtest1 = "Confidential";

				DataSet ds = new DataSet2();

				ds.Tables["billdtl"].Rows.Clear();

				XtraReport rpt = new ServiceInvoiceXR();
				var labelReceiver = (XRLabel)rpt.FindControl("testlabel", false);

				Application.DoEvents();

				newpos.CenterObj(fdash, frm);
				this.Cursor = Cursors.AppStarting;

				frm.BringToFront();
				frm.Show(mainfrm);

				frm.Refresh();
				Random rnd = new Random();
				Random rnd2 = new Random();
				DataRow r1 = ds.Tables["billdtl"].NewRow();
				r1["duedate"] = dtpCollection.Value.ToString();
				r1["acctname"] = tbName.Text;
				r1["barangay"] = tbAddress.Text;
                r1["acctno"] = tbAcctno.Text ;
                r1["t1"] = tbTeller.Text;
				rw = 1;
				for (int i = 0; i <= dgvPayment.RowCount - 1; i++)
				{
					if (Convert.ToBoolean(dgvPayment.Rows[i].Cells[1].Value) == true)
					{
						//r0["meterno"] = "";
						r1["part" + (rw).ToString()] = dgvPayment.Rows[i].Cells[2].Value + " (" + dgvPayment.Rows[i].Cells[3].Value + ";" +
							dgvPayment.Rows[i].Cells[4].Value + ";" + dgvPayment.Rows[i].Cells[5].Value + ";" + dgvPayment.Rows[i].Cells[6].Value +
							";" + dgvPayment.Rows[i].Cells[7].Value + ")";
						r1["q" + (rw).ToString()] = 1;
						r1["amt" + (rw).ToString()] = Convert.ToDecimal(dgvPayment.Rows[i].Cells[12].Value);
						rw++;
					}
				}
				r1["total"] = nudTotal.Value;
				r1["wtax"] = nudwtax.Value;
				r1["arbalance"] = nudamtdue.Value;
				ds.Tables["billdtl"].Rows.Add(r1);
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
		private void sbtnprint_Click(object sender, EventArgs e)
		{
			
		}

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 2 && e.ColumnIndex != 12)
            {
                if (e.RowIndex >= 0)
                {
                    namount = 0;
                    if (Convert.ToBoolean(dgvPayment.CurrentRow.Cells[1].Value) == false)
                    {
                        dgvPayment.CurrentRow.Cells[1].Value = true;
                        dgvPayment.CurrentRow.Cells[12].Value = dgvPayment.CurrentRow.Cells[13].Value;
                        namt = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[13].Value) - Convert.ToDecimal(dgvPayment.CurrentRow.Cells[12].Value);
                        dgvPayment.CurrentRow.Cells[13].Value = namt;
                        //namount = nudTotal.Value;
                        namount += Convert.ToDecimal(dgvPayment.CurrentRow.Cells[12].Value);
                        nudTotal.Value = namount;
                        //nudamtdue.Value = namount - nudwtax.Value;

                    }
                    else
                    { 
                        dgvPayment.CurrentRow.Cells[1].Value = false;
                        ntotalbill = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[8].Value);
                        npayment = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[9].Value);
                        ndiscount = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[10].Value);
                        nwtax  = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[11].Value);
                        ////namount  = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[10].Value);
                        dgvPayment.CurrentRow.Cells[12].Value = 0;
                        dgvPayment.CurrentRow.Cells[13].Value = ntotalbill - npayment - ndiscount - nwtax; //  - namount;
                        //namount = nudTotal.Value;
                        namount -= Convert.ToDecimal(dgvPayment.CurrentRow.Cells[13].Value);
                        nudTotal.Value = Math.Abs(namount);
                        //nudamtdue.Value = nudTotal.Value + nudwtax.Value;
					}
                    scurrentrowtotal();
                    nudChange.Value = Math.Abs(nudTendered.Value - nudamtdue.Value);
                    if (Convert.ToDecimal(dgvPayment.CurrentRow.Cells[12].Value) <= 0)
                    {
                        dgvPayment.CurrentRow.Cells[1].Value = false;
                    }
                    scomputetotaldue();
                }
            }
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked ) { gbchkdtl.Visible = false ; }
        }

        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheck.Checked)
                {
                gbchkdtl.Visible = true ;
                tbCheckNo.Enabled = true ;
                dtpchkdate.Enabled = true ;
            }
        }

        private void rbOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOnline.Checked)
            {
                gbchkdtl.Visible = true;
                tbCheckNo.Enabled = false ;
                dtpchkdate.Enabled = true  ;
            }
        }

        private void btnPrintCollection_Click(object sender, EventArgs e)
        {

        }

        private void dgvPayment_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
                namt = Convert.ToDecimal(dgvPayment.CurrentRow.Cells [12].Value);
                dgvPayment.CurrentRow.Cells[12].Value = namt;

                sdgvrowtotal();
                scomputetotaldue();


            }
        }

        private void scomputetotaldue()
        {
            namt = 0;
            for (int i = 0;i < dgvPayment.Rows.Count;i++)
            {
                namt += Convert.ToDecimal(dgvPayment.Rows[i].Cells[12].Value);

            }
            nudTotal.Value = namt;
            nudamtdue.Value = namt - nudwtax.Value;
            nudChange.Value = nudamtdue.Value - nudTendered.Value;

        }
        private void scurrentrowtotal()
        {
            nbillamt = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[4].Value);
            nftax = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[5].Value);
            nwmf = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[6].Value);
            npenalty = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[7].Value);
            namount = nbillamt + nftax + nwmf + npenalty;
            npayment = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[9].Value);
            ndiscount = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[10].Value);
            nwtax = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[11].Value);
            namt = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[12].Value);
            nbalance = namount - npayment - ndiscount - nwtax - namt;
            dgvPayment.CurrentRow.Cells[13].Value = nbalance;
        }
        int counttrue()
        {
            var count = 0;
            for (int i = 0;i < dgvPayment.Rows.Count;i++)
            {
                if (Convert.ToBoolean(dgvPayment.Rows[i].Cells[1].Value) == true)
                {
                    count++;
                }
            }
            return count;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Date tmpdte = new Date();
        DateTime tmpdte;

        int yn;
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            
            

        }

        decimal notdisc = 0;
        decimal nwtax;
        private void sdisplaydetails()
        {
            nudTotal.Value = 0; nudChange.Value = 0;nudTendered.Value = 0;
            if (nain == 0)
            {
                ssql = "select * from reading_bc where mascode=@mc and (payment<=0 or payment is null or payment<billamt) and billperiod is not null and billperiod>='202409' order by billperiod";
            }
            else
            {
                ssql = "select * from reading_bc where mascode=@mc and (payment<=0 or payment is null or payment<billamt) and billperiod is not null order by billperiod";
            }
            
            DBConnect dbcon = new DBConnect();
            dbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable rs = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
            {
                cmd.Parameters.AddWithValue("@mc", tbmascode.Text);
                using (rs = new DataTable())
                {
                    
                    rs = dbcon.get_records(ssql, cmd);
                    if (rs.Rows.Count > 0)
                    {
                        dgvPayment.Rows.Clear();

                        foreach (DataRow dr in rs.Rows)
                        {
                            if (rs.Rows.Count < 2)
                            {
                                if (dr["billperiod"].ToString() == "202411")
                                {
                                    return;
                                }
                            }
                            dgvPayment.Rows.Add();
                            r = dgvPayment.Rows.Count - 1;
                            nftax = 0;nwmf = 0;npayment = 0;ndiscount = 0;npayment=0;nbalance = 0;nbillamt = 0;namount = 0; npenalty=0;
                            nwtax = 0;
                            if (dr["billamt"] != DBNull.Value)
                            {
                                nbillamt = Convert.ToDecimal(dr["billamt"]);
                            }

                            if (dr["ftax"] != DBNull.Value)
                            {
                                nftax  = Convert.ToDecimal(dr["ftax"]);
                            }
                            if (dr["wmf"] != DBNull.Value)
                            {
                                nwmf  = Convert.ToDecimal(dr["wmf"]);
                            }

                            if (dr["penalty"] != DBNull.Value)
                            {
                                npenalty = Convert.ToDecimal(dr["penalty"]);
                            }

                            if (dr["srdisc"] != DBNull.Value)
                            {
                                ndiscount = Convert.ToDecimal(dr["srdisc"]);
                            }
							if (dr["wtax"] != DBNull.Value)
							{
								notdisc = Convert.ToDecimal(dr["wtax"]);
							}

							if (dr["payment"] != DBNull.Value)
                            {
                                npayment = Convert.ToDecimal(dr["payment"]);
                            }
                            if (dr["wtax"] != DBNull.Value)
                            {
                                nwtax  = Convert.ToDecimal(dr["wtax"]);
                            }
                            var mydate = dr["billperiod"].ToString().Substring(0, 4) + "-" + dr["billperiod"].ToString().Substring(4, 2) + "-01";
                            tmpdte = Convert.ToDateTime(mydate, CultureInfo.InvariantCulture);
                            dgvPayment.Rows[r].Cells[2].Value = tmpdte.ToString("MMM-yyyy");
                            dgvPayment.Rows[r].Cells[3].Value = dr["cumused"];
                            dgvPayment.Rows[r].Cells[4].Value = nbillamt;
                            dgvPayment.Rows[r].Cells[5].Value = nftax;
                            dgvPayment.Rows[r].Cells[6].Value = nwmf;
                            dgvPayment.Rows[r].Cells[7].Value = npenalty;
                            namount = nbillamt + nftax + nwmf + npenalty;

                            dgvPayment.Rows[r].Cells[8].Value = namount;

                            dgvPayment.Rows[r].Cells[9].Value = npayment;
                            dgvPayment.Rows[r].Cells[10].Value = ndiscount;
							dgvPayment.Rows[r].Cells[11].Value = nwtax;
							dgvPayment.Rows[r].Cells[12].Value = 0;
                            nbalance = namount - npayment - ndiscount;
                            dgvPayment.Rows[r].Cells[13].Value = nbalance;
                            dgvPayment.Rows[r].Cells[15].Value = "1";
                            dgvPayment.Rows[r].Cells[16].Value = dr["billperiod"];
                            dgvPayment.Rows[r].Cells[17].Value = dr["present"];
							dgvPayment.Rows[r].Cells[19].Value = dr["duedate"];
						}
                    }
                    //add demand
                    if(rs.Rows.Count >= 2)
                    {
                        sdemand();
                    }
                }
            }
            dbcon.CloseConnection();
        }
        // deman
        void sdemand()
        {
            dgvPayment.Rows.Add();
            r = dgvPayment.Rows.Count - 1;
            dgvPayment.Rows[r].Cells[1].Value = true;
            dgvPayment.Rows[r].Cells[2].Value = DateTime.Now.ToString("MMM-yyyy");
            dgvPayment.Rows[r].Cells[3].Value = 0;
            dgvPayment.Rows[r].Cells[4].Value = 100;
            dgvPayment.Rows[r].Cells[5].Value = 0;
            dgvPayment.Rows[r].Cells[6].Value = 0;
            dgvPayment.Rows[r].Cells[7].Value = 0;
            dgvPayment.Rows[r].Cells[8].Value = 100;
            dgvPayment.Rows[r].Cells[9].Value = 0;
            dgvPayment.Rows[r].Cells[10].Value = 0;
            dgvPayment.Rows[r].Cells[12].Value = 100;
            dgvPayment.Rows[r].Cells[13].Value = 0;
            dgvPayment.Rows[r].Cells[14].Value = "Demand Fee";
            dgvPayment.Rows[r].Cells[15].Value = "62";
            dgvPayment.Rows[r].Cells[16].Value = DateTime.Now.ToString("yyyyMM");
            scomputetotal();
        }

        private void sdgvrowtotal()
        {
            nbillamt = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[4].Value);
            nftax = Convert.ToDecimal( dgvPayment.CurrentRow.Cells[5].Value);
            nwmf =  Convert.ToDecimal( dgvPayment.CurrentRow.Cells[6].Value);
            npenalty = Convert.ToDecimal( dgvPayment.CurrentRow.Cells[7].Value);
            namount = nbillamt + nftax + nwmf + npenalty;
            npayment = Convert.ToDecimal( dgvPayment.CurrentRow.Cells[9].Value);
            ndiscount = Convert.ToDecimal( dgvPayment.CurrentRow.Cells[10].Value);
            nwtax = Convert.ToDecimal( dgvPayment.CurrentRow.Cells[11].Value);
            namt = Convert.ToDecimal(dgvPayment.CurrentRow.Cells[12].Value);
            nbalance = namount - npayment - ndiscount - nwtax - namt;
            dgvPayment.CurrentRow.Cells[13].Value = nbalance;
        }

        private void tsbCollect_Click(object sender, EventArgs e)
        {
            btnConSearch.Enabled = true;
            gbConDtl.Enabled = true;
            if (tbOrNo.Text == string.Empty)
            {
                MessageBox.Show("Please enter the initial OR Number.");
                tbOrNo.Focus();
                return;
            }

			//check if collection date is already in the tellerlog
			ssql = "select * from bcdb.tellerlog where teller=@tel and cdate=@dt";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@tel", tbTeller.Text);
				cmd.Parameters.AddWithValue("@dt", dtpCollection.Value.ToString("yyyy-MM-dd"));
				using (rs = new DataTable())
				{
					rs = newdbcon.get_records(ssql, cmd);
                    if (rs.Rows.Count <= 0)
                    {
                        ssql = "insert into bcdb.tellerlog (teller,cdate,dtstarted,cstatus) values (@tel,@dt,@ds,@cs)";
                        using (MySqlCommand cmd1 = new MySqlCommand(ssql, newdbcon.database_connection))
                        {
                            cmd1.Parameters.AddWithValue("@tel", tbTeller.Text);
                            cmd1.Parameters.AddWithValue("@dt", dtpCollection.Value.ToString("yyyy-MM-dd"));
                            cmd1.Parameters.AddWithValue("@ds", DateTime.Now.ToString("HH:mm:ss tt"));
							cmd1.Parameters.AddWithValue("@cs", 0);
							cmd1.ExecuteNonQuery();
                            cmd1.Dispose();
                        }
                    }
                    else
                    {
                        foreach (DataRow dr in rs.Rows)
                        {
                            if (dr["dtclosed"] != DBNull.Value && dr["cstatus"].ToString() == "1")
                            {
                                MessageBox.Show("This Collection date has been closed.  Please select next date of collection.");
                                dtpCollection.Focus();
                                return;
							}
                        }
                    }
				}
                rs.Dispose();
			}
			newdbcon.CloseConnection();
		    Program.bp = dtpCollection.Value.ToString("yyyyMM");
            sdisplaycollection();
		}
        private void sloadbanks()
        {
            ssql = "SELECT * FROM bcdb.banks order by bankname";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            
            DataTable rs = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(ssql , newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (rs = new DataTable())
                {

                    rs = newdbcon.get_records(ssql , cmd);
                    if (rs.Rows.Count > 0)
                    {
                        cbBank.Items.Clear();
                        cbBank.DisplayMember = rs.Columns[1].ToString();
                        cbBank.ValueMember = rs.Columns[0].ToString();
                        cbBank.DataSource = rs.DefaultView;
                        

                    }
                    cmd.Dispose();
                }
            }
            newdbcon.CloseConnection();
        }
    }
}
