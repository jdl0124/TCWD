using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data;
using bcsys.modules;
using Mirabeau.Sql;
using DevExpress.CodeParser;
using System.Drawing;


namespace bcsys.modules
{
   public class DBConnect 
    {
        public MySqlConnection database_connection;
        public MySqlConnection database_connection2;
        public string mytable;
        private string server;
        private string database;
        private string uid;
        private string password;
        public string mydefaultdep;
        public string mydefaultrunningtext;
        public string cashier_identification;
        public string teller_name_detail;
        public string mypicpath;
        public int myretry;
        public string encrytion_key = "koko2024koke2022";

     
        //Constructor
        public DBConnect()
        {
            this.mytable = "";
            mypicpath = Application.StartupPath + "/assets/images/";
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
          

            server = "192.168.1.149";
            server = "localhost";
            
            database = "bcdb";
            uid = "root";
            password = "";
            //uid = "tcwd2";
            //password = "tcwd2024!";
            //string filepath = "";
            //  string mypassword = "eguidance20241008!";
            //filepath = Application.StartupPath + "/iploc.txt";
            //string[] lines = File.ReadAllLines(filepath);

            //String mystring = "https://mypassword.com/tuberculosis/trialtest=testinganan";
            //string mystring = "119.92.208.234";
            //string mystring1 = "muserver";
            //string mystring2 = "mu2010";
            //string mystring3 = "master";

            //String encrypted = NewEncrypterDecrypter.Encrypt(mystring, encrytion_key);
            //String encrypted1 = NewEncrypterDecrypter.Encrypt(mystring1, encrytion_key);
            //String encrypted2 = NewEncrypterDecrypter.Encrypt(mystring2, encrytion_key);
            //String encrypted3 = NewEncrypterDecrypter.Encrypt(mystring3, encrytion_key);
            // String decrypted = NewEncrypterDecrypter.DecryptString(encrytion_key, encrypted);
            //  MessageBox.Show(NewEncrypterDecrypter.Decrypt(encrypted3,encrytion_key));   
            //int x = 0; 

            //foreach (string line in lines)
            //{
            //    if (x == 0){
            //        server = line;
            //    }
            //    else if(x==1){
            //        uid = line;
            //    }
            //    else if (x==2){
            //        password = line;
            //    }
            //    else if(x==3){
            //        database = line;
            //    }


            //    x++;
            //}

            string connectionString=string.Empty;

            //server = NewEncrypterDecrypter.Decrypt(server, encrytion_key);
            //uid = NewEncrypterDecrypter.Decrypt(uid, encrytion_key);
            //database = NewEncrypterDecrypter.Decrypt(database, encrytion_key);
            //password = NewEncrypterDecrypter.Decrypt(password, encrytion_key);

            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Persist Security Info=True;Convert Zero Datetime=True;";

            database_connection = new MySqlConnection(connectionString);
        }

        public Boolean changeIcon(Form sfrm)
        {
			
			return true;
		}

