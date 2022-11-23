using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text;

namespace Support_Helper_v2
{
    public partial class Form1 : Form
    {
        Excel.Application ObjWorkExcel;
        Excel.Workbook ObjWorkBook;
        Excel.Worksheet ObjWorkSheet1, ObjWorkSheet2;

        public static Excel.Application ObjWorkExcelFormula;
        public static Excel.Workbook ObjWorkBookFormula;
        public static Excel.Worksheet ObjWorkSheetFormula;
        public static string upForceForSlidingFormula;

        public static string[] stringsInLicad = new string[30];
        public static string[] rigids = new string[30];
        public static string[] springs = new string[30];
        public static string[] slidings = new string[30];
        //public static string[] slide_guide = new string[30];
        public static string[] fixSupports = new string[30];
        public static string[] fixSupportsSecondX = new string[30];
        public static string[] fixSupportsSecondY = new string[30];
        public static string[] fixSupportsSecondZ = new string[30];
        public static string[] guidingBend = new string[30];
        public static string[] oneSideSuppportsMain = new string[30];
        public static string[] oneSideSuppportsSecondX = new string[30];
        public static string[] oneSideSuppportsSecondY = new string[30];
        public static string[] oneSideSuppportsSecondZ = new string[30];
        public static string[] sliding_guidingSuppportsMain = new string[30];
        public static string[] sliding_guidingSuppportsMainPlusX = new string[30]; // отрыв по +Х
        public static string[] sliding_guidingSuppportsMainPlusY = new string[30]; // отрыв по +Y
        public static string[] sliding_guidingSuppportsMainMinusX = new string[30]; // отрыв по -Х
        public static string[] sliding_guidingSuppportsMainMinusY = new string[30]; // отрыв по -Y
        public static string[] sliding_guidingSuppportsSecondX = new string[30];
        public static string[] sliding_guidingSuppportsSecondY = new string[30];
        public static string[] sliding_guidingSuppportsSecondZ = new string[30];
        public static string[] sliding_guidingSuppportsSecondPlusX_X = new string[30];
        public static string[] sliding_guidingSuppportsSecondPlusX_Y = new string[30];
        public static string[] sliding_guidingSuppportsSecondPlusX_Z = new string[30];
        public static string[] sliding_guidingSuppportsSecondPlusY_X = new string[30];
        public static string[] sliding_guidingSuppportsSecondPlusY_Y = new string[30];
        public static string[] sliding_guidingSuppportsSecondPlusY_Z = new string[30];
        public static string[] sliding_guidingSuppportsSecondMinusX_X = new string[30];
        public static string[] sliding_guidingSuppportsSecondMinusX_Y = new string[30];
        public static string[] sliding_guidingSuppportsSecondMinusX_Z = new string[30];
        public static string[] sliding_guidingSuppportsSecondMinusY_X = new string[30];
        public static string[] sliding_guidingSuppportsSecondMinusY_Y = new string[30];
        public static string[] sliding_guidingSuppportsSecondMinusY_Z = new string[30];
        public static string[] fixSuppportsSecondPlusX_X = new string[30];
        public static string[] fixSuppportsSecondPlusX_Y = new string[30];
        public static string[] fixSuppportsSecondPlusX_Z = new string[30];
        public static string[] fixSuppportsSecondPlusY_X = new string[30];
        public static string[] fixSuppportsSecondPlusY_Y = new string[30];
        public static string[] fixSuppportsSecondPlusY_Z = new string[30];
        public static string[] fixSuppportsSecondMinusX_X = new string[30];
        public static string[] fixSuppportsSecondMinusX_Y = new string[30];
        public static string[] fixSuppportsSecondMinusX_Z = new string[30];
        public static string[] fixSuppportsSecondMinusY_X = new string[30];
        public static string[] fixSuppportsSecondMinusY_Y = new string[30];
        public static string[] fixSuppportsSecondMinusY_Z = new string[30];
        public static int countOfLicadStrings = 0;
        public static string[] supFile;

        public Form1()
        {
            InitializeComponent();
            ObjWorkExcelFormula = new Excel.Application();
            ObjWorkBookFormula = ObjWorkExcelFormula.Workbooks.Add();
            ObjWorkSheetFormula = ObjWorkBookFormula.Worksheets.Add();
        }

