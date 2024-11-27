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
using DevExpress.Utils.Serializing;
using DevExpress.XtraCharts;
using MySql.Data.MySqlClient;

namespace bcsys.Forms.EntryForms
{
   
    public partial class libsearch : Form
    {
        public int retries;
        public libsearch()
        {
            InitializeComponent();
        }

        private void libsearch_Load(object sender, EventArgs e)
        {
            string qry = "SELECT name,code FROM bcdb.barangay order by name";
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
                        dgv.Columns.Clear();
                        dgv.DataSource = result;
                    }
                    SFormat();
                }
            }
            newdbcon.CloseConnection();
        }
        private void SFormat()
        {
            dgv.Columns[0].HeaderText = "Barangay";
            dgv.Columns[0].Width = 200;
            dgv.Columns[1].HeaderText = "Code";
            dgv.Columns[1].Width = 80;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tsbSelect_Click(object sender, EventArgs e)
        {
            Program.brycode = dgv.CurrentRow.Cells[1].Value.ToString();
            Program.brgyname  = dgv.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
