using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views;
using DevExpress.XtraGrid.Views.Grid;
namespace bcsys.modules
{
    public class GridEntryController
    {
        public void notgrideditable_cols(GridView dg, int[] cols)
        {
            for (int i = 0; i < cols.Length; i++)
            {
                dg.Columns[cols[i]].OptionsColumn.AllowEdit = false;
            }
       
        }

        public void setgrideditable(GridView dg, int[] cols)
        {
            for (int i = 0; i < cols.Length; i++)
            {
               // dg.Columns[i].de
            }
        }

        public void set_numbersonly(GridView dg, int[] cols)
        {
            CultureInfo ciUSA = new CultureInfo("en-US");
            CultureInfo ciEUR = new CultureInfo("fr-FR", false);

            for (int i = 0; i < cols.Length; i++)
            {
                dg.Columns[cols[i]].DisplayFormat.FormatType = FormatType.Numeric;
                dg.Columns[cols[i]].DisplayFormat.FormatString = "n2";
            }
        }
    }
}
