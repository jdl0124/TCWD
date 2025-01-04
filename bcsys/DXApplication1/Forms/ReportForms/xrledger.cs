using bcsys.Forms.EntryForms;
using bcsys.modules;
using CrystalDecisions.Shared.Json;
using DevExpress.Data.Mask.Internal;
using DevExpress.XtraBars.Navigation.Accessible;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
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

namespace bcsys.Forms
{
	public partial class xrledger : DevExpress.XtraEditors.XtraForm
	{
        public int retries;
        public string ssql;
        public string mcode;
        public decimal nbill = 0;
        public decimal nbillf = 0;
        public decimal nbillc = 0;
        public decimal nftax = 0;
        public decimal ncurr = 0;
        public xrledger()
		{
			InitializeComponent();
		}

        private void xrledger_Load(object sender, EventArgs e)
        {
            string qry = "select name,accno,mascode,address FROM bcdb.master order by name";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                using (result = new DataTable())
                {
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        dgvConsumer.Columns.Clear();
                        dgvConsumer.DataSource = result;
                    }
                }
            }
            newdbcon.CloseConnection();
            SFormatDgv();
        }
        private void SFormatDgv()
        {
            dgvConsumer.Columns[0].Width = 230;
            dgvConsumer.Columns[0].HeaderText = "Consumer Name";
            dgvConsumer.Columns[1].HeaderText = "Account";
            dgvConsumer.Columns[1].Width = 80;
            dgvConsumer.Columns[2].Visible = false;
            dgvConsumer.Columns[3].Visible = false;
        }

        private void dgvConsumer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        int r = 0;
        string sbp;
        public decimal npenalty, nsrdisc, nwmf, nwtax,npay, nbillamt;
        private void sDisplayLedger()
        {
            string qry = "select * FROM bcdb.reading_bc where mascode=@mc and billperiod>='202301' order by billperiod";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                using (result = new DataTable())
                {
                    cmd.Parameters.AddWithValue("@mc", tbMasCode.Text);
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        dgvLDtl.Rows.Clear();
                        foreach (DataRow rw in result.Rows)
                        {
                            nbill = 0; npay = 0;
                            nbillf = 0; nbillc = 0; nwmf = 0; nwtax = 0;
                            nftax = 0; npenalty = 0; nsrdisc = 0;nbillamt = 0;
                            if (rw["ftax"] != DBNull.Value)
                            {
                                nftax = Convert.ToDecimal(rw["ftax"]);
                            }
                            if (rw["penalty"] != DBNull.Value)
                            {
                                npenalty = Convert.ToDecimal(rw["penalty"]);
                            }
                            if (rw["srdisc"] != DBNull.Value)
                            {
                                nsrdisc = Convert.ToDecimal(rw["srdisc"]);
                            }
                            if (rw["wmf"] != DBNull.Value)
                            {
                                nwmf = Convert.ToDecimal(rw["wmf"]);
                            }
                            if (rw["payment"] != DBNull.Value)
                            {
                                npay = Convert.ToDecimal(rw["payment"]);
                            }
                            if (rw["billamt"] != DBNull.Value)
                            {
                                nbillamt  = Convert.ToDecimal(rw["billamt"]);
                            }
                            nbill = nbillamt  + nftax + nwmf +
                                npenalty - nsrdisc - nwtax;
                            dgvLDtl.Rows.Add();
                            r = dgvLDtl.RowCount - 1;

                            dgvLDtl.Rows[r].Cells[0].Value = rw["refdate"];
                            dgvLDtl.Rows[r].Cells[1].Value = rw["duedate"];
                            sbp = rw["billperiod"].ToString().Substring(0, 4) + "-" + rw["billperiod"].ToString().Substring(4, 2) + "-01";

                            dgvLDtl.Rows[r].Cells[2].Value = "Bill for " + Convert.ToDateTime(sbp).ToString("MMMM-yyyy");
                            dgvLDtl.Rows[r].Cells[3].Value = rw["present"];
                            dgvLDtl.Rows[r].Cells[4].Value = rw["cumused"];
                            dgvLDtl.Rows[r].Cells[5].Value = nbill;
                            dgvLDtl.Rows[r].Cells[6].Value = rw["payment"];
                            nbillc = nbill - npay;

                            dgvLDtl.Rows[r].Cells[7].Value = nbillc;
                            dgvLDtl.Rows[r].Cells[8].Value = rw["usr"];

                        }
                    }
                    npay = 0;
                    nbill = 0;
                    if (dgvLDtl.Rows[0].Cells[5].Value  != null )
                    {
                        nbill = Convert.ToDecimal( dgvLDtl.Rows[0].Cells[5].Value);
                    }
                    if (dgvLDtl.Rows[0].Cells[6].Value != null && dgvLDtl.Rows[0].Cells[6].Value != DBNull.Value)
                    {
                        npay = Convert.ToDecimal(dgvLDtl.Rows[0].Cells[6].Value);
                    }

                    npay = nbill - npay;
                    dgvLDtl.Rows[0].Cells[7].Value = npay;
                    for (int i = 1; i < dgvLDtl.Rows.Count; i++)
                    {
                        nbillc = 0;
                        nbill = 0;
                        if (dgvLDtl.Rows[i].Cells[5].Value != null)
                        {
                            nbill = Convert.ToDecimal(dgvLDtl.Rows[i].Cells[5].Value);
                        }
                        if (dgvLDtl.Rows[i].Cells[6].Value != null && dgvLDtl.Rows[i].Cells[6].Value != DBNull.Value )
                        {
                            nbillc = Convert.ToDecimal(dgvLDtl.Rows[i].Cells[6].Value);
                        }
                        nbal = nbill - nbillc + npay;

                        //npay = nbal;
                        dgvLDtl.Rows[i].Cells[7].Value = nbal  ;
                        npay = nbal;
                        nbal = 0;
                    }
                    
                    
                }
            }
            newdbcon.CloseConnection();

        }
        public decimal nbal;
        private void button1_Click(object sender, EventArgs e)
        {
            ssql = "update bcdb.ledger_bc set billperiod=@bp";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
            {
                using (result = new DataTable())
                {

                }
            }
            newdbcon.CloseConnection();
        }

        private void dgvConsumer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsumer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbAddress.Text = dgvConsumer.CurrentRow.Cells[3].Value.ToString();
            tbMasCode.Text = dgvConsumer.CurrentRow.Cells[2].Value.ToString();
            tbName.Text = dgvConsumer.CurrentRow.Cells[0].Value.ToString();
            tbConCode.Text = dgvConsumer.CurrentRow.Cells[1].Value.ToString();
            sDisplayLedger();

            
        }
    }
}