        private void excel_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "|*.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK & openFileDialog1.FileName.Contains("Helper") == true)
            {
                ObjWorkExcel = new Excel.Application();
                ObjWorkBook = ObjWorkExcel.Workbooks.Open(openFileDialog1.FileName);
                ObjWorkSheet1 = (Excel.Worksheet)ObjWorkBook.Sheets[1];
                ObjWorkSheet2 = (Excel.Worksheet)ObjWorkBook.Sheets[2];
                int i = 3;
                while (ObjWorkSheet2.Cells[i,3].Text != "")
                {
                    stringsInLicad[i - 3] = ObjWorkSheet2.Cells[i, 3].Text;
                    i++;
                    countOfLicadStrings++;
                }
                int colums = 4;
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    rigids[i - 3] = ObjWorkSheet1.Cells[i, 4].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    springs[i - 3] = ObjWorkSheet1.Cells[i, 5].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    slidings[i - 3] = ObjWorkSheet1.Cells[i, 6].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsMain[i - 3] = ObjWorkSheet1.Cells[i, 7].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsMainPlusX[i - 3] = ObjWorkSheet1.Cells[i, 8].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsMainMinusX[i - 3] = ObjWorkSheet1.Cells[i, 9].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsMainPlusY[i - 3] = ObjWorkSheet1.Cells[i, 10].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsMainMinusY[i - 3] = ObjWorkSheet1.Cells[i, 11].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    oneSideSuppportsMain[i - 3] = ObjWorkSheet1.Cells[i, 12].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondX[i - 3] = ObjWorkSheet2.Cells[i, 4].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondY[i - 3] = ObjWorkSheet2.Cells[i, 5].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondZ[i - 3] = ObjWorkSheet2.Cells[i, 6].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondPlusX_X[i - 3] = ObjWorkSheet2.Cells[i, 7].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondPlusX_Y[i - 3] = ObjWorkSheet2.Cells[i, 8].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondPlusX_Z[i - 3] = ObjWorkSheet2.Cells[i, 9].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondMinusX_X[i - 3] = ObjWorkSheet2.Cells[i, 10].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondMinusX_Y[i - 3] = ObjWorkSheet2.Cells[i, 11].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondMinusX_Z[i - 3] = ObjWorkSheet2.Cells[i, 12].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondPlusY_X[i - 3] = ObjWorkSheet2.Cells[i, 13].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondPlusY_Y[i - 3] = ObjWorkSheet2.Cells[i, 14].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondPlusY_Z[i - 3] = ObjWorkSheet2.Cells[i, 15].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondMinusY_X[i - 3] = ObjWorkSheet2.Cells[i, 16].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondMinusY_Y[i - 3] = ObjWorkSheet2.Cells[i, 17].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    sliding_guidingSuppportsSecondMinusY_Z[i - 3] = ObjWorkSheet2.Cells[i, 18].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSupportsSecondX[i - 3] = ObjWorkSheet2.Cells[i, 19].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSupportsSecondY[i - 3] = ObjWorkSheet2.Cells[i, 20].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSupportsSecondZ[i - 3] = ObjWorkSheet2.Cells[i, 21].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondPlusX_X[i - 3] = ObjWorkSheet2.Cells[i, 22].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondPlusX_Y[i - 3] = ObjWorkSheet2.Cells[i, 23].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondPlusX_Z[i - 3] = ObjWorkSheet2.Cells[i, 24].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondMinusX_X[i - 3] = ObjWorkSheet2.Cells[i, 25].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondMinusX_Y[i - 3] = ObjWorkSheet2.Cells[i, 26].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondMinusX_Z[i - 3] = ObjWorkSheet2.Cells[i, 27].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondPlusY_X[i - 3] = ObjWorkSheet2.Cells[i, 28].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondPlusY_Y[i - 3] = ObjWorkSheet2.Cells[i, 29].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondPlusY_Z[i - 3] = ObjWorkSheet2.Cells[i, 30].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondMinusY_X[i - 3] = ObjWorkSheet2.Cells[i, 31].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondMinusY_Y[i - 3] = ObjWorkSheet2.Cells[i, 32].Text;
                    i++;
                }
                i = 3;
                while (i - 3 < countOfLicadStrings)
                {
                    fixSuppportsSecondMinusY_Z[i - 3] = ObjWorkSheet2.Cells[i, 33].Text;
                    i++;
                }
                upForceForSlidingFormula = ObjWorkSheet1.Cells[33, 6].Text; // для поиска силы на отрыв SS скольящих опор


                ObjWorkBook.Close();
                ObjWorkExcel.Quit();
                Marshal.ReleaseComObject(ObjWorkSheet1);
                Marshal.ReleaseComObject(ObjWorkSheet2);
                Marshal.ReleaseComObject(ObjWorkBook);
                Marshal.ReleaseComObject(ObjWorkExcel);
                structure.Enabled = true;
                excel.Enabled = false;
            }
            if (openFileDialog1.FileName.Contains("Helper") != true)
            {
                Form q = new неверный_эксель();
                q.Visible = true;
                q.TopLevel = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { ObjWorkBookFormula.Close(Excel.XlSaveAction.xlDoNotSaveChanges); } catch { }
            try { ObjWorkExcelFormula.Quit(); } catch { }
            try { Marshal.ReleaseComObject(ObjWorkSheetFormula); } catch { }
            try { Marshal.ReleaseComObject(ObjWorkBookFormula); } catch { }
            try { Marshal.ReleaseComObject(ObjWorkExcelFormula); } catch { }
        }

        private void structure_Click(object sender, EventArgs e)
        {
            Form t = new Структура_SUP();
            t.Visible = true;
            t.TopLevel = true;
            sup.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form q = new Disclaimer();
            q.Visible = true;
            q.TopLevel = true;
            q.TopMost = true;
        }

        private void sup_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "|*.sup";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                supFile = File.ReadAllLines(openFileDialog1.FileName, Encoding.GetEncoding(1251));


                Form q = new Введите_номер_расчетной_точки();
                q.Visible = true;
                q.TopLevel = true;
                this.Visible = false;
                q.Owner = this;
            }
        }
    }
}
