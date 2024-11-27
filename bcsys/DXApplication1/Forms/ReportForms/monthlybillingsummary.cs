using bcsys.modules;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
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

namespace bcsys.Forms.ReportForms
{
	public partial class monthlybillingsummary : DevExpress.XtraEditors.XtraForm
	{
		int retries, r, i;
		string ssql, sorno, sname, bp, lznbk;

		private void btnGo_Click(object sender, EventArgs e)
		{
			bp = dtpDate.Value.ToString("yyyyMM");
			sbillingsummary();

		}

		private void monthlybillingsummary_Load(object sender, EventArgs e)
		{
			rbzone.Checked = true;
		}

		private void rbdate_CheckedChanged(object sender, EventArgs e)
		{
			if (rbdate.Checked == true)
			{
				dgv.Columns[0].HeaderText = "Date";
			}
		}

		private void rbzone_CheckedChanged(object sender, EventArgs e)
		{
			if (rbzone.Checked == true)
			{
				dgv.Columns[0].HeaderText = "Zone";
			}
		}

		private void rbbrgy_CheckedChanged(object sender, EventArgs e)
		{
			if (rbbrgy.Checked == true)
			{
				dgv.Columns[0].HeaderText = "Barangay";
			}
		}

		DataTable dtb = new DataTable();
		private DataGridView[] dgvzn;
		public monthlybillingsummary()
		{
			InitializeComponent();
		}