       public string read_default_dep(){
           string filepath1 = "";
           filepath1 = Application.StartupPath + "/defaultdep.txt";
           string[] lines = File.ReadAllLines(filepath1);

           int x = 0;
           string dp = "";
           foreach (string line in lines)
           {
               if (x == 0)
               {
                   mydefaultdep = line;
               }
  
           }
           return mydefaultdep;
         
       }
       public string read_default_runningtext()
       {
           string filepath1 = "";
           filepath1 = Application.StartupPath + "/defaultruntext.txt";
           string[] lines = File.ReadAllLines(filepath1);

           int x = 0;
           string dp = "";
           foreach (string line in lines)
           {
               if (x == 0)
               {
                   mydefaultrunningtext += line;
               }

           }
           return mydefaultrunningtext;

       }
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //open connection to database
        //public object[] OpenConnection()
        public void OpenConnection(int retries)
        {
            string myerrmsg = "";
            //object[] connectiondata = new object[3];
            //connectiondata[0] = false;
            //connectiondata[1] = database_connection;
            //connectiondata[2] = myerrmsg;

            if (database_connection.State == ConnectionState.Closed)
            {
                try
                {
                    database_connection.Open();
                    myerrmsg = "Connected Successfully";
                    myretry = 0;
                
                }
                catch (MySqlException ex)
                {
                
                    switch (ex.Number)
                    {
                        case 0:
                            myerrmsg = "Cannot connect to server.  Contact administrator";
                            break;

                        case 1045:
                            myerrmsg = "Invalid username/password, please try again";
                            break;
                    }
                    if (myerrmsg == "")
                    {
                        myerrmsg = ex.Message.ToString();
                    }
                    if (retries == 3)
                    {
                        MessageBox.Show("ERROR AFTER (3) three Retries due to : ( " + myerrmsg + ") ", "ERROR CONNECTING TO DB");
                    }
                }
            }
            else
            {
                MessageBox.Show("CONNECTION NOT OPEN", "ERROR CONNECTING TO DB");
            }     
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                database_connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool OpenConnection2()
        {
            try
            {
                database_connection2.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                        
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        public bool checktable()
        {
            bool exists =false;

            try
            {
            
                string qry = @"SELECT CASE WHEN EXISTS(SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = "+ this.database + 
                    " AND table_name = "+ this.mytable +") THEN 1 ELSE 0 END" ;
                using(MySqlCommand cmd = new MySqlCommand(qry, database_connection)){
                    return (int)cmd.ExecuteScalar() == 1;
                }
               
            }
            catch(Exception ex)
            {
                return false;
               // MessageBox.Show(ex.Message.ToString());
            }
        }
        //Insert statement
        public int Insert(List<string> columns, List<string> columns2)
        {

            int rowsaffected = 0;
            
            List<string> fieldvalues = new List<string>();
            //open connection
           // if (this.OpenConnection() == true)
           // {
                //create command and assign the query and connection from the constructor
            int x = 0;
            foreach (string fdname in columns)
            {
                string fd = "@" + fdname;
                var fdv = columns2[x];
                columns2[x] = fd;
                fieldvalues.Add(fdv);
                x++;
            }
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("INSERT INTO " + this.mytable + "( " + string.Join(",", columns) + ") "  +"VALUES" + "(" + string.Join(",", columns2)+ ") ");
            string sql = sqlBuilder.ToString();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = sql;
                cmd.Connection = database_connection;
                x = 0;
                foreach (string fdname in columns2)
                {
                    cmd.Parameters.AddWithValue(fdname, fieldvalues[x]);
                    x++;
                }
              
                cmd.Prepare();

                rowsaffected = cmd.ExecuteNonQuery();
            }


            return rowsaffected;

                //close connection
              ///  this.CloseConnection();
           // }
        }
       protected void Page_Load(object sender, EventArgs e)
        {
            List<string> columns =new List<string>();
            columns.Add("CustomerId");
            columns.Add("Name");
            columns.Add("Country");
           
            //DataTable dt = GetData(columns,"Customers","CustomerId","1",con);
        }

       public DataTable GetData(List<string> columns, string whereColumn, string whereColumnValue)
       {
          // string conString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
           string query = string.Format("SELECT {0} FROM {1} WHERE {2} = {3}", string.Join(",", columns), this.mytable, whereColumn, whereColumnValue);
          // using (MySqlConnection con1 = new MySqlConnection(conString))
           //{
               MySqlCommand cmd = new MySqlCommand(query);
               using (MySqlDataAdapter sda = new MySqlDataAdapter())
               {
                   cmd.Connection = database_connection;
                   sda.SelectCommand = cmd;
                   using (DataTable dt = new DataTable())
                   {
                       sda.Fill(dt);
                       return dt;
                   }
               }
           //}
       }


       public int Update(List<string> updatecols, List<string> updatecols_param, List<string> wherecols, List<string> wherecols_param)
        {
            int rowsaffected = 0;
            List<string> myup_fields = new List<string>();
            List<string> wherefields = new List<string>();
           
            int x = 0;
            foreach (string fdname in updatecols)
            {
                string fd = "@" + fdname;
  
                var fdf = fdname + "=" + fd;
                myup_fields.Add(fdf);
                x++;
            }


            int y = 0;
            foreach (string fdname in wherecols)
            {
                var wval = "";
                string fd = "@" + fdname;
                if(y==0){
                    wval = fdname + "=" + fd;
                    wherefields.Add(wval); 
                }
                else{
                    wval += " AND " + fdname + "=" + fd;
                    wherefields.Add(wval);
                }
                y++;
            }

            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("UPDATE " + this.mytable + " SET " + string.Join(",", myup_fields) + " WHERE " + string.Join(" ", wherefields) + "");
            string sql = sqlBuilder.ToString();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = sql;
                cmd.Connection = database_connection;
                x = 0;
                foreach (string fdname in updatecols)
                {
                    var cf = "@"+ fdname;
                    cmd.Parameters.AddWithValue(cf, updatecols_param[x]);
                    x++;
                }

                x = 0;
                foreach (string fdname in wherecols)
                {
                    var cf = "@" + fdname;
                    cmd.Parameters.AddWithValue(cf, wherecols_param[x]);
                    x++;
                }
                cmd.Prepare();
                rowsaffected = cmd.ExecuteNonQuery();

            }
            return rowsaffected;

        }

        //Delete statement
       public int Delete(List<string> wherecols, List<string> wherevals)
        {
            int rowsaffected = 0;
           
            List<string> newcols = new List<string>();
            List<string> fieldqry = new List<string>();
            List<string> delcols = new List<string>();
        
            int y = 0;
            foreach (string fdname in wherecols)
            {
                string fd = "@" + fdname;
                var fdv = wherevals[y];
                if (y == 0)
                {
                    var nwval = fdname + "=" + fd;
                    newcols.Add(nwval);
                }
                else
                {
                    var nwval = " AND " + fdname + "=" + fd;
                    newcols.Add(nwval);
                }
                delcols.Add(fd);
                fieldqry.Add(fdv);
                y++;
            }

            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("DELETE FROM " + this.mytable + " WHERE " + string.Join(" ", newcols)+"");
            string sql = sqlBuilder.ToString();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = sql;
                cmd.Connection = database_connection;
                y = 0;
                foreach (string fdname in delcols)
                {
                    cmd.Parameters.AddWithValue(fdname, fieldqry[y]);
                    y++;
                }

               
                cmd.Prepare();
                rowsaffected = cmd.ExecuteNonQuery();

            }
            return rowsaffected;
        }

