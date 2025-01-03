using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using bcsys;
using bcsys.Forms;
using bcsys.Forms.EntryForms;
using System.Drawing;

namespace bcsys 
{
    internal static class Program
    {
        public static string brycode;
        public static string brgyname;
        public static string zone;
        public static string book;
        public static string usr;
        public static string smascode;
        public static string zna;
        public static string acct;
        public static string desc0;
        public static decimal rate;
        public static string ttype;
        public static string reporttype;
        public static string bp;
        public static decimal nmisamount;
        public static string sig1;
        public static string sig2;
        public static string sig3;
        public static string accno;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmlogin());
        }
  //      static void changeIcon(Form sfrm)
  //      {
		//	// Create a new Icon from the file at the specified path
		//	Icon img = new Icon(Application.StartupPath + @"\24x24.ico");

		//	// Set the icon of the startup form (assuming sfrm is your starting form)
		//	sfrm.Icon = img;

		//	// Loop through all open forms and set their icons
		//	foreach (Form frm in Application.OpenForms)
		//	{
		//		frm.Icon = img;
		//	}
		//}
    }
}
