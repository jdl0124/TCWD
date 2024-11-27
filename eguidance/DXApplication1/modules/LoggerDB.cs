using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using eguidanceV2.Forms;

namespace eguidanceV2.modules
{
    internal class LoggerDB
    {
        DBConnect newdbcon = new DBConnect();
        private string errorTab;
        private string sqry = "";
        int retries = 1;
        public string erno = "";
        public string ermsg = "";
        public void LogERRORS(string erno, string ermsg) {
            try
            {
                newdbcon.OpenConnection(retries);
                if (newdbcon.database_connection.State == ConnectionState.Open)
                {
                    sqry = "INSERT INTO trail_error_logs(error_num,error_msg) VALUES(@er1,@er2)";
                    using (MySqlCommand cmd = new MySqlCommand(sqry, newdbcon.database_connection))
                    {
                        cmd.Parameters.AddWithValue("@er1", erno);
                        cmd.Parameters.AddWithValue("@er2", ermsg);
                        cmd.ExecuteNonQuery();
                    }
                    newdbcon.CloseConnection();
                    sqry = "";

                }
            }
            catch (MySqlException ex)
            {
                if (retries < 4)
                {
                    LogERRORS(erno, ermsg);
                }
                else {
                    MessageBox.Show(ex.Message.ToString());
                }
       
            }
        }
    }
}
