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
using bcsys.Forms;
using bcsys.modules;
using bcsys.Forms.EntryForms;
using bcsys.Forms.Reports;
using bcsys.Forms.ReportForms;

namespace bcsys.Forms
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
             //newChildForm(new reading(), "Reading/Billing");

        }

        private void customersAccordionControlElement_Click(object sender, EventArgs e)
        {
           //newChildForm(new consumer(), "Consumer");
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
            
            //pgpanel.Visible = true;
            //Application.DoEvents();
            //frmdetail objForm = new frmdetail();
            //objForm.TopLevel = false;
            //dockPanel1.Text = "Testing";
            //objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //dockPanel1.ControlContainer.Controls.Add(objForm);
            //objForm.Dock = DockStyle.Fill;
            //objForm.Show();
            //pgpanel.Visible = false;

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

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            newChildForm(new application(), "Application");
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            newChildForm(new ledger_old(), "Consumer Ledger");
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            newChildForm(new penalty(), "Penalty/Surcharge Processing");
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            newChildForm(new AboutBox1(), "Abount");
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            newChildForm(new reading(), "Reading/Billing");
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            newChildForm(new consumer(), "Consumer");
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            newChildForm(new reading(), "Reading/Billing");
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            newChildForm(new consumer(), "Consumer");
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            newChildForm(new application(), "Application");
        }

		private void accordionControlElement14_Click(object sender, EventArgs e)
		{
			newChildForm(new specialbilling(), "Special Billing");
            //changeIcon(Application.StartupPath new application());
           
		}
  //      static void changeicon(Form sfrm)
  //      {
		//	// Create a new Icon from the file at the specified path
		//	Icon img = new Icon(Application.StartupPath + @"\48x48.ico");

		//	// Set the icon of the startup form (assuming sfrm is your starting form)
		//	sfrm.Icon = img;

		//	// Loop through all open forms and set their icons
		//	foreach (Form frm in Application.OpenForms)
		//	{
		//		frm.Icon = img;
		//	}


		//}

		private void accordionControlElement16_Click(object sender, EventArgs e)
		{
            Program.reporttype = "Disconnection";
			newChildForm(new billingreport(), "Billing Report");
            
		}

		private void accordionControlElement17_Click(object sender, EventArgs e)
		{
			Program.reporttype = "Unbilled";
			newChildForm(new billingreport(), "Billing Report");
		}

		private void accordionControlElement19_Click(object sender, EventArgs e)
		{
			newChildForm(new connectionstatus(), "Disconnection");
		}

		private void accordionControlElement20_Click(object sender, EventArgs e)
		{
			newChildForm(new connectionstatus(), "Reconnection");
		}

		private void accordionControlElement21_Click(object sender, EventArgs e)
		{
			newChildForm(new changemeter(), "Change Meter");
		}

        private void accordionControlElement22_Click(object sender, EventArgs e)
        {

        }

		private void accordionControlElement23_Click(object sender, EventArgs e)
		{
            Program.acct = "Change Account";
			newChildForm(new changeform(), "Change Account");
		}

		private void accordionControlElement27_Click(object sender, EventArgs e)
		{
			Program.acct = "Pull Out Meter";
			newChildForm(new changeform(), "Pull Out Meter");
		}

		private void accordionControlElement24_Click(object sender, EventArgs e)
		{
			Program.acct = "Change Name/Address";
			newChildForm(new changeform(), "Change Name/Address");
		}

		private void accordionControlElement28_Click(object sender, EventArgs e)
		{
			newChildForm(new collection(), "Collection Entry");
		}

		private void accordionControlElement36_Click(object sender, EventArgs e)
		{
			newChildForm(new dailybillingreport(), "Billing Report");
		}

		private void accordionControlElement37_Click(object sender, EventArgs e)
		{
			newChildForm(new dlybillingsummary(), "Daily Billing Summary");
		}

		private void accordionControlElement38_Click(object sender, EventArgs e)
		{
			newChildForm(new monthlybillingsummary(), "Monthly Billing Summary");
		}

		private void accordionControlElement39_Click(object sender, EventArgs e)
		{
			newChildForm(new agingreport(), "Consumer's Aging of Accounts Receivable");
		}

		//private void accordionControlElement12_Click(object sender, EventArgs e)
		//{
		//	newChildForm(new reading(), "Billing Upload");
		//}

		//private void accordionControlElement35_Click(object sender, EventArgs e)
		//{

		//}

		private void downloadreading_Click(object sender, EventArgs e)
		{

		}

		private void uploadtoandroid_Click(object sender, EventArgs e)
		{
			newChildForm(new reading(), "Billing Upload");
		}

		private void accordionControlElement11_Click(object sender, EventArgs e)
		{
            this.Close();

		}

		private void ribbonControl_Click(object sender, EventArgs e)
		{

		}

        private void accordionControlElement25_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement26_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement34_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement30_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement29_Click(object sender, EventArgs e)
        {

        }
    }
}