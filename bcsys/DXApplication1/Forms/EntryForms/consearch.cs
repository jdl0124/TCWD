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
using DevExpress.XtraCharts;
using MySql.Data.MySqlClient;

namespace bcsys.Forms.EntryForms
{
    public partial class consearch : Form
    {
        int retries = 1;
        public consearch()
        {
            InitializeComponent();
        }

        private void consearch_Load(object sender, EventArgs e)
        {
            string qry;

            if (this.Text == "Reconnection")
            {
                qry = "SELECT a.name,a.accno,b.name as bgyname,a.zn,a.bk,a.mascode,a.cust_stat FROM bcdb.master a, barangay b where a.bgycode=b.code and a.cust_stat='1' order by name";
            }
            else
            {
				qry = "SELECT a.name,a.accno,b.name as bgyname,a.zn,a.bk,a.mascode,a.cust_stat FROM bcdb.master a, barangay b where a.bgycode=b.code order by name";
			}
            
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
                        sformatdgv();
                    }
                }
            }
            newdbcon.CloseConnection();
        }

        private void sformatdgv()
        {
            dgvConsumer.Columns[0].HeaderText = "Consumer Name";
            dgvConsumer.Columns[0].Width = 250;
            dgvConsumer.Columns[1].HeaderText = "AcctNo.";
            dgvConsumer.Columns[1].Width = 80;
            dgvConsumer.Columns[2].HeaderText = "Barangay";
            dgvConsumer.Columns[2].Width = 150;
            dgvConsumer.Columns[3].HeaderText = "Zone";
            dgvConsumer.Columns[3].Width = 50;
            dgvConsumer.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvConsumer.Columns[4].HeaderText = "Book";
			dgvConsumer.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvConsumer.Columns[4].Width = 50;
            dgvConsumer.Columns[5].Visible = false;
			dgvConsumer.Columns[6].Visible = false;

		}
        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tsbSelect_Click(object sender, EventArgs e)
        {
            Program.smascode = dgvConsumer.CurrentRow.Cells[5].Value.ToString();
            Program.zna = dgvConsumer.CurrentRow.Cells[1].Value.ToString();
            Program.accno = dgvConsumer.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void dgvConsumer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvConsumer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelect_Click(1, e);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string qry = "SELECT a.name,a.accno,b.name as bgyname,a.zn,a.bk,a.mascode,a.cust_stat FROM bcdb.master a, barangay b where (a.name like '%" + tbSearch.Text + "%' or a.acctno like '%" + tbSearch.Text + "%') and a.bgycode=b.code order by name";
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
                        sformatdgv();
                    }
                }
            }
            newdbcon.CloseConnection();
        }

		private void dgvConsumer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			foreach (DataGridViewRow row in dgvConsumer.Rows)
			{
                if (row.Cells[6].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
		}
	}
}
