﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcsys.modules;
using DevExpress.CodeParser;
using MySql.Data.MySqlClient;

namespace bcsys.Forms.EntryForms
{
    public partial class reading : Form
    {
        int retries;
        private DateTimePicker cellDateTimePicker;
        private List<int> dateColumnsIndexes;
        private string ssql;
        public bool bnewb = false;
        public decimal namt = 0;
        public DataTable dtbrates;
        public reading()
        {
            InitializeComponent();
        }

        private void reading_Load(object sender, EventArgs e)
        {
            string qry = "select zone,book,lbp,rday FROM bcdb.zonebk order by zone,book";
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
                        dgvBrgy.Columns.Clear();
                        dgvBrgy.DataSource = dtb;
                    }
                    SFormatDgv();
                }
            }
            dtbrates = new DataTable();
            ssql = "select * from bcdb.rates order by code";
            using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
            {
                using (dtbrates = new DataTable())
                {
                    dtbrates = newdbcon.get_records(ssql, cmd);
                    if (dtb.Rows.Count > 0)
                    {
                    
                    }
                }
            }
            newdbcon.CloseConnection();
        }
        private void SFormatDgv()
        {
            dgvBrgy.Columns[0].Width = 50;
            dgvBrgy.Columns[0].HeaderText = "Zone";
            dgvBrgy.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBrgy.Columns[1].HeaderText = "Book";
            dgvBrgy.Columns[1].Width = 45;
            dgvBrgy.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBrgy.Columns[2].Width = 60;
            dgvBrgy.Columns[2].HeaderText = "lastBP";
            dgvBrgy.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBrgy.Columns[3].Width = 50;
            dgvBrgy.Columns[3].HeaderText = "RdgDate";
            dgvBrgy.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        decimal dtotbill = 0;
        private void dgvBrgy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvReading.Rows.Clear();
            string qry = "select a.znacc12,a.name,a.m_no,b.name as brgy,a.mascode,c.*,a.classcode,a.msize FROM bcdb.master a " +
                         "left join bcdb.barangay b on b.`code`=a.bgycode " +
                         "left join bcdb.reading_bc c on c.mascode=a.mascode " +
                         "where a.zn=@zn and a.bk=@bk and a.cust_stat='1' and c.billperiod=@bp and c.ttype='0' order by a.name";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            // newdbcon.mytable = "master.mastfile";
            DataTable dtb = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                string bp = dtpBP.Value.ToString("yyyyMM");
                cmd.Parameters.AddWithValue("@zn", dgvBrgy.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@bk", dgvBrgy.CurrentRow.Cells[1].Value);
                cmd.Parameters.AddWithValue("@bp", bp);
                using (dtb = new DataTable())
                {
                    dtb = newdbcon.get_records(qry, cmd);
                    if (dtb.Rows.Count > 0)
                    {
                        btnCreate.Visible = false;
                        dgvReading.Rows.Clear();
                        int n = 1;int r = 0;    
                        foreach(DataRow dr in dtb.Rows)
                        {
                            dtotbill = 0;
                            dgvReading.Rows.Add();
                            r = dgvReading.RowCount - 1;
                            dgvReading.Rows[r].Cells[0].Value = n;
                            n++;
                            dgvReading.Rows[r].Cells[17].Value = dr["mascode"].ToString();
                            dgvReading.Rows[r].Cells[1].Value = dr["znacc12"].ToString();
                            dgvReading.Rows[r].Cells[2].Value = dr["name"].ToString();
                            dgvReading.Rows[r].Cells[3].Value = dr["brgy"].ToString();
                            dgvReading.Rows[r].Cells[4].Value = dr["m_no"].ToString();
                            dgvReading.Rows[r].Cells[5].Value = dr["previous"].ToString();
                            dgvReading.Rows[r].Cells[6].Value = dr["present"].ToString();
                            dgvReading.Rows[r].Cells[7].Value = Convert.ToInt32(dr["cumused"].ToString());
                            dgvReading.Rows[r].Cells[8].Value = Convert.ToDecimal(dr["billamt"].ToString());
                            namt = 0;
                            dtotbill += Convert.ToDecimal(dr["billamt"].ToString());

							if (dr["ftax"] != DBNull.Value)
                            {
                                namt = Convert.ToDecimal(dr["ftax"]);
                                dtotbill += namt;
                            }
                            dgvReading.Rows[r].Cells[9].Value = namt;

                            namt = 0;
                            if (dr["wmf"] != DBNull.Value)
                            {
                                namt = Convert.ToDecimal(dr["wmf"]);
								dtotbill += namt;
							}
                            dgvReading.Rows[r].Cells[10].Value = namt;

                            namt = 0;
                            if (dr["penalty"] != DBNull.Value)
                            {
                                namt = Convert.ToDecimal(dr["penalty"]);
								dtotbill += namt;
							}
							dgvReading.Rows[r].Cells[11].Value = namt;
                            namt = 0;
                            if (dr["discount"] != DBNull.Value)
                            {
                                namt = Convert.ToDecimal(dr["discount"]);
								dtotbill -= namt;

							}
							dgvReading.Rows[r].Cells[12].Value = namt;

                            namt = 0;
                            if (dr["totbillamt"] != DBNull.Value)
                            {
                                namt = Convert.ToDecimal(dr["totbillamt"]);
                            }

                            dgvReading.Rows[r].Cells[13].Value = dtotbill;

                            namt = 0;
                            if (dr["payment"] != DBNull.Value)
                            {
                                namt = Convert.ToDecimal(dr["payment"]);
                            }

                            dgvReading.Rows[r].Cells[14].Value = namt;
                            dgvReading.Rows[r].Cells[15].Value = Convert.ToDecimal(dr["classcode"].ToString());
                            dgvReading.Rows[r].Cells[18].Value = Convert.ToDecimal(dr["msize"].ToString());

                            //get last reading and cumused from ledger_bc
                            //ssql = "select * FROM bcdb.ledger_bc where mascode=@mc and ltype='0' order by code desc limit 1";
                            //DBConnect ndbcon = new DBConnect();
                            //ndbcon.OpenConnection(retries);

                            //// newdbcon.mytable = "master.mastfile";
                            //DataTable dtbr = new DataTable();
                            //using (MySqlCommand cmd1 = new MySqlCommand(ssql , newdbcon.database_connection))
                            //{
                            //    using (dtbr = new DataTable())
                            //    {
                            //        cmd1.Parameters.AddWithValue("@mc", dr["mascode"]);
                            //        dtbr = newdbcon.get_records(ssql, cmd1);
                            //        if (dtbr.Rows.Count > 0)
                            //        {
                            //            foreach (DataRow drw in dtbr.Rows)
                            //            {
                            //                dgvReading.Rows[r].Cells[6].Value = drw["reading"].ToString();
                            //            }
                            //        }
                            //    }
                            //}
                            //ndbcon.CloseConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Billing for the period of " + dtpBP.Text + " for Zone " + dgvBrgy.CurrentRow.Cells[0].Value + " is not yet initialized!");
                        btnCreate.Visible = true;
                        btnCreate.Focus();
                    }
                }
            }
            newdbcon.CloseConnection();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bnewb = true;
            dgvReading.Rows.Clear();
            //check if previous bp readings are complete
            ssql = "select sum(present) as present,sum(previous) as previous from bcdb.reading_bc where zn=@zn and bk=@bk and billperiod=@bp";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            // newdbcon.mytable = "master.mastfile";
            DataTable dtb = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
            {
                cmd.Parameters.AddWithValue("@zn", dgvBrgy.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@bk", dgvBrgy.CurrentRow.Cells[1].Value);
                cmd.Parameters.AddWithValue("@bp", dtpBP.Value.AddMonths(-1).ToString("yyyyMM"));
                using (dtb = new DataTable())
                {
                    dtb = newdbcon.get_records(ssql, cmd);
                    if (dtb.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dtb.Rows)
                        {
                            if (Convert.ToInt32(rw["present"]) < Convert.ToInt32(rw["previous"]))
                            {
                                MessageBox.Show("Present reading is incomplete for Zone=" + dgvBrgy.CurrentRow.Cells[0].Value + " Book " + dgvBrgy.CurrentRow.Cells[1].Value + " for the previous Billing Period." );
                                //present reading of the previous billperiod is incomplete
                                bnewb=false;
                            }
                           
                        }

                    }
                    else
                    {
                        bnewb =!false;
                        //billing for this period was not initialized yet
                        MessageBox.Show("Billing for Zone=" + dgvBrgy.CurrentRow.Cells[0].Value + " Book " + dgvBrgy.CurrentRow.Cells[1].Value + " for the previous Billing Period was not initialize yet.");
                    }
                }
            }

            if (bnewb)
            {
                string qry = "select a.znacc12,a.name,a.m_no,b.name as brgy,a.mascode,m_prdg FROM bcdb.master a " +
                         "left join bcdb.barangay b on b.`code`=a.bgycode " +
                         "where a.zn=@zn and a.bk=@bk and a.cust_stat='0' order by a.name";
                using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
                {
                    cmd.Parameters.AddWithValue("@zn", dgvBrgy.CurrentRow.Cells[0].Value);
                    cmd.Parameters.AddWithValue("@bk", dgvBrgy.CurrentRow.Cells[1].Value);
                    using (dtb = new DataTable())
                    {
                        dtb = newdbcon.get_records(qry, cmd);
                        if (dtb.Rows.Count > 0)
                        {
                            dgvReading.Rows.Clear();
                            int n = 1; int r = 0;
                            foreach (DataRow dr in dtb.Rows)
                            {
                                dgvReading.Rows.Add();
                                r = dgvReading.RowCount - 1;
                                dgvReading.Rows[r].Cells[0].Value = n;
                                n++;
                                dgvReading.Rows[r].Cells[1].Value = dr["znacc12"].ToString();
                                dgvReading.Rows[r].Cells[2].Value = dr["name"].ToString();
                                dgvReading.Rows[r].Cells[3].Value = dr["brgy"].ToString();
                                dgvReading.Rows[r].Cells[4].Value = dr["m_no"].ToString();
                                dgvReading.Rows[r].Cells[5].Value = dr["m_prdg"].ToString();
                                dgvReading.Rows[r].Cells[6].Value = 0;
                                dgvReading.Rows[r].Cells[7].Value = 0;
                                dgvReading.Rows[r].Cells[8].Value = 0;
                                dgvReading.Rows[r].Cells[11].Value = dr["mascode"].ToString();
                            }

                        }

                    }
                }
                newdbcon.CloseConnection();
            }
        }

        private void btnSaveBilling_Click(object sender, EventArgs e)
        {
            if (bnewb) //new billing
            {
                for (int i = 0;i <= dgvReading.Rows.Count - 1;i++)
                {
                    string qry = "select * from bcdb.reading_bc where mascode=@mc and billperiod=@bp";
                    DBConnect newdbcon = new DBConnect();
                    newdbcon.OpenConnection(retries);
                    // newdbcon.mytable = "master.mastfile";
                    DataTable dtb = new DataTable();
                    using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
                    {
                        cmd.Parameters.AddWithValue("@mc", dgvReading.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@bp", dtpBP.Value.ToString("yyyyMM"));
                        using (dtb = new DataTable())
                        {
                            dtb = newdbcon.get_records(qry, cmd);
                            if (dtb.Rows.Count == 0)
                            {
                                ssql = "insert into bcdb.reading_bc (mascode,zn,bk,meterno,billperiod,previous,present,cumused,billamt,payment,ttype,refdate,duedate,startdate,enddate,usr,seqno) " +
                                    "values(@mc,@zn,@bk,@mn,@bp,@pv,@pr,@cu,@ba,@pay,@tt,@rdt,@ddt,@sdt,@edt,@usr,@sq)";
                                using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
                                {
                                    cmd2.Parameters.AddWithValue("@mc", dgvReading.Rows[i].Cells[11].Value);
                                    cmd2.Parameters.AddWithValue("@zn", dgvBrgy.CurrentRow.Cells[0].Value);
                                    cmd2.Parameters.AddWithValue("@bk", dgvBrgy.CurrentRow.Cells[1].Value);
                                    cmd2.Parameters.AddWithValue("@mn", dgvReading.Rows[i].Cells[4].Value);
                                    cmd2.Parameters.AddWithValue("@bp", dtpBP.Value.ToString("yyyyMM"));
                                    cmd2.Parameters.AddWithValue("@pv", dgvReading.Rows[i].Cells[5].Value);
                                    cmd2.Parameters.AddWithValue("@pr", dgvReading.Rows[i].Cells[6].Value);
                                    cmd2.Parameters.AddWithValue("@cu", dgvReading.Rows[i].Cells[7].Value);
                                    cmd2.Parameters.AddWithValue("@ba", dgvReading.Rows[i].Cells[8].Value);
                                    cmd2.Parameters.AddWithValue("@pay", Convert.ToDecimal(dgvReading.Rows[i].Cells[9].Value));
                                    cmd2.Parameters.AddWithValue("@tt", "0");
                                    cmd2.Parameters.AddWithValue("@rdt", dtpBP.Value.ToString("yyyy-MM-dd"));
                                    cmd2.Parameters.AddWithValue("@ddt", dtpBP.Value.AddDays(10).ToString("yyyy-MM-dd"));
                                    cmd2.Parameters.AddWithValue("@sdt", dtpStart.Value.ToString("yyyy-MM-dd"));
                                    cmd2.Parameters.AddWithValue("@edt", dtpEnd.Value.ToString("yyyy-MM-dd"));
                                    cmd2.Parameters.AddWithValue("@usr", Program.usr);
                                    cmd2.Parameters.AddWithValue("@sq", dgvReading.Rows[i].Cells[0].Value);
                                    cmd2.Prepare();
                                    cmd2.ExecuteNonQuery();
                                    cmd2.Dispose();
                                }
                            }
                        }
                    }
                    //save last bp to zonebk table
                    ssql = "update bcdb.zonebk set lbp=@bp where zone=@zn and book=@bk";
                    using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
                    {
                        cmd2.Parameters.AddWithValue("@zn", dgvBrgy.CurrentRow.Cells[0].Value);
                        cmd2.Parameters.AddWithValue("@bk", dgvBrgy.CurrentRow.Cells[0].Value);
                        cmd2.Parameters.AddWithValue("@bp", dtpBP.Value.ToString("yyyyMM"));
                        cmd2.Prepare();
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();
                    }
                    newdbcon.CloseConnection();
                    bnewb = false;
                }
            }
        }
        private int cused, nmincmused,n1120,n2130,n30over,nxcess;

		private void dgvBrgy_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private decimal nbillamt, nmin, nexcess,nminamt,n1120amt,n2130amt,n30overamt, nftax, nwmf, ntotbill;
        private void dgvReading_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                
                cused = 0;nmincmused = 0;n1120 = 0;n2130 = 0;n30over = 0; nxcess = 0;
                cused =  Convert.ToInt32(dgvReading.CurrentRow.Cells[6].Value) - Convert.ToInt32(dgvReading.CurrentRow.Cells[5].Value);

                if (cused >= 0) 
                {
                    nbillamt = 0; nmin = 0; nminamt = 0 ; nexcess = 0;nmincmused = 0;nftax = 0;nwmf = 0;ntotbill = 0;
                    n1120amt = 0;n2130amt = 0;n30overamt = 0;
                    string codeValue = dgvReading.CurrentRow.Cells[15].Value.ToString();
                    string msizeValue = dgvReading.CurrentRow.Cells[18].Value.ToString();
                    DataRow[] dr = dtbrates.Select($"code = '{codeValue}' AND msize = '{msizeValue}'");
                    //DataRow[] dr = dtbrates.Select("code='" + dgvReading.CurrentRow.Cells[15].Value.ToString() + "' AND " + "msize='" + dgvReading.CurrentRow.Cells[18].Value.ToString() + "'");
                    //MessageBox.Show(dr[0]["code"].ToString());
                    nmin = Convert.ToInt32(dr[0]["min"]);
                    if (cused >= nmin)
                    {
                        //1st 10
                        nminamt = Convert.ToDecimal(dr[0]["minrate"]);
                        nxcess = cused - Convert.ToInt32(nmin);
                        if (nxcess >= nmin)
                        {
                            //2nd 10
                            n1120amt = nmin * Convert.ToDecimal(dr[0]["rate1120"]);
                            nxcess = nxcess - Convert.ToInt32(nmin);
                            if (nxcess >= nmin)
                            {
                                //3rd 10
                                n2130amt = nmin * Convert.ToDecimal(dr[0]["rate2130"]);
                                nxcess = nxcess - Convert.ToInt32(nmin);
                                if(nxcess >= 1)
                                {
                                    n30overamt = nxcess * Convert.ToDecimal(dr[0]["rate30up"]);
                                }
                            }
                            else
                            {
                                n2130amt = nxcess * Convert.ToDecimal(dr[0]["rate2130"]);
                            }
                        }
                        else
                        {
                            n1120amt = nxcess * Convert.ToDecimal(dr[0]["rate1120"]);
                        }
                    }
                    else
                    {
                        nminamt = cused * Convert.ToDecimal(dr[0]["minrate"]);
                    }
                    nbillamt = nminamt + n1120amt + n2130amt + n30overamt;

                    dgvReading.CurrentRow.Cells[7].Value = cused;
                    dgvReading.CurrentRow.Cells[8].Value = nbillamt;
                    nftax = Math.Round(nbillamt * Convert.ToDecimal(dr[0]["ftax"]),2,MidpointRounding.AwayFromZero);
                    nwmf = Convert.ToDecimal(dr[0]["wmf"]);
                    dgvReading.CurrentRow.Cells[9].Value = nftax;
                    dgvReading.CurrentRow.Cells[10].Value = nwmf;
                    ntotbill = nbillamt + nftax + nwmf;
                    dgvReading.CurrentRow.Cells[13].Value = ntotbill;

                    DBConnect newdbcon = new DBConnect();
                    newdbcon.OpenConnection(retries);
                    // newdbcon.mytable = "master.mastfile";
                    ssql = "update bcdb.reading_bc set present=@pr,cumused=@cu,billamt=@ba,ftax=@fx,wmf=@w,totbillamt=@tb where mascode=@mc and billperiod=@bp";
                    using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
                    {
                        cmd2.Parameters.AddWithValue("@mc", dgvReading.CurrentRow.Cells[17].Value);
                        cmd2.Parameters.AddWithValue("@bp", dtpBP.Value.ToString("yyyyMM"));
                        cmd2.Parameters.AddWithValue("@pr", dgvReading.CurrentRow.Cells[6].Value);
                        cmd2.Parameters.AddWithValue("@cu", dgvReading.CurrentRow.Cells[7].Value);
                        cmd2.Parameters.AddWithValue("@ba", dgvReading.CurrentRow.Cells[8].Value);
                        cmd2.Parameters.AddWithValue("@fx", dgvReading.CurrentRow.Cells[9].Value);
                        cmd2.Parameters.AddWithValue("@w", dgvReading.CurrentRow.Cells[10].Value);
                        cmd2.Parameters.AddWithValue("@tb", dgvReading.CurrentRow.Cells[13].Value);
                        cmd2.Prepare();
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();
                    }
                    ssql = "update bcdb.master set m_prdg=@pr where mascode=@mc";
                    using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
                    {
                        cmd2.Parameters.AddWithValue("@mc", dgvReading.CurrentRow.Cells[17].Value);
                        cmd2.Parameters.AddWithValue("@pr", dgvReading.CurrentRow.Cells[6].Value);
                        cmd2.Prepare();
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();
                    }
                    newdbcon.CloseConnection();
                    //save to master.m_prdg = present reading

                }
            }
        }

        private void dgvReading_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            ssql = "update bcdb.reading_bc set refdate=@rdt,duedate=@ddt,startdate=@sdt,enddate=@edt where billperiod=@bp and zn=@zn and bk=@bk";
            using (MySqlCommand cmd2 = new MySqlCommand(ssql, newdbcon.database_connection))
            {
                cmd2.Parameters.AddWithValue("@bp", dtpBP.Value.ToString("yyyyMM"));
                cmd2.Parameters.AddWithValue("@zn", dgvBrgy.CurrentRow.Cells[0].Value);
                cmd2.Parameters.AddWithValue("@bk", dgvBrgy.CurrentRow.Cells[1].Value);
                cmd2.Parameters.AddWithValue("@rdt", dtpBP.Value.ToString("yyyy-MM-dd"));
                cmd2.Parameters.AddWithValue("@ddt", dtpBP.Value.AddDays(10).ToString("yyyy-MM-dd"));
                cmd2.Parameters.AddWithValue("@sdt", dtpStart.Value.ToString("yyyy-MM-dd"));
                cmd2.Parameters.AddWithValue("@edt", dtpEnd.Value.ToString("yyyy-MM-dd"));
                cmd2.Prepare();
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
            }
            newdbcon.CloseConnection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}