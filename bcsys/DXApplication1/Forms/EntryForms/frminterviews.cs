using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using bcsys.modules;
using bcsys.Reports;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.CodeParser;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Drawing;
using bcsys.Properties;
using DevExpress.XtraRichEdit.Import.Doc;
using DevExpress.Utils.About;
using Mirabeau.Sql;
using DevExpress.DashboardCommon.Viewer;
using DevExpress.ExpressApp;
using DevExpress.XtraExport.Helpers;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts;

namespace bcsys.Forms
{
   
    public partial class frminterviews : DevExpress.XtraEditors.XtraForm
    {
        public virtual int VisibleIndex { get; set; }
        GridEntryController dgctrl = new GridEntryController();
        RepositoryItemComboBox _riEditor = new RepositoryItemComboBox();
        
        int retries = 1;
        public frminterviews()
        {
            InitializeComponent();
            _riEditor.TextEditStyle = TextEditStyles.DisableTextEditor;
            _riEditor.Items.AddRange(new string[] { "Item1", "Item2", "Item3" });
        }
        private Image GetImageFromResource(string fileName)
        {
            var value = Properties.Resources.ResourceManager.GetObject(fileName, Properties.Resources.Culture);
            return value as Image;
        }

        private void frminterviews_Load(object sender, EventArgs e)
        {
            //GridColumn column = gridView1.Columns.AddVisible("categories", string.Empty);
            //GridColumn column2 = gridView1.Columns.AddVisible("product", string.Empty);

            //gridView1.Columns.Add(column);
            //gridView1.Columns.Add(column2);
            // gridView1.OptionsBehavior.Editable = false;

            //gridView1.Columns[1].OptionsColumn.AllowEdit = true;
            //gridControl1.ContextMenuStrip = ctxmenu1;
            string qry = "SELECT EDP_NO,LASTNAME,FIRSTNAME,MIDDLEI,COURSE,`YEAR`,SEXCODE,B_DATE,b_place,DATELE,ZIP FROM master.mastfile LIMIT 10";
            DBConnect newdbcon = new DBConnect();
            newdbcon.OpenConnection(retries);


           // newdbcon.mytable = "master.mastfile";
            DataTable result5 = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(qry, newdbcon.database_connection))
            {
                using (result5 = new DataTable())
                {
                   result5 = newdbcon.get_records(qry, cmd);
                    if (result5.Rows.Count > 0)
                    {

                       gridView1.OptionsView.ShowAutoFilterRow = true;
                       gridView1.OptionsSelection.MultiSelect = true;
                        result5.Columns.Add(new DataColumn("functional", typeof(bool)));
                        result5.Columns.Add(new DataColumn("dateacquired", typeof(DateTime)));
                        result5.Columns.Add(new DataColumn("qty", typeof(Decimal)));
                        result5.Columns.Add(new DataColumn("prodtype", typeof(String)));
                        gridControl1.DataSource = result5;
                    }
                }
            }
            newdbcon.CloseConnection();

            //    DataTable dt1 = new DataTable();
            //dt1.Columns.Add("categories");
            //dt1.Columns.Add("product");
            //dt1.Columns.Add("description");

            //dt1.Columns.Add(new DataColumn("testadd", typeof(String)));
            //DataRow rw;
            //int j = 2;



            //for (int i = 0; i <= 5; i++)
            //{
            //    // fm.pgpanel.Refresh();
            //    Application.DoEvents();
            //    rw = dt1.NewRow();
            //    rw["categories"] = "Cat1";
            //    if (i % 2 == 0) 
            //    {
            //        rw["categories"] = "Cat2";
            //    }
            //    j += 1;
            //    rw["product"] = "product" + j;
            //    rw["functional"] = 0;
            //    rw["dateacquired"] = DateTime.Now.ToString();

            //    dt1.Rows.Add(rw);


            // }

            //gridView1.OptionsView.ShowAutoFilterRow = true;

            //gridView1.OptionsSelection.MultiSelect = true;

            //gridControl1.DataSource = result5;
            //  int rws = 0;
            //  gridView1.OptionsNavigation.AutoFocusNewRow = true;
            //  for (int i = 0; i < 5; i++)
            //  {
            //     // gridView1.BeginUpdate();

            //      string prodss = "";
            //      prodss = "PRODUCTS" + i;
            //      CreatNewRow(gridView1, prodss, prodss + "a2", prodss + "a3");

            //  }

            //  SpinEdit newspin = new SpinEdit();
            //GridColumn newcol2 = new GridColumn() { Caption = "Type", Visible = true, Name = "prodtype", FieldName = "PRODTYPE" };
            //  gridView1.Columns.Add(newcol2);


            

