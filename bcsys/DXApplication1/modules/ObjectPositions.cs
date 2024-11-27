using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using bcsys.Forms;
using PriorityTextToSpeech.modules;

namespace bcsys.modules
{
    class ObjectPositions
    {
        //ListView p;
        //PictureBox c;
        //ProgressPanel ppan;

        public void CenterObj(XtraForm p, SplashScreen c)
        {
            var left = (p.ClientRectangle.Width - c.ClientRectangle.Width) / 2;
            var top = (p.ClientRectangle.Height - c.ClientRectangle.Height) / 2;
            c.Location = new Point(p.ClientRectangle.Location.X + left, p.ClientRectangle.Location.Y + top);
        }

        public void CenterObj(RibbonControl p, ProgressPanel c)
        {
            var left = (p.ClientRectangle.Width - c.ClientRectangle.Width) / 2;
            var top = (p.ClientRectangle.Height - c.ClientRectangle.Height) / 2;
            c.Location = new Point(p.ClientRectangle.Location.X + left, p.ClientRectangle.Location.Y + top);
        }
        public void CenterObj(System.Windows.Forms.SplitContainer p, int diff, System.Windows.Forms.GroupBox c)
        {
            var left = ((p.ClientRectangle.Width - diff) - c.ClientRectangle.Width) / 2;
            var top = (p.ClientRectangle.Height - c.ClientRectangle.Height) / 2;
            c.Location = new Point(p.ClientRectangle.Location.X + left, p.ClientRectangle.Location.Y + top);
        }
        public void CenterObj(System.Windows.Forms.SplitContainer p, int diff, System.Windows.Forms.PictureBox c)
        {
            var left = ((p.ClientRectangle.Width - diff) - c.ClientRectangle.Width) / 2;
            var top = (p.ClientRectangle.Height - c.ClientRectangle.Height) / 2;
            c.Location = new Point(p.ClientRectangle.Location.X + left, p.ClientRectangle.Location.Y + top);
        }
        public void CenterObj(System.Windows.Forms.DataGridView p, System.Windows.Forms.PictureBox c)
        {
            var left = (p.ClientRectangle.Width - c.ClientRectangle.Width) / 2;
            var top = (p.ClientRectangle.Height - c.ClientRectangle.Height) / 2;
            c.Location = new Point(p.ClientRectangle.Location.X + left, p.ClientRectangle.Location.Y + top);
        }
        public string[] Testing_array()
        {
            List<string> test_array = new List<string>();

            // string[] testarray = { "Volvo", "BMW", "Ford", "Mazda" };
            // string[] test_array = { };
            for (int i = 0; i<=10000; i++)
            {
               
                test_array.Add(i + "MyVALUES" + i);
                //test_array[i] = i + "MyVALUES" + i;
                
            }

             return test_array.ToArray();
            //return test_array;
        }
        public void shide_object(int x)
        {
            frmDashboard objfrm = new frmDashboard();
            if (x == 0)
            {
                
                objfrm.pgpanel.Visible = true;
                objfrm.pgpanel.BringToFront();
            }
            else
            {
                objfrm.pgpanel.Visible = false;
                objfrm.pgpanel.SendToBack();
                objfrm.Refresh();
            }
          
        }
    }

    
}
