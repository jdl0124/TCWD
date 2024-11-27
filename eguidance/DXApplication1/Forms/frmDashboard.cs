using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Card.Handler;
using eguidanceV2.modules;
namespace eguidanceV2.Forms
{
    public partial class frmDashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
  
        public frmDashboard()
        {
            InitializeComponent();

        }
        public void newChildForm(Form frm, string titleName)
        {
          

            bool isOpen= false;
            foreach(Form fm in Application.OpenForms) { 
                if (fm.Text  == titleName)
                {
                   // obj.shide_object(0);
                    isOpen = true;
                    fm.Focus();
                    break;  
                }
            }
            if( isOpen == false) {

               
                pgpanel.Visible = true;
                pgpanel.BringToFront();
                //pgpanel.Text = titleName;
                pgpanel.Description = "Loading " +  titleName + " Data...";
                Application.DoEvents();
                frm.MdiParent = frmDashboard.ActiveForm;
                frm.Text = titleName;


                tabbedView1.AddDocument(frm);
                tabbedView1.ActivateDocument(frm);

                frm.Show();

                pgpanel.Visible = false;
                pgpanel.SendToBack();
            }
        }
    
        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {

          
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            newChildForm(new frminterviews(), "Interviews");
            // int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            // accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }
      
     

        private void employeesAccordionControlElement_Click(object sender, EventArgs e)
        {
          
             newChildForm(new frminterviews(), "Interviews");

        }

        private void customersAccordionControlElement_Click(object sender, EventArgs e)
        {
           newChildForm(new frmpif(), "Student PIF Form");
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Students");
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            //string result = mynumber switch
            //{
            //    0 => "zero",
            //    1 => "one",
            //    2 => "two"
            //};
            

            List<string> tempList = new List<string>();
            tempList.Add("One");
            tempList.Add("Two");
            tempList.Add("Three");

            barEditItem3.EditValue = "Two";
           
            //barEditItem3.CanOpenEdit = true;


            //Assign the List<> to the ComboBoxEdit

            (barEditItem3.Edit as RepositoryItemComboBox).Items.AddRange(tempList);
            
            tempList.Clear();
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void studentsAccordionControlElement_Click(object sender, EventArgs e)
        {
            
            pgpanel.Visible = true;
            Application.DoEvents();
            frmdetail objForm = new frmdetail();
            objForm.TopLevel = false;
            dockPanel1.Text = "Testing";
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dockPanel1.ControlContainer.Controls.Add(objForm);
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
            pgpanel.Visible = false;
        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            frmlogin objfrm = new frmlogin();
            objfrm.Show();  
            
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem2_EditValueChanged(object sender, EventArgs e)
        {
            BarEditItem item = sender as BarEditItem;
          //  MessageBox.Show(item.EditValue.ToString());
        }

        private void barEditItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barEditItem3_EditValueChanged(object sender, EventArgs e)
        {
            BarEditItem item = sender as BarEditItem;
           
          //  MessageBox.Show(item.EditValue.ToString());
        }

        private void barEditItem2_ShownEditor(object sender, ItemClickEventArgs e)
        {

        }
    }
}