            gridControl1.RepositoryItems.Add(_riEditor);
            gridView1.Columns[14].ColumnEdit = _riEditor;


              GridColumn newcol3 = new GridColumn();

           
            RepositoryItemButtonEdit butcols= new RepositoryItemButtonEdit();
            RepositoryItemButtonEdit mybuts = new RepositoryItemButtonEdit();
            mybuts.TextEditStyle = TextEditStyles.HideTextEditor;
            mybuts.Buttons.Clear();

            EditorButton mysampbut = new EditorButton();
           
            mysampbut.Kind =  ButtonPredefines.Minus;
            mysampbut.ImageLocation = ImageLocation.MiddleLeft;
            mysampbut.Tag = "Delete";
            mysampbut.ToolTip = "Delete Item";
            mysampbut.Caption = "Delete";
            mysampbut.Click += Mysampbut_ButtonClick;
            //mybuts.Buttons.Add(mysampbut);

            EditorButton mysampbut2 = new EditorButton();
            mysampbut2.Kind = ButtonPredefines.Plus;
            mysampbut2.ImageLocation = ImageLocation.MiddleLeft;
            mysampbut2.Tag = "Add";
            mysampbut.ToolTip = "Add Item";
            mysampbut2.Caption = "Testing";
            mysampbut2.Click += Mysampbut_ButtonClick;


          
            mybuts.Buttons.AddRange(new EditorButton[] { mysampbut, mysampbut2 });
            gridControl1.RepositoryItems.Add(mybuts);
            newcol3.Caption = "Action";

            newcol3.Width = 120;
            newcol3.ColumnEdit = mybuts;
            newcol3.Visible = true;       
        

            newcol3.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
            gridView1.Columns.Add(newcol3);

            //GridColumn newcol4 = new GridColumn();
            //newcol4.Caption = "Action2";

            //// newcol3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.None;
            //// newcol3.OptionsColumn.AllowEdit = true;
            //newcol4.ColumnEdit = butcols2;
            //newcol4.Visible = true;
            //newcol4.Name = "Numbertestonly";
            //gridView1.Columns.Add(newcol4);


            // newcol3.VisibleIndex = 0;
            // newcol3.Width = 350;


            //  //GridColumn newcol3 = new GridColumn() { Caption = "Amount", Visible = true, Name = "Numbertestonly", FieldName = "Price", ColumnType = typeof(String) };


            //  gridControl1.ForceInitialize();


            //  int[] mycols = { 0, 1, 2 };
            //  dgctrl.notgrideditable_cols(gridView1, mycols);

            //  int[] mycols2 = { 5 };
            //  dgctrl.set_numbersonly(gridView1, mycols2);

            //  gridView1.Columns[3].OptionsColumn.AllowEdit = true;
            //  gridView1.Columns[4].OptionsColumn.AllowEdit = true;
            //  gridView1.Columns[5].OptionsColumn.AllowEdit = true;
            //  gridView1.Columns[15].OptionsColumn.AllowEdit = false;
        }

        private void Mysampbut_ButtonClick(object sender, EventArgs e)
        {
           string Info = "";
            EditorButton editor = (EditorButton)sender;
            //EditorButton Button = e.Button;
            int myrowHandle = gridView1.GetRowHandle(gridView1.FocusedRowHandle);

           

            switch (editor.Tag)
            {
                case "Add":
                    XtraMessageBox.Show(Info, editor.Tag + "-" + " " + myrowHandle);
                    // gridView1.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;
                    // BeginInvoke(new MethodInvoker(() => { gridView1.ShowEditForm(); }));
                    break;
                case "Delete":
                    XtraMessageBox.Show(Info, editor.Tag + "-" + " " + myrowHandle);
                    //BeginInvoke(new MethodInvoker(() => { gridView1.DeleteRow(gridView1.FocusedRowHandle); }));
                    break;
            }
           //throw new NotImplementedException();
        }

