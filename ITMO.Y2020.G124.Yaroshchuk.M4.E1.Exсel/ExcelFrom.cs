using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace ITMO.Y2020.G124.Yaroshchuk.M5.E1.Exel
{
    public partial class ExcelFrom : Form
    {
        public ExcelFrom()
        {
            InitializeComponent();
        }

        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NwSheet;
        ExcelObj.Range ShtRange;
        DataTable dTable = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                workbook = app.Workbooks.Open(ofd.FileName);
                NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                ShtRange = NwSheet.UsedRange;

                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    dTable.Columns.Add(new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                dTable.AcceptChanges();

                string[] columnNames = new String[dTable.Columns.Count];
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    columnNames[0] = dTable.Columns[i].ColumnName;
                }

                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dRow = dTable.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dRow[Cnum - 1] = (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dTable.Rows.Add(dRow);
                    dTable.AcceptChanges();
                }
                dataGridView1.DataSource = dTable;
                app.Quit();
            }
            else
            {
                MessageBox.Show("You did not select a file to open", "Loading...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