        //Select statement
       public string get_time_date(int x){
           
           string dtm = "";
           string query = "SELECT DATE_FORMAT(CURDATE(),'%Y-%m-%d') mdate, " +
                "DATE_FORMAT(CURDATE(),'%b %e, %Y') formaldate,  " +
                "TIME_FORMAT(CURTIME(),'%h:%i:%s %p') mtime,  " +    
                "TIME_FORMAT(CURTIME(),'%h:%i:%s') ntime";

          // DataTable rs = new DataTable();
                using (MySqlCommand cmd = new MySqlCommand(query, database_connection))
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.SelectCommand.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    using (dt)
                    {
                        adp.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow rd in dt.Rows)
                            {
                                 switch (x)
                                 {
                                     case 1:
                                         dtm = rd["mdate"].ToString();
                                         break;
                                     case 2:
                                         dtm = rd["formaldate"].ToString();
                                         break;
                                     case 3:
                                         dtm = rd["mtime"].ToString();
                                         break;
                                     case 4:
                                         dtm = rd["ntime"].ToString();
                                         break;
                                 }
                                
                            }
                        }
                    }
                    
             
                }
                
           return dtm;
       }
       public string[] Select(List<string> columns, List<string> columns2, bool wjoin=false)
        {
            //string query = string.Format("SELECT {0} FROM {1} WHERE {2}", string.Join(",", columns), this.mytable, string.Join(",", columns2));
            var results = new Dictionary<string, object>();
            //Create a list to store the result
            List<string> list = new List<string>();
            List<string> wherefields = new List<string>();

            //Open connection
            int x = 0;
            foreach (string fdname in columns)
            {
                string fd = "@" + fdname;
                var fdv = columns2[x];
                if (x== 0)
                {
                    var nwval = fdname + "=" + fd;
                    wherefields.Add(nwval);
                }
                else
                {
                    var nwval = " AND " + fdname + "=" + fd;
                    wherefields.Add(nwval);
                }
               x++;
            }

            if (wjoin == true)
            {

            }

            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT " + columns + " FROM " + this.mytable + " WHERE " + string.Join(" ", wherefields) + "");
            string sql = sqlBuilder.ToString();
                //Create Command
                using (MySqlCommand cmd = new MySqlCommand(sql, database_connection))
                {
                    using (MySqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                foreach (string fdname in columns)
                                {
                                    
                                    list.Add(rd[fdname].ToString());
                                }

                            }
                        }
                    }
                }
                
                string[] records = list.ToArray();
                return records;
                //close Connection
                //this.CloseConnection();

                //return list to be displayed
               // return list;
            
        }

        //Count statement
       public DataTable get_countrec(List<string> columns, List<string> columns2, List<string> colval,List<string> ordervals,string ord)
        {
            string fnd = "0";
            List<string> list = new List<string>();
            List<string> wherefields = new List<string>();
            var results = new Dictionary<string, string>();

            //Open connection
            int xx = 0;
            foreach (string fdname in columns2)
            {
                string fd = "@" + fdname;
                var fdv = columns2[xx];
                if (xx == 0)
                {
                    var nwval = fdname + "=" + fd;
                    wherefields.Add(nwval);
                }
                else
                {
                    var nwval = " AND " + fdname + "=" + fd;
                    wherefields.Add(nwval);
                }
                xx++;
            }
           // string query = string.Format("SELECT COUNT({0}) FROM {1} WHERE {2}", string.Join(",", columns), this.mytable, string.Join(",", columns2));
    
            //Open Connection
            StringBuilder sqlBuilder = new StringBuilder();
            if (ord != "")
            {
                sqlBuilder.Append("SELECT " + string.Join(",", columns) + " FROM " + this.mytable + " WHERE " + string.Join(" ", wherefields) +
                    "  ORDER BY " + string.Join(" ", ordervals) + "   " + ord + " ");
            }
            else
            {
                sqlBuilder.Append("SELECT " + string.Join(",", columns) + " FROM " + this.mytable + " WHERE " + string.Join(" ", wherefields) + " ");
            }
            
            string sql = sqlBuilder.ToString();
                //Create Mysql Command
            using (MySqlCommand cmd = new MySqlCommand(sql, database_connection))
            {
                int y = 0;
                foreach (string fdname in columns2)
                {
                    cmd.Parameters.AddWithValue(fdname, colval[y]);
                    y++;
                }
                cmd.Prepare();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                using (dt)
                {
                    adp.Fill(dt);
                    return dt;
                }
            }
     
           
        }

       public string e_format(int len)
       {
           string sformat = "";
           if (len == 4)
           {
               sformat = "#,###.##";
           }
           else if (len == 5)
           {
               sformat = "##,###.##";
           }
           else if (len == 6)
           {
               sformat = "###,###.##";
           }
           else if (len == 7)
           {
               sformat = "#,###,###.##";
           }

           return sformat;
       }

       public int get_cboitemindex(ComboBox ctrl, string selcolno1)
       {
           //int y = 0;
           int selindex = 0;
           //foreach (var item in ctrl.ValueMember)
           //{
           //    string sel_colno = "";
           //    sel_colno = item.ToString();
           //   /// sel_colno = ((KeyValuePair<string, string>)item).Key.ToString();
           //    if (sel_colno == selcolno1)
           //    {
           //        selindex = y;
           //    }
           //    y++;
           //}
           //selindex = ctrl.FindString(selcolno1);
           return selindex;
       }
       public DataTable get_records(string qry, MySqlCommand cd)
       {
           string fnd = "0";
           string sql = qry;

           using (MySqlDataAdapter adp = new MySqlDataAdapter(cd))
           {
                
                adp.SelectCommand.CommandType = CommandType.Text;
                
               using (DataTable dt = new DataTable())
               {
                   adp.Fill(dt);
                   return dt;
               }
           }


       }

       public DataTable get_records2(string qry, MySqlCommand cd)
       {
           string fnd = "0";
           string sql = qry;
           //Create Mysql Command
           //using (MySqlCommand cd = new MySqlCommand(sql, dbconnection))
           //{
           using (MySqlDataAdapter adp = new MySqlDataAdapter(cd))
           {
               adp.SelectCommand.CommandType = CommandType.Text;

               using (DataTable dt = new DataTable())
               {
                   adp.Fill(dt);
                   return dt;
               }
           }

           // }

       }

        //Backup
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }
}
