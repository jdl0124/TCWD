using bcsys.modules;
using DevExpress.XtraRichEdit.Import.Doc;
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
    public partial class summaryReports : Form
    {
        int retries;
        string ssql,bp;


        public summaryReports()
        {
            InitializeComponent();
        }

		private void summaryreports_Load(object sender, EventArgs e)
		{
			

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			bp = dtpBP.Value.ToString("yyyyMM");
			ssql = "select a.name, count(c.mascode) as Total,sum(c.cumused) as cumused, " +
				"sum(c.billamt) as billamt,sum(c.payment) as payment " +
				"from bcdb.barangay a, bcdb.master b, bcdb.reading_bc c where a.code=b.bgycode and b.mascode=c.mascode and c.billperiod=@bp and c.ttype='0' group by a.name order by name";
			DBConnect newdbcon = new DBConnect();
			newdbcon.OpenConnection(retries);
			DataTable dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@bp", bp);
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count > 0)
					{
						rmvbilling.Columns.Clear();
						rmvbilling.DataSource = dtb;
					}

					cmd.Dispose();
					dtb.Dispose();
				}
			}

			ssql = "select a.name, count(c.mascode) as Total,sum(c.cumused) as cumused, " +
				"sum(c.billamt) as billamt,sum(c.payment) as payment " +
				"from bcdb.barangay a, bcdb.master b, bcdb.reading_bc c where a.code=b.bgycode and b.mascode=c.mascode and c.billperiod=@bp and c.ttype='0' group by a.name order by name";
			newdbcon = new DBConnect();
			dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				cmd.Parameters.AddWithValue("@bp", bp);
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count > 0)
					{
						rmvbilling.Columns.Clear();
						rmvbilling.DataSource = dtb;
					}

					cmd.Dispose();
					dtb.Dispose();
				}
			}





			ssql = "select a.name, count(b.mascode) as total, " +
				"count(case when b.classcode='10' then b.mascode end) as res," +
				"count(case when b.classcode='20' then b.mascode end) as gov, " +
				"count(case when b.classcode='30' then b.mascode end) as comm, " +
				"count(case when b.classcode='31' then b.mascode end) as comm_a, " +
				"count(case when b.classcode='32' then b.mascode end) as comm_b, " +
				"count(case when b.classcode='33' then b.mascode end) as comm_c from bcdb.barangay a, bcdb.master b where a.code=b.bgycode group by a.name";
			//DBConnect newdbcon = new DBConnect();
			//newdbcon.OpenConnection(retries);

			// newdbcon.mytable = "master.mastfile";
			dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count > 0)
					{
						rmv.Columns.Clear();
						rmv.DataSource = dtb;
					}

					cmd.Dispose();
					dtb.Dispose();
				}
			}
			ssql = "select a.name, count(case when b.cust_stat='0' then b.mascode end) as total, " +
				"count(case when b.classcode='10' and b.cust_stat='0' then b.mascode end) as res," +
				"count(case when b.classcode='20' and b.cust_stat='0' then b.mascode end) as gov, " +
				"count(case when b.classcode='30' and b.cust_stat='0' then b.mascode end) as comm, " +
				"count(case when b.classcode='31' and b.cust_stat='0' then b.mascode end) as comm_a, " +
				"count(case when b.classcode='32' and b.cust_stat='0' then b.mascode end) as comm_b, " +
				"count(case when b.classcode='33' and b.cust_stat='0' then b.mascode end) as comm_c from bcdb.barangay a, bcdb.master b where a.code=b.bgycode group by a.name";
			//newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count > 0)
					{
						rmvactive.Columns.Clear();
						rmvactive.DataSource = dtb;
					}
					cmd.Dispose();
					dtb.Dispose();
				}
			}
			ssql = "select a.name, count(case when b.cust_stat='1' then b.mascode end) as total, " +
				"count(case when b.classcode='10' and b.cust_stat='1' then b.mascode end) as res," +
				"count(case when b.classcode='20' and b.cust_stat='1' then b.mascode end) as gov, " +
				"count(case when b.classcode='30' and b.cust_stat='1' then b.mascode end) as comm, " +
				"count(case when b.classcode='31' and b.cust_stat='1' then b.mascode end) as comm_a, " +
				"count(case when b.classcode='32' and b.cust_stat='1' then b.mascode end) as comm_b, " +
				"count(case when b.classcode='33' and b.cust_stat='1' then b.mascode end) as comm_c from bcdb.barangay a, bcdb.master b where a.code=b.bgycode group by a.name";
			//newdbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			dtb = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, newdbcon.database_connection))
			{
				using (dtb = new DataTable())
				{
					dtb = newdbcon.get_records(ssql, cmd);
					if (dtb.Rows.Count > 0)
					{
						rmvinactive.Columns.Clear();
						rmvinactive.DataSource = dtb;
					}
					cmd.Dispose();
					dtb.Dispose();
				}
			}
			sformat();
			newdbcon.CloseConnection();
		}

		private void sformat()
		{
			rmv.Columns[0].Width = 150;
			rmv.Columns[0].HeaderText = "Barangay";
			rmv.Columns[1].HeaderText = "Total";
			rmv.Columns[2].HeaderText = "Res";
			rmv.Columns[3].HeaderText = "Gov't";
			rmv.Columns[4].HeaderText = "Comm";
			rmv.Columns[5].HeaderText = "Comm-A";
			rmv.Columns[6].HeaderText = "Comm-B";
			rmv.Columns[7].HeaderText = "Comm-C";
			for (int i = 1; i < rmv.Columns.Count; i++)
			{
				rmv.Columns[i].Width = 60;
				rmv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				rmv.Columns[i].DefaultCellStyle.Format = "N0";
			}

			rmvactive.Columns[0].Width = 150;
			rmvactive.Columns[0].HeaderText = "Barangay";
			rmvactive.Columns[1].HeaderText = "Total";
			rmvactive.Columns[2].HeaderText = "Res";
			rmvactive.Columns[3].HeaderText = "Gov't";
			rmvactive.Columns[4].HeaderText = "Comm";
			rmvactive.Columns[5].HeaderText = "Comm-A";
			rmvactive.Columns[6].HeaderText = "Comm-B";
			rmvactive.Columns[7].HeaderText = "Comm-C";
			for (int i = 1; i < rmvactive.Columns.Count; i++)
			{
				rmvactive.Columns[i].Width = 60;
				rmvactive.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				rmvactive.Columns[i].DefaultCellStyle.Format = "N0";
			}

			rmvinactive.Columns[0].Width = 150;
			rmvinactive.Columns[0].HeaderText = "Barangay";
			rmvinactive.Columns[1].HeaderText = "Total";
			rmvinactive.Columns[2].HeaderText = "Res";
			rmvinactive.Columns[3].HeaderText = "Gov't";
			rmvinactive.Columns[4].HeaderText = "Comm";
			rmvinactive.Columns[5].HeaderText = "Comm-A";
			rmvinactive.Columns[6].HeaderText = "Comm-B";
			rmvinactive.Columns[7].HeaderText = "Comm-C";
			for (int i = 1; i < rmvinactive.Columns.Count; i++)
			{
				rmvinactive.Columns[i].Width = 60;
				rmvinactive.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				rmvinactive.Columns[i].DefaultCellStyle.Format = "N0";
			}

		}

	}
}
