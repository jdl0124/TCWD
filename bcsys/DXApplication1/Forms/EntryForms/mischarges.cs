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
using MySql.Data.MySqlClient;

namespace bcsys.Forms.EntryForms
{
    public partial class mischarges : Form
    {
        int retries, r;

        public mischarges()
        {
            InitializeComponent();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void tsbSelect_Click(object sender, EventArgs e)
        {
            tbDesc.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            nudRate.Value = Convert.ToDecimal(dgv.CurrentRow.Cells[2].Value);
            tbttype.Text = dgv.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelect_Click(1,e);

        }

        private void btnAddCharges_Click(object sender, EventArgs e)
        {
            Program.acct = dgv.CurrentRow.Cells[0].Value.ToString();
            Program.desc0 = dgv.CurrentRow.Cells[1].Value.ToString();
            Program.rate = Convert.ToDecimal(nudRate.Value);
            Program.ttype = dgv.CurrentRow.Cells[3].Value.ToString();
            Program.nmisamount = nudRate.Value;
            this.Close();

        }

        private void mischarges_Load(object sender, EventArgs e)
        {
            string qry = "select * FROM bcdb.mischarges order by pkno";
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
                        dgv.Rows.Clear();
                        foreach (DataRow dr in dtb.Rows)
                        {
                            dgv.Rows.Add();
                            r = dgv.Rows.Count - 1;
                            dgv.Rows[r].Cells[0].Value = dr["acct"];
                            dgv.Rows[r].Cells[1].Value = dr["desc0"];
                            dgv.Rows[r].Cells[2].Value = Convert.ToDecimal(dr["rate"]);
                            dgv.Rows[r].Cells[3].Value = dr["ttype"];
                        }

                    }
                }
            }
            newdbcon.CloseConnection();
        }
    }
}
