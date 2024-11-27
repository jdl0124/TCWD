using DevExpress;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Win.Templates;

namespace eguidanceV2.Forms.Users
{
    partial class LookupForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookupForm1));
            this.formStateModelSynchronizerComponent = new DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer(this.components);
            this.lookupBarManager = new DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.topSeparatorControl = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSeparatorControl)).BeginInit();
            this.SuspendLayout();
            // 
            // modelSynchronizationManager
            // 
            this.modelSynchronizationManager.ModelSynchronizableComponents.Add(this.formStateModelSynchronizerComponent);
            // 
            // formStateModelSynchronizerComponent
            // 
            this.formStateModelSynchronizerComponent.Form = this;
            // 
            // lookupBarManager
            // 
            this.lookupBarManager.DockControls.Add(this.barDockControlTop);
            this.lookupBarManager.DockControls.Add(this.barDockControlBottom);
            this.lookupBarManager.DockControls.Add(this.barDockControlLeft);
            this.lookupBarManager.DockControls.Add(this.barDockControlRight);
            this.lookupBarManager.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.lookupBarManager;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.lookupBarManager;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.lookupBarManager;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.lookupBarManager;
            // 
            // topSeparatorControl
            // 
            this.topSeparatorControl.AutoSizeMode = true;
            resources.ApplyResources(this.topSeparatorControl, "topSeparatorControl");
            this.topSeparatorControl.LineAlignment = DevExpress.XtraEditors.Alignment.Far;
            this.topSeparatorControl.LineThickness = 1;
            this.topSeparatorControl.Name = "topSeparatorControl";
            // 
            // LookupForm1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BarManager = this.lookupBarManager;
            this.Controls.Add(this.topSeparatorControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "LookupForm1";
            this.Load += new System.EventHandler(this.LookupForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookupBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSeparatorControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer formStateModelSynchronizerComponent;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager lookupBarManager;
        private DevExpress.XtraEditors.SeparatorControl topSeparatorControl;
    }
}