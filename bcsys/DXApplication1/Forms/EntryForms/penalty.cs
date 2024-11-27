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
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraCharts;
using MySql.Data.MySqlClient;
using PriorityTextToSpeech.modules;

namespace bcsys.Forms.EntryForms
{
    public partial class penalty : Form
    {
        int retries;
        string ssql;
        decimal npenalty;

        public penalty()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

		private void btnGo_Click(object sender, EventArgs e)
		{
			ssql = "select b.znacc12,b.name,b.m_no,a.billperiod,a.duedate,a.previous,a.present,a.cumused,a.billamt,a.billamt*.1 as penalty,b.mascode from bcdb.reading_bc a,bcdb.master b where a.mascode=b.mascode and billamt>0 and a.duedate<@dd and (a.penalty=0 or a.penalty is null) order by b.name";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			// newdbcon.mytable = "master.mastfile";
			DataTable rs = new DataTable();
			using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
			{
				//cmd.Parameters.AddWithValue("@dd", DateTime.Now.ToString("yyyy-MM-dd"));
				cmd.Parameters.AddWithValue("@dd", dtpPDate.Value.ToString("yyyy-MM-dd"));
				using (rs = new DataTable())
				{
					rs = dbcon.get_records(ssql, cmd);
					if (rs.Rows.Count > 0)
					{
						dgvP.Columns.Clear();
						dgvP.DataSource = rs;
						sdgvpformat();
						btnPost.Enabled = true;
					}
					else
					{
						btnPost.Enabled = false;
					}

				}
			}
		}

		private void sdgvpformat()
		{
			dgvP.Columns[0].Width = 60;
			dgvP.Columns[0].HeaderText = "AcctNo";
			dgvP.Columns[1].Width = 250;
			dgvP.Columns[1].HeaderText = "AcctNo";
			dgvP.Columns[2].Width = 80;
			dgvP.Columns[2].HeaderText = "MeterNo";
			dgvP.Columns[3].Width = 57;
			dgvP.Columns[3].HeaderText = "BPeriod";
			dgvP.Columns[4].Width = 70;
			dgvP.Columns[4].HeaderText = "DueDate";
			dgvP.Columns[5].Width = 50;
			dgvP.Columns[5].HeaderText = "Previous";
			dgvP.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvP.Columns[6].Width = 50;
			dgvP.Columns[6].HeaderText = "Present";
			dgvP.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvP.Columns[7].Width = 45;
			dgvP.Columns[7].HeaderText = "CuMUsed";
			dgvP.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvP.Columns[8].Width = 70;
			dgvP.Columns[8].HeaderText = "BillAmount";
			dgvP.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvP.Columns[8].DefaultCellStyle.Format = "N2";
			dgvP.Columns[9].Width = 70;
			dgvP.Columns[9].HeaderText = "Penalty";
			dgvP.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvP.Columns[9].DefaultCellStyle.Format = "N2";
			dgvP.Columns[10].Visible = false;

		}
		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (dgvP.Rows.Count - 1 > 0)
			{
				ssql = "select * from bcdb.reading_bc where duedate<@dd and billamt>0 and (penalty=0 or penalty is null)";
				DBConnect dbcon = new DBConnect();
				dbcon.OpenConnection(retries);
				// newdbcon.mytable = "master.mastfile";
				DataTable rs = new DataTable();
				using (MySqlCommand cmd = new MySqlCommand(ssql, dbcon.database_connection))
				{
					//cmd.Parameters.AddWithValue("@dd", DateTime.Now.ToString("yyyy-MM-dd"));
					cmd.Parameters.AddWithValue("@dd", dtpPDate.Value.ToString("yyyy-MM-dd"));
					using (rs = new DataTable())
					{
						rs = dbcon.get_records(ssql, cmd);
						if (rs.Rows.Count > 0)
						{
							pb1.Visible = true;
							int c = 0;
							pb1.Maximum = rs.Rows.Count;
							foreach (DataRow dr in rs.Rows)
							{
								ssql = "update bcdb.reading_bc set penalty=@pen where mascode=@mc and billperiod=@bp";
								npenalty = 0;
								if (dr["billamt"] != DBNull.Value)
								{
									npenalty = Convert.ToDecimal(dr["billamt"]) * .1m;
									using (MySqlCommand cmd2 = new MySqlCommand(ssql, dbcon.database_connection))
									{
										cmd2.Parameters.AddWithValue("@pen", npenalty);
										cmd2.Parameters.AddWithValue("@mc", dr["mascode"]);
										cmd2.Parameters.AddWithValue("@bp", dr["billperiod"]);
										cmd2.Prepare();
										cmd2.ExecuteNonQuery();
										cmd2.Dispose();
									}
									ssql = "insert into bcdb.penalty (hdate,mascode,acctno,billperiod,amount,payment,user) " +
										"values(@hdt,@mc,@acn,@bp,@amt,@pay,@usr)";
									using (MySqlCommand cmd2 = new MySqlCommand(ssql, dbcon.database_connection))
									{
										cmd2.Parameters.AddWithValue("@hdt", DateTime.Now.ToString("yyyy-MM-dd"));
										cmd2.Parameters.AddWithValue("@mc", dr["mascode"]);
										cmd2.Parameters.AddWithValue("@acn", dr["znbkacc"]);
										cmd2.Parameters.AddWithValue("@bp", dr["billperiod"]);
										cmd2.Parameters.AddWithValue("@amt", npenalty);
										cmd2.Parameters.AddWithValue("@pay", 0);
										cmd2.Parameters.AddWithValue("@usr", Program.usr);
										cmd2.Prepare();
										cmd2.ExecuteNonQuery();
										cmd2.Dispose();
									}
									c += 1;
									pb1.Value = c;
									pb1.Show();
								}
							}
						}
					}
				}
				pb1.Visible = false;
				dbcon.CloseConnection();
			}
		}

		private void penalty_Load(object sender, EventArgs e)
		{

		}
	}
}
