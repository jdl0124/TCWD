using System;
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
using DevExpress.XtraEditors.DXErrorProvider;
using MySql.Data.MySqlClient;

namespace bcsys.Forms.EntryForms
{
    public partial class ledger_old : Form
    {
        public int retries;
        public string ssql;
        public string mcode;
        public decimal nbill = 0;
        public decimal nbillf = 0;
        public decimal nbillc = 0;
        public decimal nftax = 0;
        public decimal ncurr = 0;
        public ledger_old()
        {
            InitializeComponent();
        }

        private void ledger_old_Load(object sender, EventArgs e)
        {
            string qry = "select name,znacc12,mascode,address FROM bcdb.master order by name";
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
            dgvConsumer.Columns[0].Width = 250;
            dgvConsumer.Columns[0].HeaderText = "Consumer Name";
            dgvConsumer.Columns[1].HeaderText = "Account";
            dgvConsumer.Columns[1].Width = 60;
            dgvConsumer.Columns[2].Visible = false;
            dgvConsumer.Columns[3].Visible = false;
        }

        private void dgvConsumer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbAddress.Text = dgvConsumer.CurrentRow.Cells[3].Value.ToString();
            tbMasCode.Text = dgvConsumer.CurrentRow.Cells[2].Value.ToString();
            tbName.Text = dgvConsumer.CurrentRow.Cells[0].Value.ToString();
            tbConCode.Text = dgvConsumer.CurrentRow.Cells[1].Value.ToString();
            sDisplayLedger();
        }

        int r = 0;
        private void sDisplayLedger()
        {
            string qry = "select * FROM bcdb.ledger_bc where mascode=@mc and billperiod>='202301' order by code";
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
                            nbill = 0;
                            nbillf = 0; nbillc = 0;
                            dgvLDtl.Rows.Add();
                            r = dgvLDtl.RowCount - 1;
                            dgvLDtl.Rows[r].Cells[0].Value = Convert.ToDateTime(rw["refdate"].ToString());
                            if (rw["ltype"].ToString() == "0")
                            {
                                if (rw["reading"].ToString() == "794")
                                {
                                    r = dgvLDtl.RowCount - 1;
                                }
                                dgvLDtl.Rows[r].Cells[1].Value = Convert.ToDateTime(rw["datedue"].ToString());
                                dgvLDtl.Rows[r].Cells[2].Value = "Billing " + rw["rem"].ToString();
                                dgvLDtl.Rows[r].Cells[3].Value = rw["reading"].ToString();
                                dgvLDtl.Rows[r].Cells[4].Value = rw["cumused"].ToString();
                                nftax = 0;
                                ncurr = 0;
                                if (rw["ftax"] != System.DBNull.Value)
                                {
                                    if (Convert.ToDecimal(rw["ftax"].ToString()) > 0)
                                    {
                                        nftax = Convert.ToDecimal(rw["ftax"].ToString());
                                        nbillf = Convert.ToDecimal(rw["bill_amt"].ToString()) - Convert.ToDecimal(rw["ftax"].ToString());
                                        //dgvLDtl.Rows[r].Cells[5].Value = rw["bill_amt"].ToString();
                                    }
                                }
                                if (rw["curr"].ToString() != null)
                                {
                                    if (Convert.ToDecimal(rw["curr"].ToString()) != 0)
                                    {
                                        ncurr = Convert.ToDecimal(rw["curr"].ToString());
                                        nbillc = Convert.ToDecimal(rw["bill_amt"].ToString()) - Convert.ToDecimal(rw["curr"].ToString());

                                    }
                                }

                                dgvLDtl.Rows[r].Cells[5].Value = nbillf; //Convert.ToDecimal(rw["bill_amt"]);
                                dgvLDtl.Rows[r].Cells[7].Value = Convert.ToDecimal(rw["balance"]) - nftax - ncurr;

                                if (rw["ftax"] != System.DBNull.Value)
                                {
                                    if (Convert.ToDecimal(rw["ftax"].ToString()) != 0)
                                    {
                                        dgvLDtl.Rows.Add();
                                        r = dgvLDtl.RowCount - 1;
                                        dgvLDtl.Rows[r].Cells[0].Value = Convert.ToDateTime(rw["refdate"].ToString());
                                        dgvLDtl.Rows[r].Cells[1].Value = Convert.ToDateTime(rw["datedue"].ToString());
                                        dgvLDtl.Rows[r].Cells[2].Value = "Francise Tax";
                                        dgvLDtl.Rows[r].Cells[5].Value = Convert.ToDecimal(rw["ftax"].ToString());
                                        nbill = Convert.ToDecimal(rw["balance"]) - Convert.ToDecimal(rw["curr"].ToString());
                                        //nbill = nbillf + Convert.ToDecimal(rw["ftax"].ToString());
                                        dgvLDtl.Rows[r].Cells[7].Value = nbill;
                                        dgvLDtl.Rows[r].Cells[8].Value = rw["user1"].ToString();
                                        dgvLDtl.Rows[r].Cells[9].Value = rw["entered"].ToString();
                                    }
                                }
                                if (rw["curr"].ToString() != null)
                                {
                                    if (Convert.ToDecimal(rw["curr"].ToString()) != 0)
                                    {
                                        dgvLDtl.Rows.Add();
                                        r = dgvLDtl.RowCount - 1;
                                        dgvLDtl.Rows[r].Cells[0].Value = Convert.ToDateTime(rw["refdate"].ToString());
                                        dgvLDtl.Rows[r].Cells[1].Value = Convert.ToDateTime(rw["datedue"].ToString());
                                        dgvLDtl.Rows[r].Cells[2].Value = "WMF";
                                        dgvLDtl.Rows[r].Cells[5].Value = Convert.ToDecimal(rw["curr"].ToString());
                                        nbill = Convert.ToDecimal(rw["balance"]);
                                        //nbill = nbill + Convert.ToDecimal(rw["curr"].ToString());
                                        dgvLDtl.Rows[r].Cells[7].Value = nbill;
                                        dgvLDtl.Rows[r].Cells[8].Value = rw["user1"].ToString();
                                        dgvLDtl.Rows[r].Cells[9].Value = rw["entered"].ToString();
                                    }
                                }
                             

                            }
                            else
                            {
                                if (rw["ltype"].ToString() == "3")
                                {
                                    dgvLDtl.Rows[r].Cells[2].Value = "Penalty " + rw["rem"].ToString();
                                }
                                else if (rw["ltype"].ToString() == "14")
                                {
                                    dgvLDtl.Rows[r].Cells[2].Value = "Payment " + rw["rem"].ToString();
                                }
                                else
                                {
                                    dgvLDtl.Rows[r].Cells[2].Value = "Others " + rw["rem"].ToString();
                                }
                                dgvLDtl.Rows[r].Cells[5].Value = rw["bill_amt"].ToString();
                                dgvLDtl.Rows[r].Cells[6].Value = rw["pay"].ToString();
                                dgvLDtl.Rows[r].Cells[7].Value = rw["balance"].ToString();
                                dgvLDtl.Rows[r].Cells[8].Value = rw["user1"].ToString();
                                dgvLDtl.Rows[r].Cells[9].Value = rw["entered"].ToString();
                            }
                        }
                    }
                }
            }
            newdbcon.CloseConnection();
        }

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
    }

}
