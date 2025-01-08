using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
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
using System.Drawing;
using bcsys.Properties;
using DevExpress.XtraRichEdit.Import.Doc;
using DevExpress.Utils.About;
using Mirabeau.Sql;
using DevExpress.DashboardCommon.Viewer;
using DevExpress.ExpressApp;
using DevExpress.XtraExport.Helpers;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts;
using System.Collections.Generic;
using System.Linq;


namespace bcsys.Forms.EntryForms
{
    public partial class consumer : Form
    {
        int retries = 0;
        private DateTimePicker cellDateTimePicker;
        private List<int> dateColumnsIndexes;
        private string ssql;
        public consumer()
        {
            InitializeComponent();
        }

        private void consumer_Load(object sender, EventArgs e)
        {
                        
            this.cellDateTimePicker = new DateTimePicker();
            //this.cellDateTimePicker.ValueChanged += new EventHandler(CellValueChangedEventArgs);
            this.cellDateTimePicker.Visible = false;
            this.cellDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.cellDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.dgvM.Controls.Add(cellDateTimePicker);

            dateColumnsIndexes = new List<int>();
            //dgvM.DataSource = controller.getEmptyDataTable();     // DataTable provided by excel reader
            var l = dgvM.Columns.Count;
            string[] dateColumns = { "Reading", "Installed" };
            for (var i = 0; i < l; ++i)
            {
                if (dateColumns.Any(dgvM.Columns[i].HeaderText.Contains))
                {
                    dateColumnsIndexes.Add(i);
                }
            }

            string qry = "select name,znacc12,mascode FROM bcdb.master order by name";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            // newdbcon.mytable = "master.mastfile";
            DataTable result5 = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                using (result5 = new DataTable())
                {
                    result5 = newdbcon.get_records(qry, cmd);
                    if (result5.Rows.Count > 0)
                    {
                        dgvConsumer.Columns.Clear();
                        dgvConsumer.DataSource = result5;
                    }
                }
            }
            newdbcon.CloseConnection();
            SFormatDgv();
            this.Tag = "0";
            SLoadClassMeterType();
            cbClass.SelectedIndex = -1;
            cbMSize.SelectedIndex = -1;
            cbBrand.SelectedIndex = -1;

