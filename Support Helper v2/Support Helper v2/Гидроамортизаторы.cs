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
    public partial class Гидроамортизаторы : Form
    {
        public Гидроамортизаторы()
        {
            InitializeComponent();
        }

        private void Гидроамортизаторы_Load(object sender, EventArgs e)
        {
            this.Text = "Расчетная точка: " + Введите_номер_расчетной_точки.calcNum;
            doMain();
            displacement();
            typeOfHydro();
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
                    if (Form1.stringsInLicad[i] == "NOC+SSE")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = Form1.supFile[Введите_номер_расчетной_точки.iBegin].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[2];
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
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void displacement()
        {
            string[] lineInSupFile = Form1.supFile[Введите_номер_расчетной_точки.iBegin].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            double accToCalcPlus = double.Parse(lineInSupFile[3], CultureInfo.InvariantCulture) + double.Parse(lineInSupFile[4], CultureInfo.InvariantCulture);
            double accToCalcMinus = double.Parse(lineInSupFile[3], CultureInfo.InvariantCulture) - double.Parse(lineInSupFile[4], CultureInfo.InvariantCulture);
            double accToCalcPlusOposite = double.Parse(lineInSupFile[3], CultureInfo.InvariantCulture)*(-1) + double.Parse(lineInSupFile[4], CultureInfo.InvariantCulture);
            double accToCalcMinusOposite = double.Parse(lineInSupFile[3], CultureInfo.InvariantCulture)*(-1) - double.Parse(lineInSupFile[4], CultureInfo.InvariantCulture);
            if (accToCalcPlus>=0)
            {
                pos0.Text = Math.Ceiling(accToCalcPlus).ToString();
            }
            else
            {
                pos0.Text = Math.Ceiling(double.Parse(lineInSupFile[4], CultureInfo.InvariantCulture)).ToString();
            }
            if (accToCalcMinus<=0)
            {
                neg0.Text = Math.Abs(Math.Floor(accToCalcMinus)).ToString();
            }
            else
            {
                neg0.Text = Math.Ceiling(double.Parse(lineInSupFile[4], CultureInfo.InvariantCulture)).ToString();
            }
            if (accToCalcPlusOposite >= 0)
            {
                pos180.Text = Math.Ceiling(accToCalcPlusOposite).ToString();
            }
            else
            {
                pos180.Text = Math.Ceiling(double.Parse(lineInSupFile[4], CultureInfo.InvariantCulture)).ToString();
            }
            if (accToCalcMinusOposite <= 0)
            {
                neg180.Text = Math.Abs(Math.Floor(accToCalcMinusOposite)).ToString();
            }
            else
            {
                neg180.Text = Math.Ceiling(double.Parse(lineInSupFile[4], CultureInfo.InvariantCulture)).ToString();
            }
        }
        void typeOfHydro()
        {
            string[] lineInSupFile = Form1.supFile[Введите_номер_расчетной_точки.iBegin].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            string typeOfHyd = "";
            while (lineInSupFile[lineInSupFile.Length - 1][i] != '(')
            {
                i++;
            }
            i++;
            while (lineInSupFile[lineInSupFile.Length - 1][i] != ')')
            {
                typeOfHyd = typeOfHyd + lineInSupFile[lineInSupFile.Length - 1][i];
                i++;
            }
            typeOfHydroTB.Text = typeOfHyd;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
