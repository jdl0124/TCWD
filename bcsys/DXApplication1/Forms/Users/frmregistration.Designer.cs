namespace bcsys.Forms.Users
{
    partial class frmregistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmregistration));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtempid = new DevExpress.XtraEditors.TextEdit();
            this.txtempusername = new DevExpress.XtraEditors.TextEdit();
            this.btnregister = new DevExpress.XtraEditors.SimpleButton();
            this.txtempassword = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.errlabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtempid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtempusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtempassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errlabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtempid);
            this.layoutControl1.Controls.Add(this.txtempusername);
            this.layoutControl1.Controls.Add(this.btnregister);
            this.layoutControl1.Controls.Add(this.txtempassword);
            this.layoutControl1.Location = new System.Drawing.Point(0, -3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(641, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(369, 161);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(93, 12);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(264, 20);
            this.txtempid.StyleController = this.layoutControl1;
            this.txtempid.TabIndex = 4;
            // 
            // txtempusername
            // 
            this.txtempusername.Location = new System.Drawing.Point(93, 36);
            this.txtempusername.Name = "txtempusername";
            this.txtempusername.Size = new System.Drawing.Size(264, 20);
            this.txtempusername.StyleController = this.layoutControl1;
            this.txtempusername.TabIndex = 5;
            // 
            // btnregister
            // 
            this.btnregister.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnregister.ImageOptions.Image")));
            this.btnregister.Location = new System.Drawing.Point(94, 84);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(130, 22);
            this.btnregister.StyleController = this.layoutControl1;
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "Register Account";
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // txtempassword
            // 
            this.txtempassword.Location = new System.Drawing.Point(93, 60);
            this.txtempassword.Name = "txtempassword";
            this.txtempassword.Size = new System.Drawing.Size(264, 20);
            this.txtempassword.StyleController = this.layoutControl1;
            this.txtempassword.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1,
            this.layoutControlItem3,
            this.errlabel,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(369, 161);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtempid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(349, 24);
            this.layoutControlItem1.Text = "EmployeeID:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtempusername;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(349, 24);
            this.layoutControlItem2.Text = "HR Username:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(69, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 98);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(349, 43);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnregister;
            this.layoutControlItem3.Location = new System.Drawing.Point(82, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(134, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // errlabel
            // 
            this.errlabel.AllowHotTrack = false;
            this.errlabel.Location = new System.Drawing.Point(216, 72);
            this.errlabel.Name = "errlabel";
            this.errlabel.Size = new System.Drawing.Size(133, 26);
            this.errlabel.Text = " ";
            this.errlabel.TextSize = new System.Drawing.Size(69, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(82, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtempassword;
            this.layoutControlItem4.CustomizationFormText = "HRPassword";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(349, 24);
            this.layoutControlItem4.Text = "HR Password:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(69, 13);
            // 
            // frmregistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 127);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::bcsys.Properties.Resources.egadmin;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmregistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtempid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtempusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtempassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errlabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtempid;
        private DevExpress.XtraEditors.TextEdit txtempusername;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnregister;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtempassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.SimpleLabelItem errlabel;
    }
}