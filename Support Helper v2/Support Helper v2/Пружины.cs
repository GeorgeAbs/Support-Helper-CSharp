using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Support_Helper_v2
{
    public partial class Пружины : Form
    {
        int iBeginSecondTable = 0;
        public Пружины()
        {
            InitializeComponent();
        }

        private void Пружины_Load(object sender, EventArgs e)
        {
            this.Text = "Расчетная точка: " + Введите_номер_расчетной_точки.calcNum;
            findSecondNumber();
            doMain();
        }
        void doMain()
        {
            int i = 0;
            int xPixel = 13;
            int yPixel = 13;
            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    Label l = new Label();
                    l.Text = Form1.stringsInLicad[i];
                    Point p = new Point();
                    p.X = xPixel;
                    p.Y = yPixel;
                    l.Location = p;
                    this.Controls.Add(l);
                    if (Form1.springs[i] == null | Form1.springs[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = 118;
                        ptb.Y = yPixel - 5;
                        tb.Location = ptb;
                        this.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalc(Form1.springs[i]);
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = 118;
                        ptb.Y = yPixel - 5;
                        tb.Location = ptb;
                        this.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
            typesOfhanger();
            minRods();
            displacement();
        }
        void findSecondNumber()
        {
            iBeginSecondTable = Введите_номер_расчетной_точки.iBegin + 1;
            while (iBeginSecondTable < Form1.supFile.Length)
            {
                if (Form1.supFile[iBeginSecondTable] != "")
                {
                    if (Form1.supFile[iBeginSecondTable].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0] == Введите_номер_расчетной_точки.calcNum)
                    {
                        break;
                    }
                }
                iBeginSecondTable++;
            }
        }
        
        string doCalc(string formula)
        {
            int iv = 2;
            while (iv <= 31)//30 нагрузок, 1 строка - формула
            {
                string valOld = "F" + (iv - 1).ToString() + "F";
                string valNew = "A" + iv.ToString();
                if (formula.Contains(valOld)) // строчка 2, а режим первый
                {
                    formula = formula.Replace(valOld, valNew); // первый режим во второй строчке экселя A1
                    Form1.ObjWorkSheetFormula.Cells[iv, 1].Value = springsLoad(iv - 1);
                }
                iv++;
            }
            Form1.ObjWorkSheetFormula.Cells[1, 1].FormulaLocal = "=" + formula;

            return Form1.ObjWorkSheetFormula.Cells[1, 1].Value.ToString().Replace(",", ".");
        }
        string springsLoad(int numberOfLoad)
        {
            string forReturn = "";
            if (numberOfLoad == 1)
            {
                forReturn = double.Parse(Form1.supFile[iBeginSecondTable + numberOfLoad - 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[5], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
            }
            if (numberOfLoad == 2)
            {
                forReturn = double.Parse(Form1.supFile[iBeginSecondTable + numberOfLoad - 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
            }
            if (numberOfLoad > 2)
            {
                forReturn = double.Parse(Form1.supFile[iBeginSecondTable + numberOfLoad - 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
            }
            return forReturn;
        }
        void typesOfhanger()
        {
            string[] lineInSupFile = Form1.supFile[Введите_номер_расчетной_точки.iBegin].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            hang1.Text = lineInSupFile[3] + " " + lineInSupFile[2][0] + lineInSupFile[2][2];
            hang2.Text = lineInSupFile[4] + " " + lineInSupFile[2][0] + lineInSupFile[2][2];
        }
        void minRods()
        {
            string[] lineInSupFile = Form1.supFile[Введите_номер_расчетной_точки.iBegin].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            minNumRods.Text = lineInSupFile[1];
        }
        void displacement()
        {
            string[] lineInSupFile = Form1.supFile[Введите_номер_расчетной_точки.iBegin].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            d1.Text = lineInSupFile[10];
            d2.Text = lineInSupFile[11];
            d3.Text = lineInSupFile[12];
        }
    }
}
