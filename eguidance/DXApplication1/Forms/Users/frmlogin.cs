using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.IO;

using System.Text;

using System.Windows.Forms;

using DevExpress.XtraEditors;
using eguidanceV2.modules;
using MySql.Data.MySqlClient;

using eguidanceV2.Forms.Users;
using System.Text.Json;

using System.Net;

using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using DevExpress.XtraRichEdit.SpellChecker;
using System.Text.Json.Nodes;
using DevExpress.CodeParser;
using System.Runtime.Remoting.Contexts;
namespace eguidanceV2.Forms
{
   

    public partial class frmlogin : DevExpress.XtraEditors.XtraForm
    {

      

        public string postJSON { get; set; }
        string qry = "";
        int retries = 1;
        DBConnect newdbcon = new DBConnect();
        public frmlogin()
        {
            InitializeComponent();
            
        }
        
       
         
        private async void simpleButton1_Click(object sender, EventArgs e)
        {

            var myurl = "https://my.mu.edu.ph/my_muapi/testconvert";
            var myusername = "admin";
            var mypassword = "kokey12345!@#";
            string[] myarraytest;
            
            HttpWebRequest request;
            request = (HttpWebRequest)WebRequest.Create(myurl);
            request.PreAuthenticate = true;
            request.Credentials = new NetworkCredential(myusername, mypassword);
            request.Method = WebRequestMethods.Http.Post;

            request.ContentType = "application/x-www-form-urlencoded";

            Dictionary<string, string> postParameters = new Dictionary<string, string>();
            postParameters.Add("st", "testing");
            postParameters.Add("empno", "070044");
            postParameters.Add("Age", "37");
            postParameters.Add("X_API_MYMU_KEY", "mymu_key202410!@#");

                     List<string> jsonlist = new List<string>();
            for(int i = 1; i< 101; i++)
            {
                string data1 = string.Empty;
                data1 = "DATA" + i;
                jsonlist.Add(data1);
            }
            //jsonlist.Add("one");
            

            string[] jsonarray = jsonlist.ToArray();

            string jsonString = JsonConvert.SerializeObject(jsonarray, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented });

           
            postParameters.Add("myarraytest", jsonString);

            string postData = "";
            foreach (string key in postParameters.Keys)
            {
                postData += WebUtility.UrlEncode(key) + "="
                      + WebUtility.UrlEncode(postParameters[key]) + "&";
            }
            byte[] data = Encoding.ASCII.GetBytes(postData);
            request.ContentLength = postData.Length;
            StreamWriter postStream = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
            postStream.Write(postData);
            postStream.Close();
            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode.ToString() == "OK")
            {

               
                string strResponseValue = string.Empty;
                request.ContentType = "application/json";
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadLine();
                        }
                    }
                }
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();

               dynamic jsonObj = JsonConvert.DeserializeObject(strResponseValue);

                foreach (var obj in jsonObj)
                {
                   // MessageBox.Show(obj.ToString());
                    //MessageBox.Show(obj.myinputs.Names.ToString());
                    //  Console.WriteLine(obj.address);
                }

            }
           

            String mystring = "Teststring";
            String encryptedstring = "test";
            String decryptedstring = "test2";

            newdbcon.OpenConnection(retries);
            if (newdbcon.database_connection.State == ConnectionState.Open)
            {
            
                try
                {
                    DataTable result5;
                    qry = "SELECT id FROM eguidance_db_2024.users WHERE Username=@myuser";
                    using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
                    {
                        mqbar1.Visible = true;
                        cmd.Parameters.AddWithValue("@myuser", tbuser.Text.Trim());
                        cmd.Parameters.AddWithValue("@pwd", tbuser.Text.Trim());
                        using (result5 = new DataTable())
                        {
                            result5 = newdbcon.get_records(qry, cmd);
                            if (result5.Rows.Count > 0)
                            {
                                this.Hide();
                                frmDashboard frm = new frmDashboard();
                                frm.Show();
                            }
                            else
                            {
                                XtraMessageBox.Show("Unknow username or password");
                            }
                        }

                        mqbar1.Visible = false;
                    }
                    newdbcon.CloseConnection();
                    qry = "";


                }
                catch (Exception ex)
                {
                    retries += 1;
                    if (retries <4)
                    {

                        simpleButton1_Click(sender, e);
                      
                    }
                    else
                    {
                        retries = 1;
                        MessageBox.Show("FAILED AFTER (3) retries : " + ex.Message.ToString());
                    }
                   
                }
            }
            else
            {
               
                if (retries<4)
                {
                    retries += 1;
                    newdbcon.OpenConnection(retries);
                }
                else
                {
                    simpleButton1_Click(sender, e);
                    retries = 1;
                    newdbcon.OpenConnection(retries);
                }
                   
            }
    
        
            
        }

      
        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Exit System?", "Confirm Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
               
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==13) { 
                    tbpwd.Focus();  
            }
        }

        private void tbpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               btnok.PerformClick();
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

           
        }

        private void hyperLinkEdit2_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hr.mu.edu.ph/V2/forgotten-account");
        }

        private void hyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            frmregistration frmreg = new frmregistration();   
            frmreg.ShowDialog();    
        }
    }
}