using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using bcsys.modules;
using DevExpress.CodeParser;
using DevExpress.DataAccess.Native.Sql.ConnectionProviders;
using DevExpress.XtraCharts;
using DevExpress.XtraScheduler.Drawing;
using Mirabeau.Sql;
using MySql.Data.MySqlClient;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace bcsys.Forms.EntryForms
{
    public partial class application : Form
    {
        public int retries;
        public string ssql;
        public string mcode;
        public application()
        {
            InitializeComponent();
        }

        private void application_Load(object sender, EventArgs e)
        {
            dgvP.Rows.Add();
            dgvP.Rows[0].Cells[0].Value = "Application Fee:";
            dgvP.Rows.Add();
            dgvP.Rows[1].Cells[0].Value = "Meter Deposit:";
            dgvP.Rows.Add();
            dgvP.Rows[2].Cells[0].Value = "Guarantee Deposit:";
            dgvP.Rows.Add();
            dgvP.Rows[3].Cells[0].Value = "Material Fee:";
            dgvP.Rows.Add();
            dgvP.Rows[4].Cells[0].Value = "Labor Fee:";
            dgvP.Rows.Add();
            dgvP.Rows[5].Cells[0].Value = "Other Fee:";
            this.Tag = "0";
            SLoadClassMeterType();
            this.Tag = "1";
            SLoadApplications();

        }
        public int r = 0;
        private void SLoadApplications()
        {
            string qry = "SELECT name,appno FROM bcdb.apptab order by appno desc";
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
                        dgvA.Rows.Clear();
                        foreach (DataRow rw in result.Rows)
                        {
                            dgvA.Rows.Add();
                            r = dgvA.RowCount - 1;
                            dgvA.Rows[r].Cells[0].Value = rw["name"].ToString();
                            dgvA.Rows[r].Cells[1].Value = rw["appno"].ToString();
                        }
                    }

                }
            }
            newdbcon.CloseConnection();
        }

        private void dgvP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            STotal();
        }

        decimal pamt = 0;
        decimal ptotal = 0;
        private void STotal()
        {
            ptotal = 0;
            for (int i = 0; i < dgvP.Rows.Count; i++)
            {
                pamt = Convert.ToDecimal(dgvP.Rows[i].Cells[1].Value);
                dgvP.Rows[i].Cells[1].Value = pamt;
                ptotal += pamt;
            }
            nudPay.Value = ptotal;
        }

        private void tbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbSearch.Text == "Search")
            {
                tbSearch.Focus();
                tbSearch.Text = string.Empty;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

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
                        foreach(DataRow rw in result.Rows)
                        {
                            cbZone.Items.Add(rw["zn"]);
                        }
                       
                    }
                   
                }
            }
            newdbcon.CloseConnection();
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


        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "1")
            {
                if (cbClass.SelectedIndex >=0)
                {
                    tbCMCode.Text = cbClass.SelectedValue.ToString() + cbMSize.SelectedValue.ToString();
                }
                
            }
            //


        }

        private void cbMSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "1")
            {
                if (cbMSize.SelectedIndex >=0)
                {
                    tbCMCode.Text = cbClass.SelectedValue.ToString() + cbMSize.SelectedValue.ToString();
                }
                
            }
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = "SELECT acc FROM bcdb.master where zn=@zn and bk=@bk order by acc desc limit 1";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {
                    cmd.Parameters.AddWithValue("@zn",cbZone.Text );
                    cmd.Parameters.AddWithValue("@bk",cbBook.Text );
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        foreach (DataRow row in result.Rows)
                        {
                            napno = Convert.ToInt32(row["acc"].ToString().Substring(0,3));
                            napno++;
                            tbAcc.Text = napno.ToString().PadLeft(3,'0') + "-0";
                        }
                        
                    }
                    else
                    {
                        tbAcc.Text = "001-0";
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
        private void dgvA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string qry = "SELECT * FROM bcdb.apptab where appno=@an";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {
                    cmd.Parameters.AddWithValue("@an", dgvA.CurrentRow.Cells[1].Value.ToString());
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        foreach (DataRow row in result.Rows)
                        {
                            tbAppNo.Text = row["appno"].ToString();
                            dtpApplied.Value = Convert.ToDateTime(row["dateapp"].ToString());
                            tbName.Text = row["name"].ToString();
                            tbAddress.Text = row["address"].ToString();
                            tbOrno.Text = row["or_no"].ToString();
                            tbContactNo.Text = row["telno"].ToString();
                            tbBgyCode.Text = row["bgycode"].ToString();
                            SGetBarangay(tbBgyCode.Text);
                            dtpOrDate.Value = Convert.ToDateTime(row["or_date"].ToString()) ;
                            dgvP.Rows[0].Cells[1].Value = Convert.ToDecimal(row["appfee"].ToString());
                            dgvP.Rows[1].Cells[1].Value = Convert.ToDecimal(row["mdep"].ToString());
                            dgvP.Rows[2].Cells[1].Value = Convert.ToDecimal(row["gdep"].ToString());
                            dgvP.Rows[3].Cells[1].Value = Convert.ToDecimal(row["mat"].ToString());
                            dgvP.Rows[4].Cells[1].Value = Convert.ToDecimal(row["labor"].ToString());
                            dgvP.Rows[5].Cells[1].Value = Convert.ToDecimal(row["others"].ToString());
                            STotal();
                            //get data from the master table
                            SGetfromMaster();
                        }
                    }
                    else
                    {
                        tbAcc.Text = "";
                    }

                }
            }
            newdbcon.CloseConnection();
        }
        private void SGetfromMaster()
        {
            string qry = "SELECT * FROM bcdb.master where appno=@an";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {
                    cmd.Parameters.AddWithValue("@an", tbAppNo.Text);
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count > 0)
                    {
                        foreach (DataRow row in result.Rows)
                        {
                            
                            tbBgyCode.Text = row["bgycode"].ToString();
                            SGetBarangay(tbBgyCode.Text);
                            cbZone.Text = row["zn"].ToString();
                            cbBook.Text = row["bk"].ToString();
                            cbClass.SelectedValue = row["classcode"].ToString();
                            cbMSize.SelectedValue = row["msize"].ToString();
                            tbInitReading.Text = row["m_irdg"].ToString();
                            tbAcc.Text = row["acc"].ToString();
                            cbRType.SelectedIndex =  Convert.ToInt16(row["ratetype"].ToString());
                            cbBrand.SelectedValue = row["m_brand"].ToString();
                            tbMeterNo.Text = row["m_no"].ToString();
                            dtpConnected.Value = Convert.ToDateTime(row["datecon"].ToString());
                            dtpActivated.Value = Convert.ToDateTime(row["activedate"].ToString());
                            dtpInstalled.Value = Convert.ToDateTime(row["datecon"].ToString());
                        }
                    }
                   
                }
            }
            newdbcon.CloseConnection();
        }

        public int napno;
        private void btnNew_Click(object sender, EventArgs e)
        {
            SInit();
            cbClass.SelectedIndex = -1; cbMSize.SelectedIndex = -1;
            string qry = "SELECT * FROM bcdb.apptab order by appno desc limit 1";
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
                        napno = 0;
                        foreach (DataRow row in result.Rows)
                        {
                            //MessageBox.Show(row["appno"].ToString());

                            napno = Convert.ToInt32(row["appno"].ToString().Substring(5));
                            napno++;
                            tbAppNo.Text = dtpApplied.Value.ToString("yy") + dtpApplied.Value.ToString("MM") + "-" + napno.ToString("D3");
                        }
                    }
                    
                }
            }
            newdbcon.CloseConnection();
            dtpApplied.Focus();

        }

        private void dtpApplied_KeyDown(object sender, KeyEventArgs e)
        {
            btnBrgySearch.Focus();
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbAddress.Focus();
            }
            

        }

        private void tbAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbContactNo.Focus();
            }
            
        }

        private void tbContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbOrno.Focus();
            }
          
        }

        private void tbOrno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvP.Focus();
                dgvP.CurrentCell = dgvP.Rows[0].Cells[1];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM bcdb.apptab where appno=@apn";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {
                    cmd.Parameters.AddWithValue("apn", tbAppNo.Text);
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count <= 0)
                    {
                        DBConnect ndbcon = new DBConnect(); ndbcon.OpenConnection(retries);
                        ssql = "insert into bcdb.apptab (appno,dateapp,name,address,telno,town,bgycode,or_no,or_date,appfee,mdep,gdep,mat,labor,others,status) " +
                            "values (@apn,@dta,@na,@add,@tel,@twn,@bc,@or,@od,@af,@md,@gd,@mat,@la,@oth,@st)";
                        using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                        {
                            cmd2.Parameters.AddWithValue("@apn",tbAppNo.Text);
                            cmd2.Parameters.AddWithValue("@dta", dtpApplied.Value.ToString("yyyy-MM-dd"));
                            cmd2.Parameters.AddWithValue("@na", tbName.Text);
                            cmd2.Parameters.AddWithValue("@add", tbAddress.Text);
                            cmd2.Parameters.AddWithValue("@tel", tbContactNo.Text);
                            cmd2.Parameters.AddWithValue("@twn", tbCity.Text);
                            cmd2.Parameters.AddWithValue("@bc", tbBgyCode.Text);
                            cmd2.Parameters.AddWithValue("@or", tbOrno.Text);
                            cmd2.Parameters.AddWithValue("@od", dtpOrDate.Value.ToString("yyyy-MM-dd"));
                            cmd2.Parameters.AddWithValue("@af", dgvP.Rows[0].Cells[1].Value);
                            cmd2.Parameters.AddWithValue("@md", dgvP.Rows[1].Cells[1].Value);
                            cmd2.Parameters.AddWithValue("@gd", dgvP.Rows[2].Cells[1].Value);
                            cmd2.Parameters.AddWithValue("@mat", dgvP.Rows[3].Cells[1].Value);
                            cmd2.Parameters.AddWithValue("@la", dgvP.Rows[4].Cells[1].Value);
                            cmd2.Parameters.AddWithValue("@oth", dgvP.Rows[5].Cells[1].Value);
                            cmd2.Parameters.AddWithValue("@st", "1");
                            cmd2.Prepare();
                            cmd2.ExecuteNonQuery();
                            cmd2.Dispose();
                        }
                        ndbcon.CloseConnection();
                        SLoadApplications();
                        SInit();
                    }
                }
            }
            newdbcon.CloseConnection();
        }
        private void SInit()
        {
            tbAppNo.Text = string.Empty;
            tbName.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbContactNo.Text = string.Empty;
            tbOrno.Text = string.Empty;
            for (int i = 0; i < 6; i++)
            {
                dgvP.Rows[i].Cells[1].Value = 0;
            }
        }

        private void cbSave_CheckedChanged(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM bcdb.master where appno=@apn";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);
            // newdbcon.mytable = "master.mastfile";
            DataTable result = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                //cmd.Parameters.AddWithValue("@bgy", tbBgyCode.Text);
                using (result = new DataTable())
                {
                    cmd.Parameters.AddWithValue("apn", tbAppNo.Text);
                    result = newdbcon.get_records(qry, cmd);
                    if (result.Rows.Count <= 0)
                    {
                        //get mascode - primary key of master table
                        ssql = "select * from master order by mascode desc limit 1";
                        DBConnect ndbcon = new DBConnect(); ndbcon.OpenConnection(retries);
                        DataTable dt = new DataTable();
                        using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                        {
                            using (dt = new DataTable())
                            {
                                dt = ndbcon.get_records(qry, cmd2);
                                if (dt.Rows.Count > 0)
                                {
                                    mcode = string.Empty;
                                    napno = 0;
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        napno = Convert.ToInt32(dr["mascode"].ToString());
                                        napno++;
                                        mcode = napno.ToString();
                                    }
                                }
                            }
                        }
                        ssql = "insert into bcdb.master (znacc12,m_date,datecon,acc,ratetype,m_brand,town,cust_stat,classcode,msize,mascode,zn,bk,bgycode,user1,name,address,appno,dateapp,m_no,ftax,m_irdg) " +
                            "values (@zna,@mdta,@dtc,@acc,@rt,@mb,@twn,@cst,@cc,@ms,@mc,@zn,@bk,@bgyc,@usr,@na,@add,@apn,@dtap,@m_no,@ftx,@ird)";
                        using (MySqlCommand cmd2 = new MySqlCommand(ssql, ndbcon.database_connection))
                        {
                            cmd2.Parameters.AddWithValue("@zna", cbZone.Text + cbBook.Text + tbAcc.Text);

                            cmd2.Parameters.AddWithValue("@mdta", dtpApplied.Value.ToString("yyyy-MM-dd"));
                            cmd2.Parameters.AddWithValue("@dtc", dtpConnected.Value.ToString("yyyy-MM-dd"));
                            cmd2.Parameters.AddWithValue("@acc", tbAcc.Text);
                            cmd2.Parameters.AddWithValue("@rt", cbRType.SelectedIndex);
                            cmd2.Parameters.AddWithValue("@mb", cbBrand.SelectedValue);
                            cmd2.Parameters.AddWithValue("@twn", tbCity.Text);
                            cmd2.Parameters.AddWithValue("@cst", "1");
                            cmd2.Parameters.AddWithValue("@cc", cbClass.SelectedValue);
                            cmd2.Parameters.AddWithValue("@ms", cbMSize.SelectedValue);

                            cmd2.Parameters.AddWithValue("@mc", mcode);
                            cmd2.Parameters.AddWithValue("@zn", cbZone.Text);
                            cmd2.Parameters.AddWithValue("@bk", cbBook.Text);
                            cmd2.Parameters.AddWithValue("@bgyc", tbBgyCode.Text);
                            cmd2.Parameters.AddWithValue("@usr", Program.usr);
                            cmd2.Parameters.AddWithValue("@na", tbName.Text);
                            cmd2.Parameters.AddWithValue("@add", tbAddress.Text);
                            cmd2.Parameters.AddWithValue("@apn", tbAppNo.Text);
                            cmd2.Parameters.AddWithValue("@dtap", dtpApplied.Value.ToString("yyyy-MM-dd"));

                            cmd2.Parameters.AddWithValue("@m_no", tbMeterNo.Text);
                            cmd2.Parameters.AddWithValue("@ftax", 6.44);
                            cmd2.Parameters.AddWithValue("@ird", tbInitReading.Text);
                            cmd2.Prepare();
                            cmd2.ExecuteNonQuery();
                            cmd2.Dispose();
                        }
                        ndbcon.CloseConnection();
                    }
                }
            }
            newdbcon.CloseConnection();
        }

		private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