        private void CreatNewRow(GridView dg, string val1, string val2, string val3)
        {
            dg.AddNewRow();

            int rowHandle = dg.GetRowHandle(dg.DataRowCount);
            if (dg.IsNewItemRow(rowHandle))
            {
                dg.SetRowCellValue(rowHandle, dg.Columns[0], val1);
                dg.SetRowCellValue(rowHandle, dg.Columns[1], val2);
                dg.SetRowCellValue(rowHandle, dg.Columns[2], val3);
                dg.SetRowCellValue(rowHandle, dg.Columns[3], 1);
                dg.SetRowCellValue(rowHandle, dg.Columns[4], DateTime.Now.ToString());
            }
            dg.FocusedColumn = dg.Columns[0];
            dg.ShowEditor();
        }
        private void compute_total_qty()
        {
            decimal totals = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {

              
                decimal myvals = 0;
               // MessageBox.Show(gridView1.GetRowCellValue(i, "qty").ToString());

              //  object valuedata = gridView1.GetRowCellValue(i, "qty");
               if(!string.IsNullOrEmpty(gridView1.GetRowCellValue(i, "qty").ToString()))
                {
                    myvals = Convert.ToDecimal(gridView1.GetRowCellValue(i, "qty").ToString());
                }
              
                totals += myvals;
             }
            TotalQTY.Text = totals.ToString();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Testing4");
            int countrows = 0;
            countrows = gridView1.DataRowCount;
           // MessageBox.Show(countrows.ToString());
            if (gridView1.DataRowCount > 0)
            {
                var rows = gridView1.GetSelectedRows();

                int rowindex = gridView1.GetDataSourceRowIndex(gridView1.FocusedRowHandle);
                int colindex = gridView1.FocusedColumn.VisibleIndex;

               
                string dgval = "";
                dgval = gridView1.GetRowCellDisplayText(rowindex, gridView1.FocusedColumn).ToString();

                int rowHandle = gridView1.GetRowHandle(gridView1.FocusedRowHandle);
              
            }

           
        }



        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            
            int myrowHandle = gridView1.GetRowHandle(gridView1.FocusedRowHandle);
            int curindex = gridView1.FocusedColumn.VisibleIndex;
            GridView view = sender as GridView;
            if (curindex == 5)
            {
                if (view == null) return;
                if (e.Column.Name != "colqty") return;
                string cellValue2 = e.Value.ToString() + " " + view.GetRowCellValue(e.RowHandle, view.Columns["dateacquired"]).ToString();
                // if (gridView1.FocusedColumn.ToString() != "functional") return;

                //string value1 = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "functional"));
                if (e.RowHandle >= 0)
                {
                    if (!string.IsNullOrEmpty(cellValue2))
                    {
                       // gridControl1.ForceInitialize();
                        view.SetRowCellValue(e.RowHandle, view.Columns["testadd"], cellValue2);
                        return;
                    }
                    else
                    {
                        view.SetRowCellValue(e.RowHandle, view.Columns["testadd"], null);
                    }
                }
                
            }
            else if (curindex == 3)
            {
                if (view == null) return;
                if (e.Column.Name != "colfunctional") return;
                string cellValue2 = e.Value.ToString() + " " + view.GetRowCellValue(e.RowHandle, view.Columns["dateacquired"]).ToString();
                // if (gridView1.FocusedColumn.ToString() != "functional") return;

                string value1 = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "functional"));
                if (e.RowHandle >= 0)
                {
                    if (value1 == "True")
                    {

                        //GridView.PopulateColumns();
                        decimal cellValue = Convert.ToUInt32(200) * Convert.ToInt32(5);
                        view.SetRowCellValue(e.RowHandle, view.Columns["qty"], cellValue);
                        view.SetRowCellValue(e.RowHandle, view.Columns["testadd"], cellValue2);
                        return;
                    }
                    else
                    {
                        gridView1.SetRowCellValue(e.RowHandle, "qty", null);
                        view.SetRowCellValue(e.RowHandle, view.Columns["testadd"], null);
                    }
                }


            }
            compute_total_qty();
         
        }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Testing1");
            //if ()
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
           
        }
        //string fieldName = "Commands";
        //private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        //{
        //    AssignEditor(sender, e);
        //}

        //private void gridView1_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        //{
        //    AssignEditor(sender, e);
        //}

        //private void AssignEditor(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        //{
        //    GridView view = sender as GridView;
        //    if (e.RowHandle == view.FocusedRowHandle && e.Column.FieldName == fieldName)
        //        e.RepositoryItem = repositoryItemButtonEdit1;
        //}
        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
      
        }
        private void ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Info = "";
            ButtonEdit editor = (ButtonEdit)sender;
            EditorButton Button = e.Button;
            int myrowHandle = gridView1.GetRowHandle(gridView1.FocusedRowHandle);

           

            switch (e.Button.Caption)
            {
                case "Test":
                    XtraMessageBox.Show(Info, Button.Caption + "-" + " " + myrowHandle);
                    // gridView1.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;
                    // BeginInvoke(new MethodInvoker(() => { gridView1.ShowEditForm(); }));
                    break;
                case "Delete":
                    XtraMessageBox.Show(Info, Button.Caption + "-" + " " + myrowHandle);
                    //BeginInvoke(new MethodInvoker(() => { gridView1.DeleteRow(gridView1.FocusedRowHandle); }));
                    break;
            }

        }

  
        private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {


            //int myrowHandle = gridView1.GetRowHandle(gridView1.FocusedRowHandle);
            //int curindex = gridView1.FocusedColumn.VisibleIndex;
            //GridView view = sender as GridView;
            //if (curindex == 5)
            //{

             
            //    object cellValue = "Testing";
            //    gridView1.SetRowCellValue(e.RowHandle, "Numbertestonly", cellValue);
            //}
            //else if (curindex == 3)
            //{
            //    if (gridView1.FocusedColumn.ToString() != "functional") return;

            //    string value1 = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "functional"));
            //    if (e.RowHandle >= 0)
            //    {
            //        if (value1 == "False")
            //        {
            //            object cellValue = Convert.ToUInt32(200) * Convert.ToInt32(5);
            //            gridView1.SetRowCellValue(e.RowHandle, "qty", cellValue);
            //            return;
            //           // gridView1.SetRowCellValue(e.RowHandle, view.Columns["qty"], cellValue);
            //        }
            //        else
            //        {
            //            gridView1.SetRowCellValue(e.RowHandle, "qty", null);
            //        }
            //    }


            //}

        }

        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "functional" && e.IsGetData)
            {
                //int OwnerID = Convert.ToInt32(gridView1.GetRowCellValue(e.ListSourceRowIndex, colOwnerID));
               // string OwnerCompany = easytenDataSet.Owner.Rows.Find(OwnerID)["Company"].ToString();
               // e.Value = OwnerCompany;
            }
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //MessageBox.Show("Testing");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ForceInitialize();
            gridView1.SelectAll();
            gridView1.OptionsPrint.AllowMultilineHeaders = true;
            gridView1.ColumnPanelRowHeight = 35;
            compositeLink1.CreatePageForEachLink();
            XlsExportOptions myoptionals = new XlsExportOptions();
            myoptionals.ExportMode = XlsExportMode.SingleFilePageByPage;
            // myoptionals.SheetName = "Testingname";
            myoptionals.ShowGridLines = true;
            compositeLink1.ExportToXls("testing.xls", myoptionals);
            Process.Start("testing.xls");
        }

        XRLabel CreateLabel()
        {
            ExpressionBinding eb = new ExpressionBinding("BeforePrint", "Text", "[ProductId] + ' | ' + [ProductName] + ' | ' + [SupplierId] + ' | ' + [Category]");
            XRLabel lb = new XRLabel { Left = 30, WidthF = 300 };
            lb.ExpressionBindings.Add(eb);
            return lb;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {

            //dataSet2.Tables[0].Rows.Clear();
            
            try
            {
                ObjectPositions newpos = new ObjectPositions();
                frmDashboard fdash = new frmDashboard();
                frminterviews mainfrm = new frminterviews();      
                frmloading frm = new frmloading();
                
                string thirdParam = string.Empty;
                string myparamtest1 = "Confidential";

                DataSet ds = new DataSet2();
                ds.Tables[0].Rows.Clear();
                ds.Tables[1].Rows.Clear();

                XtraReport rpt = new MasterReport();
                //XtraReport rpt = new SubReport1();
                 var labelReceiver = (XRLabel)rpt.FindControl("testlabel", false);
                ////labelReceiver.Text = "[individuals_surname]";
                 labelReceiver.Text = "ASSIGNED VALUE";


               
                myparamtest1 = "CAT1";
                string mycat = "CAT1";

                //fdash.pgpanel.Visible = true;
                //fdash.pgpanel.BringToFront();
                ////pgpanel.Text = titleName;
                //fdash.pgpanel.Description = "Loading Data...";

                Application.DoEvents();
                //this.MdiParent = frmDashboard.ActiveForm;
                //this.Cursor = Cursors.AppStarting;


                //Application.DoEvents();
               //frm.StartPosition = FormStartPosition.CenterScreen;
                newpos.CenterObj(fdash, frm);
                this.Cursor = Cursors.AppStarting;

                frm.BringToFront();
                frm.Show(mainfrm);


                frm.Refresh();
                Random rnd = new Random();
                Random rnd2 = new Random();

                int mycnt = 1;
                int studIDs = 20240000;
                int grpids1 = 1; //rnd.Next(1, 4);
                for (int i = 1; i <5; i++)
                {
                    //mycat = "CAT1";

                    //drw["Column1"] = "Product" + i;
                    //if (i % 2==0)
                    //{
                    //    mycat = "CAT2";
                    //}
                    studIDs += 1;
                    DataRow drw = ds.Tables[0].NewRow();
                    drw["studentID"] = studIDs;
                    drw["studentName"] = "Name"+i;
                    drw["age"] = 23;
                    drw["address"] = "Aguada - "+i;

                    for (int j = 1; j <= 10; j++)
                    {

                        DataRow drw2 = ds.Tables[1].NewRow();
                        decimal feeamount = rnd2.Next(2000, 10000);

                        drw2["studentID"] = studIDs;
                        drw2["feeName"] = "Feename" + j;
                        drw2["feeAmount"] = feeamount;

                       
                        ds.Tables[1].Rows.Add(drw2);
                        mycnt += 1;
                        frm.pgbar1.Refresh();
                    }

                    Random rnd3 = new Random();
                    for (int x = 1; x <= 10; x++)
                    {

                        DataRow drw3 = ds.Tables[2].NewRow();
                        int myunits = rnd2.Next(1, 5);

                        drw3["studentID"] = studIDs;
                        drw3["subjectsname"] = "Subjects" + x;
                        drw3["descriptions"] = "Descriptions"+x;
                        drw3["units"] = myunits;

                        ds.Tables[2].Rows.Add(drw3);
                   
                        frm.pgbar1.Refresh();
                    }

                    ds.Tables[0].Rows.Add(drw);
                    frm.pgbar1.Refresh();
                    
                }
               

                //Random rnd2 = new Random();
                //int mycnt = 1;
                // // creates a number between 1 and 3
                //for (int j = 1; j < 100; j++)
                //{

                //    DataRow drw2 = dataSet1.Tables[1].NewRow();


                //    int grpids = rnd2.Next(1, 4);
                //    drw2["Nos"] = mycnt;
                //    drw2["keycodes"] = grpids;
                //    drw2["Test1"] = "Test1" + j;
                //    drw2["Test2"] = "Test2" + j;
                //    drw2["Test3"] = "Test3" + j;
                //    mycnt += 1;
                //    dataSet1.Tables[1].Rows.Add(drw2);
                //    frm.pgbar1.Refresh();
                //}


                 XRSubreport subReport = (XRSubreport)rpt.FindControl("xrSubreport1", true);
                ((SubReport1)subReport.ReportSource).DataSource = ds;

                XRSubreport subReport2 = (XRSubreport)rpt.FindControl("xrSubreport2", true);
                ((SubReport2)subReport2.ReportSource).DataSource = ds;
                //((SubReport1)subReport.ReportSource).DataMember = "dtbtest2";
                rpt.DataSource = ds;
                rpt.CreateDocument();
                fdash.pgpanel.SendToBack();
                fdash.pgpanel.Visible = false;
                ReportPrintTool preView = new ReportPrintTool(rpt);
                preView.PreviewRibbonForm.SaveState = false;
                preView.PreviewRibbonForm.WindowState = FormWindowState.Maximized;
               
                preView.ShowRibbonPreview();
                this.Cursor = Cursors.Default;
                frm.SendToBack();
                frm.Dispose();
                //preView.ShowPreview();
                //ReportPrintTool printTool = new ReportPrintTool(new XtraReport2());
                //printTool.ShowRibbonPreview();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row)
            {
                DXMenuItem menuItem = new DXMenuItem();
                menuItem.Caption = "Item 1";
                menuItem.Tag = e.HitInfo; // Assign to tag, to access in click events
                e.Menu.Items.Add(menuItem);

                e.Menu.ItemClick += Menu_ItemClick; // Handle click events of all items in the menu
            }


            popupMenu1.Tag = e.HitInfo;
            

        }

        private void Menu_ItemClick(object sender, DevExpress.Utils.Menu.DXMenuItemEventArgs e)
        {
            if (e.Item.Caption == "Item 1")
            {
                GridHitInfo hitInfo = (GridHitInfo)e.Item.Tag;
                GridView view = hitInfo.View;
                if (hitInfo.InRowCell)
                {
                    var hitcols = view.GetRowCellDisplayText(hitInfo.RowHandle, hitInfo.Column);
                   // gridView1.GetRowCellValue(i, "qty").ToString();
                    XtraMessageBox.Show(view.GetRowCellDisplayText(hitInfo.RowHandle, view.Columns[0]));
                }
            }
        }

        GridHitInfo GetHitInfo(BarItemLink link)
        {
            PopupMenu menu = link.LinkedObject as PopupMenu;
            return menu.Tag as GridHitInfo;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CreatNewRow(gridView1, " ", " ", " ");
        }
   
    
    }
}