		private void tsbClose_Click(object sender, EventArgs e)
		{
			this.Close();


		}
		private void sbillingsummary()
		{
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			string ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-01";
			DateTime sdate = Convert.ToDateTime(ssdate);
			DateTime edate = sdate.AddMonths(1);
			edate = edate.AddDays(-1);

			if (rbzone.Checked)
			{
				ssql = "select zn,sum(cumused) as cu,sum(billamt) as ba,sum(ftax) as ft,sum(penalty) as pn,sum(wmf) as wm,count(mascode) as cnt" +
					",count(case when penalty<>0 then mascode end) as pl from reading_bc where rdgdate>=@sd and rdgdate<=@ed and billamt<>0 group by zn";
				using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
				{
					cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
					cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
					using (dt = new DataTable())
					{
						dt = dbcon.get_records(ssql, cmd1);
						if (dt.Rows.Count > 0)
						{
							decimal ntotal, nbamt, nft, npen, nwmf;
							int ncnt, ncumused, ncpena;
							ntotal = 0; ncnt = 0; ncpena = 0; nbamt = 0; nft = 0; npen = 0; ncumused = 0;
							nwmf = 0;
							dgv.Rows.Clear();
							foreach (DataRow rs in dt.Rows)
							{
								dgv.Rows.Add();
								r = dgv.Rows.Count - 1;
								dgv.Rows[r].Cells[0].Value = rs["zn"].ToString(); //+ rs["bk"].ToString();
								dgv.Rows[r].Cells[1].Value = rs["cu"];
								dgv.Rows[r].Cells[2].Value = rs["ba"];
								dgv.Rows[r].Cells[3].Value = rs["ft"];
								dgv.Rows[r].Cells[4].Value = rs["pn"];
								dgv.Rows[r].Cells[5].Value = rs["wm"];
								dgv.Rows[r].Cells[8].Value = rs["cnt"];
								dgv.Rows[r].Cells[9].Value = rs["cnt"];
								dgv.Rows[r].Cells[10].Value = rs["pl"];

								if (rs["cu"] != DBNull.Value)
								{
									ncumused += Convert.ToInt32(rs["cu"]);
								}
								if (rs["ba"] != DBNull.Value)
								{
									nbamt += Convert.ToDecimal(rs["ba"]);
								}
								if (rs["ft"] != DBNull.Value)
								{
									nft += Convert.ToDecimal(rs["ft"]);
								}
								if (rs["pn"] != DBNull.Value)
								{
									npen += Convert.ToDecimal(rs["pn"]);
								}
								if (rs["wm"] != DBNull.Value)
								{
									nwmf += Convert.ToDecimal(rs["wm"]);
								}
								if (rs["cnt"] != DBNull.Value)
								{
									ncnt += Convert.ToInt32(rs["cnt"]);
								}
								if (rs["pl"] != DBNull.Value)
								{
									ncpena += Convert.ToInt32(rs["pl"]);
								}

							}
							dgvt.Rows.Clear();
							dgvt.Rows.Add();
							dgvt.Rows[0].Cells[0].Value = "Total";
							dgvt.Rows[0].Cells[1].Value = ncumused;
							dgvt.Rows[0].Cells[2].Value = nbamt;
							dgvt.Rows[0].Cells[3].Value = nft;
							dgvt.Rows[0].Cells[4].Value = npen;
							dgvt.Rows[0].Cells[5].Value = nwmf;
							dgvt.Rows[0].Cells[8].Value = ncnt;
							dgvt.Rows[0].Cells[9].Value = ncnt;
							dgvt.Rows[0].Cells[10].Value = ncpena;
						}
					}
					cmd1.Dispose();
				}

			}
			else if (rbdate.Checked)
			{
				ssql = "select rdgdate,sum(cumused) as cu,sum(billamt) as ba,sum(ftax) as ft,sum(penalty) as pn,sum(wmf) as wm,count(mascode) as cnt" +
					",count(case when penalty<>0 then mascode end) as pl from reading_bc where rdgdate>=@sd and rdgdate<=@ed and billamt<>0 group by rdgdate";
				using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
				{
					cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
					cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
					using (dt = new DataTable())
					{
						dt = dbcon.get_records(ssql, cmd1);
						if (dt.Rows.Count > 0)
						{
							decimal ntotal, nbamt, nft, npen, nwmf;
							int ncnt, ncumused, ncpena;
							ntotal = 0; ncnt = 0; ncpena = 0; nbamt = 0; nft = 0; npen = 0; ncumused = 0;
							nwmf = 0;
							dgv.Rows.Clear();
							foreach (DataRow rs in dt.Rows)
							{
								dgv.Rows.Add();
								r = dgv.Rows.Count - 1;
								dgv.Rows[r].Cells[0].Value = Convert.ToDateTime(rs["rdgdate"]).ToString("dd"); //+ rs["bk"].ToString();
								dgv.Rows[r].Cells[1].Value = rs["cu"];
								dgv.Rows[r].Cells[2].Value = rs["ba"];
								dgv.Rows[r].Cells[3].Value = rs["ft"];
								dgv.Rows[r].Cells[4].Value = rs["pn"];
								dgv.Rows[r].Cells[5].Value = rs["wm"];
								dgv.Rows[r].Cells[8].Value = rs["cnt"];
								dgv.Rows[r].Cells[9].Value = rs["cnt"];
								dgv.Rows[r].Cells[10].Value = rs["pl"];

								if (rs["cu"] != DBNull.Value)
								{
									ncumused += Convert.ToInt32(rs["cu"]);
								}
								if (rs["ba"] != DBNull.Value)
								{
									nbamt += Convert.ToDecimal(rs["ba"]);
								}
								if (rs["ft"] != DBNull.Value)
								{
									nft += Convert.ToDecimal(rs["ft"]);
								}
								if (rs["pn"] != DBNull.Value)
								{
									npen += Convert.ToDecimal(rs["pn"]);
								}
								if (rs["wm"] != DBNull.Value)
								{
									nwmf += Convert.ToDecimal(rs["wm"]);
								}
								if (rs["cnt"] != DBNull.Value)
								{
									ncnt += Convert.ToInt32(rs["cnt"]);
								}
								if (rs["pl"] != DBNull.Value)
								{
									ncpena += Convert.ToInt32(rs["pl"]);
								}

							}
							dgvt.Rows.Clear();
							dgvt.Rows.Add();
							dgvt.Rows[0].Cells[0].Value = "Total";
							dgvt.Rows[0].Cells[1].Value = ncumused;
							dgvt.Rows[0].Cells[2].Value = nbamt;
							dgvt.Rows[0].Cells[3].Value = nft;
							dgvt.Rows[0].Cells[4].Value = npen;
							dgvt.Rows[0].Cells[5].Value = nwmf;
							dgvt.Rows[0].Cells[8].Value = ncnt;
							dgvt.Rows[0].Cells[9].Value = ncnt;
							dgvt.Rows[0].Cells[10].Value = ncpena;
						}
					}
					cmd1.Dispose();
				}

			}
			else if (rbbrgy.Checked)
			{
				ssql = "select c.name,sum(a.cumused) as cu,sum(a.billamt) as ba,sum(a.ftax) as ft,sum(a.penalty) as pn,sum(a.wmf) as wm,count(a.mascode) as cnt" +
					",count(case when a.penalty<>0 then a.mascode end) as pl from bcdb.reading_bc a,bcdb.master b,bcdb.barangay c where a.mascode=b.mascode and c.code=b.bgycode and a.rdgdate>=@sd and a.rdgdate<=@ed and a.billamt<>0 group by c.code order by c.name";
				using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
				{
					cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
					cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
					using (dt = new DataTable())
					{
						dt = dbcon.get_records(ssql, cmd1);
						if (dt.Rows.Count > 0)
						{
							decimal ntotal, nbamt, nft, npen, nwmf;
							int ncnt, ncumused, ncpena;
							ntotal = 0; ncnt = 0; ncpena = 0; nbamt = 0; nft = 0; npen = 0; ncumused = 0;
							nwmf = 0;
							dgv.Rows.Clear();
							foreach (DataRow rs in dt.Rows)
							{
								dgv.Rows.Add();
								r = dgv.Rows.Count - 1;
								dgv.Rows[r].Cells[0].Value = rs["name"]; //+ rs["bk"].ToString();
								dgv.Rows[r].Cells[1].Value = rs["cu"];
								dgv.Rows[r].Cells[2].Value = rs["ba"];
								dgv.Rows[r].Cells[3].Value = rs["ft"];
								dgv.Rows[r].Cells[4].Value = rs["pn"];
								dgv.Rows[r].Cells[5].Value = rs["wm"];
								dgv.Rows[r].Cells[8].Value = rs["cnt"];
								dgv.Rows[r].Cells[9].Value = rs["cnt"];
								dgv.Rows[r].Cells[10].Value = rs["pl"];

								if (rs["cu"] != DBNull.Value)
								{
									ncumused += Convert.ToInt32(rs["cu"]);
								}
								if (rs["ba"] != DBNull.Value)
								{
									nbamt += Convert.ToDecimal(rs["ba"]);
								}
								if (rs["ft"] != DBNull.Value)
								{
									nft += Convert.ToDecimal(rs["ft"]);
								}
								if (rs["pn"] != DBNull.Value)
								{
									npen += Convert.ToDecimal(rs["pn"]);
								}
								if (rs["wm"] != DBNull.Value)
								{
									nwmf += Convert.ToDecimal(rs["wm"]);
								}
								if (rs["cnt"] != DBNull.Value)
								{
									ncnt += Convert.ToInt32(rs["cnt"]);
								}
								if (rs["pl"] != DBNull.Value)
								{
									ncpena += Convert.ToInt32(rs["pl"]);
								}

							}
							dgvt.Rows.Clear();
							dgvt.Rows.Add();
							dgvt.Rows[0].Cells[0].Value = "Total";
							dgvt.Rows[0].Cells[1].Value = ncumused;
							dgvt.Rows[0].Cells[2].Value = nbamt;
							dgvt.Rows[0].Cells[3].Value = nft;
							dgvt.Rows[0].Cells[4].Value = npen;
							dgvt.Rows[0].Cells[5].Value = nwmf;
							dgvt.Rows[0].Cells[8].Value = ncnt;
							dgvt.Rows[0].Cells[9].Value = ncnt;
							dgvt.Rows[0].Cells[10].Value = ncpena;
						}
					}
					cmd1.Dispose();
				}

			}

			sgetclassdata();
			dbcon.CloseConnection();
		}
		private void sgetclassdata()
		{
			ssql = "select a.desc0,a.desc1,sum(b.cumused) as cu,sum(b.billamt) as ba,sum(b.ftax) as ft,sum(b.wmf) as wm, " +
				"sum(b.srdisc) as sr, count(a.`code`) as cnt " +
				" from bcdb.rates a,bcdb.reading_bc b,bcdb.`master` c where b.rdgdate>=@sd and b.rdgdate<=@ed and " +
				"b.mascode=c.MASCODE and a.`code`= c.CLASSCODE and a.msize=c.MSIZE and b.billamt<>0 GROUP BY a.code,a.msize ORDER BY a.code";
			DBConnect dbcon = new DBConnect();
			dbcon.OpenConnection(retries);
			DataTable dt = new DataTable();
			string ssdate = dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-01";
			DateTime sdate = Convert.ToDateTime(ssdate);
			DateTime edate = sdate.AddMonths(1);
			edate = edate.AddDays(-1);
			using (MySqlCommand cmd1 = new MySqlCommand(ssql, dbcon.database_connection))
			{
				cmd1.Parameters.AddWithValue("@sd", sdate.ToString("yyyy-MM-dd"));
				cmd1.Parameters.AddWithValue("@ed", edate.ToString("yyyy-MM-dd"));
				using (dt = new DataTable())
				{
					dt = dbcon.get_records(ssql, cmd1);
					if (dt.Rows.Count > 0)
					{
						int ncu, nba, ncnt;
						decimal ntotbill = 0;
						decimal nbill, nft, npn, nwm, nsr;
						nbill = 0; nft = 0; npn = 0; nwm = 0; nsr = 0;
						ncu = 0; nba = 0; ncnt = 0;
						dgvc.Rows.Clear();
						foreach (DataRow rs in dt.Rows)
						{
							dgvc.Rows.Add();
							r = dgvc.Rows.Count - 1;
							dgvc.Rows[r].Cells[0].Value = rs["desc0"];
							dgvc.Rows[r].Cells[1].Value = rs["desc1"];
							dgvc.Rows[r].Cells[2].Value = rs["cu"];
							dgvc.Rows[r].Cells[3].Value = Convert.ToDecimal(rs["ba"]) + Convert.ToDecimal(rs["ft"]);
							if (rs["cu"] != DBNull.Value)
							{
								ncu += Convert.ToInt32(rs["cu"]);
							}
							if (rs["ba"] != DBNull.Value)
							{
								nbill += Convert.ToDecimal(rs["ba"]);
							}
							if (rs["ft"] != DBNull.Value)
							{
								nft += Convert.ToDecimal(rs["ft"]);
							}
							if (rs["wm"] != DBNull.Value)
							{
								nwm += Convert.ToDecimal(rs["wm"]);
							}
							
							dgvc.Rows[r].Cells[4].Value = rs["cnt"];
							dgvc.Rows[r].Cells[5].Value = rs["cnt"];
							ncnt += Convert.ToInt32(rs["cnt"]);
						}
						ntotbill = nbill + nft;

						dgvctotal.Rows.Clear();
						dgvctotal.Rows.Add();
						dgvctotal.Rows[0].Cells[0].Value = "Total";
						dgvctotal.Rows[0].Cells[2].Value = ncu;
						dgvctotal.Rows[0].Cells[3].Value = ntotbill;
						dgvctotal.Rows[0].Cells[4].Value = ncnt;
						dgvctotal.Rows[0].Cells[5].Value = ncnt;
					}
				}
				cmd1.Dispose();
			}
			dbcon.CloseConnection();

		}
	}
}