            this.Tag = "1";
            
        }
        private void tbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbSearch.Text == "Search")
            {
                tbSearch.Focus();
                tbSearch.Text = string.Empty;

            }
        }
        private void SFormatDgv()
        {
            dgvConsumer.Columns[0].Width = 250;
            dgvConsumer.Columns[0].HeaderText = "Consumer Name";
            dgvConsumer.Columns[1].HeaderText = "Account";
            dgvConsumer.Columns[1].Width = 60;
            dgvConsumer.Columns[2].Visible = false;
        }
        private void btnConSearch_Click(object sender, EventArgs e)
        {
            Form search = new consearch();
            search.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void SLoadClassMeterType()
        {
            string qry = "SELECT * FROM bcdb.classification order by classcode";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {

                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        cbClass.Items.Clear();
                        cbClass.DisplayMember = result.Columns[1].ToString();
                        cbClass.ValueMember = result.Columns[0].ToString();
                        cbClass.DataSource = result.DefaultView;
                        //foreach (DataRow rw in result.Rows)
                        //{
                        //    //cbClass.Items.Add(rw["classification"], rw["classcode"]);
                        //    //cbClass.Items.Add()

                        //}

                    }

                }
            }
            newdbcon.CloseConnection();
            qry = "SELECT * FROM bcdb.metersize order by code";
            newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        cbMSize.Items.Clear();
                        cbMSize.DisplayMember = result.Columns[1].ToString();
                        cbMSize.ValueMember = result.Columns[0].ToString();
                        cbMSize.DataSource = result.DefaultView;
                        //foreach (DataRow rw in result.Rows)
                        //{
                        //    //cbClass.Items.Add(rw["classification"], rw["classcode"]);
                        //    //cbClass.Items.Add()

                        //}

                    }

                }
            }
            newdbcon.CloseConnection();
            //load meter

            qry = "SELECT brand,code FROM bcdb.meters order by code";
            newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        cbBrand.Items.Clear();
                        cbBrand.DisplayMember = result.Columns[0].ToString();
                        cbBrand.ValueMember = result.Columns[1].ToString();
                        cbBrand.DataSource = result.DefaultView;
                    }
                }
            }
            newdbcon.CloseConnection();
        }
        int sindex = -1;
        //private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        //{
           
        //        if (e.KeyCode == Keys.Enter)
        //        {

        //            for (int i = 0; i <= dgvConsumer.Rows.Count - 1; i++)
        //            {
        //                string sname = dgvConsumer.Rows[i].Cells[0].Value.ToString().ToUpper();
        //                string tname = tbSearch.Text.ToUpper();
        //                if (sname.Length > 0 && sname.Length >= tname.Length)
        //                {
        //                    string tsearch = sname.Substring(0, tname.Length).ToUpper();
        //                    if (tsearch == tname)
        //                    {
        //                    dgvConsumer.CurrentCell = dgvConsumer.Rows[i].Cells[1];
        //                        break;
        //                    }

        //                }

        //            }
        //        }
            
        //}

        private void dgvConsumer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string qry = "select * FROM bcdb.master where znacc12=@zn order by name";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);

            // newdbcon.mytable = "master.mastfile";
            DataTable result5 = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                using (result5 = new DataTable())
                {
                    cmd.Parameters.AddWithValue("zn", dgvConsumer.CurrentRow.Cells[1].Value);
                    result5 = newdbcon.get_records(qry, cmd);
                    if (result5.Rows.Count > 0)
                    {
                        foreach (DataRow rw in result5.Rows)
                        { 
                            
                            tbConCode.Text = rw["znacc12"].ToString();
                            tbMasCode.Text = rw["mascode"].ToString();
                            tbBgyCode.Text = rw["bgycode"].ToString();
                            SGetBarangay(tbBgyCode.Text);
                            //tbBrgy .Text = rw["barangay"].ToString();
                            SPopCombos();
                            tbName.Text = rw["name"].ToString();
                            tbAddress.Text = rw["address"].ToString();
                            cbClass.SelectedValue = rw["classcode"].ToString();
                            cbMSize.SelectedValue = rw["msize"].ToString();
                            cbZone.Text  = rw["zn"].ToString();
                            cbBook.Text = rw["bk"].ToString();
                            tbAcc.Text = rw["acc"].ToString();
                            tbCMCode.Text = rw["classcode"].ToString() + rw["msize"].ToString();
                            tbContactNo.Text = rw["telno"].ToString().Trim();
                            cbBrand.SelectedValue = rw["m_brand"].ToString();
                            cbRType.SelectedIndex = Convert.ToInt32(rw["ratetype"].ToString());
                            tbMeterNo.Text = rw["m_no"].ToString();
                            tbInitReading.Text = rw["m_irdg"].ToString();
                            if (rw["datecon"] != DBNull.Value )
                            {
                                dtpConnected.Value = Convert.ToDateTime(rw["datecon"].ToString());
                            }
                            if (rw["datediscon"] != DBNull.Value)
                            {
                                dtpConnected.Value = Convert.ToDateTime(rw["datediscon"].ToString());
                            }
                            //dtpDiscon.Value = Convert.ToDateTime(rw["datediscon"].ToString());
                            if (rw["activedate"] != DBNull.Value)
                            {
                                dtpConnected.Value = Convert.ToDateTime(rw["activedate"].ToString());
                            }
                            //dtpactive.Value = Convert.ToDateTime(rw["activedate"].ToString());
                            if (rw["daterec"] != DBNull.Value)
                            {
                                dtpConnected.Value = Convert.ToDateTime(rw["daterec"].ToString());
                            }
                            if (rw["cust_stat"] != DBNull.Value)
                            {
                                if (rw["cust_stat"].ToString() == "0")
                                {
                                    cbstatus.Checked = true;
                                }
                                else
                                {
                                    cbstatus.Checked = false;
                                }
                            }
                            else
                            {
                                cbstatus.Checked = false;
                            }
                            //dtpRecon.Value = Convert.ToDateTime(rw["daterec"].ToString());







                        }
                    }
                }
            }
            newdbcon.CloseConnection();
        }
        private void SPopCombos()
        {
            string qry = "SELECT * FROM bcdb.bgyzn where bgycode=@bgy order by bgycode";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {

                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        cbZone.Items.Clear();
                        foreach (DataRow rw in result.Rows)
                        {
                            cbZone.Items.Add(rw["zn"]);
                        }

                    }

                }
            }
            newdbcon.CloseConnection();
        }
        private void SGetBarangay(string bgy)
        {
            string qry = "SELECT * FROM bcdb.barangay where code=@b";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {
                    cmd.Parameters.AddWithValue("@b", tbBgyCode.Text);
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        foreach (DataRow row in result.Rows)
                        {
                            tbBrgy.Text = row["name"].ToString();
                        }
                    }
                }
            }
            newdbcon.CloseConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM bcdb.master where mascode=@mc";
            DBConnect ndbcon = new DBConnect();
            ndbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, ndbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {
                    cmd.Parameters.AddWithValue("mc", tbMasCode.Text);
                    result = ndbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        ssql = "update bcdb.master set ratetype=@rt,m_brand=@mb,classcode=@cc,msize=@ms,acctno=@act,bgycode=@bgyc,accno=@acn,user1=@usr,name=@na,address=@add,m_no=@mn,cust_stat=@cs where mascode=@mc";
                        using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                        {
                            cmd2.Parameters.AddWithValue("@mc", tbMasCode.Text);
                            cmd2.Parameters.AddWithValue("@rt", cbRType.SelectedIndex);
                            cmd2.Parameters.AddWithValue("@mb", cbBrand.SelectedValue);
                            cmd2.Parameters.AddWithValue("@cc", cbClass.SelectedValue);
                            cmd2.Parameters.AddWithValue("@ms", cbMSize.SelectedValue);
                            cmd2.Parameters.AddWithValue("@bgyc", tbBgyCode.Text);
                            cmd2.Parameters.AddWithValue("@acn", cbZone.Text + cbBook.Text + "-" +
                                tbCMCode.Text  + "-" + tbAcc.Text);
                            cmd2.Parameters.AddWithValue("@act", cbZone.Text + cbBook.Text + "-" +
                                tbCMCode.Text  + "-" + tbAcc.Text);
                            cmd2.Parameters.AddWithValue("@usr", Program.usr);
                            cmd2.Parameters.AddWithValue("@na", tbName.Text);
                            cmd2.Parameters.AddWithValue("@add", tbAddress.Text);
                            cmd2.Parameters.AddWithValue("@mn", tbMeterNo.Text);
                            if (cbstatus.Checked)
                            {
                                cmd2.Parameters.AddWithValue("@cs", "0");
                            }
                            else { cmd2.Parameters.AddWithValue("@cs", "1"); }

                            cmd2.Prepare();
                            cmd2.ExecuteNonQuery();
                            cmd2.Dispose();
                        }
                    }
                }
            }
            ndbcon.CloseConnection();
        }

        private void btnBrgySearch_Click(object sender, EventArgs e)
        {
            Form brgy = new libsearch();
            brgy.Text = "Barangay Search";
			changeIcon.SetApplicationIcon(Application.StartupPath + @"\24x24.ico", brgy);
			brgy.ShowDialog();
			tbBrgy.Text = Program.brgyname;
			tbBgyCode.Text = Program.brycode;
			cbZone.Text = "";
			cbZone.Items.Clear();
			//cbBook.Items.Clear();
			SPopCombos();
			tbName.Focus();
		}

        private void button1_Click(object sender, EventArgs e)
        {

        }

		private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

        int nloc;
        string sss;
        //private void tbSearch_KeyDown_1(object sender, KeyEventArgs e)
        //{
        //    //if (e.KeyCode == Keys.Enter)
        //    //{
        //    //    for (int i = 0; i <= dgvConsumer.RowCount - 1; i++)
        //    //    {
        //    //        sss = dgvConsumer.Rows[i].Cells[0].Value.ToString().ToUpper();
        //    //        nloc = sss.IndexOf(tbSearch.Text.ToUpper(), 0);
        //    //        if (nloc > 0)
        //    //        {
        //    //            if (sss.Substring(0,tbSearch.Text.Length).ToUpper() == tbSearch.Text.ToUpper())
        //    //            {
        //    //                dgvConsumer.CurrentCell = dgvConsumer.Rows[i].Cells[0];
        //    //            }
                        
        //    //        }
        //    //        //if (tbSearch .Text == dgvConsumer.Rows[i].Cells[0].Value.ToString())
        //    //        //{
                        
        //    //        //}
        //    //    }
        //    //}
        //}

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i <= dgvConsumer.Rows.Count - 1; i++)
                {
                    string sname = dgvConsumer.Rows[i].Cells[0].Value.ToString().ToUpper();
                    string tname = tbSearch.Text.ToUpper();
                    if (sname.Length > 0 && sname.Length >= tname.Length)
                    {
                        string tsearch = sname.Substring(0, tname.Length).ToUpper();
                        if (tsearch == tname)
                        {
                            dgvConsumer.CurrentCell = dgvConsumer.Rows[i].Cells[1];
                            break;
                        }

                    }

                }
            }


        }
    }
}
