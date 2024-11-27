using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Templates.ActionControls;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Win.Controls;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.ExpressApp.Win.Templates.Utils;
using DevExpress.ExpressApp.Win.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;

namespace bcsys.Forms.Users
{
    public partial class MainEncrypter : XtraForm
    {
        private static readonly object viewChanged = new object();
        private static readonly object settingsReloaded = new object();
        private UIType uiType;
        private StatusMessagesHelper statusMessagesHelper;

        protected virtual void InitializeImages()
        {
            ImageOptionsHelper.AssignImage(barMdiChildrenListItem.ImageOptions, "Action_WindowList");
            ImageOptionsHelper.AssignImage(barSubItemPanels.ImageOptions, "Action_Navigation");
        }
        protected virtual void SynchronizeBarAndDockingControllerWithDefault()
        {
            barAndDockingController.PropertiesBar.ScaleEditors = BarAndDockingController.Default.PropertiesBar.ScaleEditors;
            barAndDockingController.PropertiesRibbon.ScaleEditors = BarAndDockingController.Default.PropertiesRibbon.ScaleEditors;
        }
        protected virtual void OnUITypeChanged()
        {
            UIType uiType = ((IXafDocumentsHostWindow)this).UIType;
            if (uiType == UIType.TabbedMDI)
            {
                SetupTabbedMdi();
            }
            else if (uiType == UIType.StandardMDI)
            {
                SetupStandardMdi();
            }
            else
            {
                SetupSdi();
            }
        }
        protected void SetupSdi()
        {
            barManager.MdiMenuMergeStyle = BarMdiMenuMergeStyle.Never;
            documentManager.View = noDocumentsView;
            documentManager.ViewCollection.Remove(nativeMdiView);
            documentManager.ViewCollection.Remove(tabbedView);
            viewSitePanel.Visible = true;
            documentManager.ClientControl = viewSitePanel;
            barMdiChildrenListItem.Visibility = BarItemVisibility.Never;
        }
        protected void SetupStandardMdi()
        {
            barManager.MdiMenuMergeStyle = BarMdiMenuMergeStyle.OnlyWhenChildMaximized;
            documentManager.View = nativeMdiView;
            documentManager.ViewCollection.Remove(noDocumentsView);
            documentManager.ViewCollection.Remove(tabbedView);
            SetupMdiCommon();
        }
        protected void SetupTabbedMdi()
        {
            barManager.MdiMenuMergeStyle = BarMdiMenuMergeStyle.Always;
            documentManager.View = tabbedView;
            documentManager.ViewCollection.Remove(noDocumentsView);
            documentManager.ViewCollection.Remove(nativeMdiView);
            SetupMdiCommon();
        }
        private void SetupMdiCommon()
        {
            viewSitePanel.Visible = false;
            documentManager.MdiParent = this;
            barMdiChildrenListItem.Visibility = BarItemVisibility.Always;
        }

        protected virtual void RaiseViewChanged(DevExpress.ExpressApp.View view)
        {
            EventHandler<TemplateViewChangedEventArgs> handler = (EventHandler<TemplateViewChangedEventArgs>)Events[viewChanged];
            if (handler != null)
            {
                handler(this, new TemplateViewChangedEventArgs(view));
            }
        }
        protected virtual void RaiseSettingsReloaded()
        {
            EventHandler handler = (EventHandler)Events[settingsReloaded];
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        protected override FormShowMode ShowMode
        {
            get { return FormShowMode.AfterInitialization; }
        }

        public MainEncrypter()
        {
            InitializeComponent();
            SynchronizeBarAndDockingControllerWithDefault();
            InitializeImages();
            barManager.ForceLinkCreate();
            statusMessagesHelper = new StatusMessagesHelper(barContainerStatusMessages);
            OnUITypeChanged();
        }

       
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MainEncrypter_Load(object sender, EventArgs e)
        {
            string selected_database= String.Empty;
            string listoftables = string.Empty; 
            String qry_show_alldb = "SHOW DATABASES;";
            String qry_get_alltables = "SELECT table_name FROM information_schema.tables\r\nWHERE table_schema = "+ selected_database  + ";";

            String qry_insert_to_newtable = "";
            qry_insert_to_newtable = "INSERT INTO "+ listoftables +" SELECT table_name FROM information_schema.tables WHERE table_schema ="+ selected_database  + ";";


        }
    }
}
