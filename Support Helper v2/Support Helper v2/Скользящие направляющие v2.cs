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
    public partial class Скользящие_направляющие_v2 : Form
    {
        int yPixelMain;
        int numberOfColumn;
        bool minusXorY;
        public Скользящие_направляющие_v2()
        {
            InitializeComponent();
            doMainHorizontal();
            doMainAddFxHorizontal();
            doMainAddFyHorizontal();
            doMainAddFzHorizontal();

            doMainVerticalPlusX();
            doMainAddFxVerticalPlusX();
            doMainAddFyVerticalPlusX();
            doMainAddFzVerticalPlusX();

            doMainVerticalMinusX();
            doMainAddFxVerticalMinusX();
            doMainAddFyVerticalMinusX();
            doMainAddFzVerticalMinusX();

            doMainVerticalPlusY();
            doMainAddFxVerticalPlusY();
            doMainAddFyVerticalPlusY();
            doMainAddFzVerticalPlusY();

            doMainVerticalMinusY();
            doMainAddFxVerticalMinusY();
            doMainAddFyVerticalMinusY();
            doMainAddFzVerticalMinusY();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form q = new Form2();
            q.Visible = true;
            q.TopLevel = true;
        }
        void doMainHorizontal()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 7; //столбец из sup
            int i = 0;
            int xPixel = 13;
            int yPixel = 63;
            yPixelMain = yPixel;
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
                    panel1.Controls.Add(l);
                    if (Form1.sliding_guidingSuppportsMain[i] == null | Form1.sliding_guidingSuppportsMain[i] == "")
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
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        
                        tb.Text = doCalcFzFn(Form1.sliding_guidingSuppportsMain[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = 118;
                        ptb.Y = yPixel - 5;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFxHorizontal()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 6; //столбец из sup 
            int i = 0;
            int xPixel = 541;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fx";
            Point pl = new Point();
            pl.X = 581;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    Label ll = new Label();
                    ll.Text = Form1.stringsInLicad[i];
                    Point pp = new Point();
                    pp.X = xPixel - 120;
                    pp.Y = yPixel + 5;
                    ll.Location = pp;
                    ll.Width = 80;
                    panel1.Controls.Add(ll);
                    if (Form1.sliding_guidingSuppportsSecondX[i] == null | Form1.sliding_guidingSuppportsSecondX[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();

                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondX[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFyHorizontal()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 5; //столбец из sup 
            int i = 0;
            int xPixel = 647;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fy";
            Point pl = new Point();
            pl.X = 690;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondY[i] == null | Form1.sliding_guidingSuppportsSecondY[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondY[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFzHorizontal()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 7; //столбец из sup 
            int i = 0;
            int xPixel = 753;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fz";
            Point pl = new Point();
            pl.X = 794;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondZ[i] == null | Form1.sliding_guidingSuppportsSecondZ[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFn(Form1.sliding_guidingSuppportsSecondZ[i]);
                        
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    yPixel = yPixel + 30;
                }
                i++;
            }
            yPixel = yPixel + 40;
            Label l = new Label();
            l.Text = "-------------------------------------------------------------------------------------------------------Вертикальная труба, усилие на отрыв вдоль \"+X\"--------------------------------------------------------------------------------";
            Point p = new Point();
            p.X = 0;
            p.Y = yPixel;
            l.Location = p;
            l.Width = 1035;
            panel1.Controls.Add(l);
            yPixel = yPixel + 50;
            yPixelMain = yPixel;
        }
        ////////////////////////////
        void doMainVerticalPlusX()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 7; //столбец из sup 
            int i = 0;
            int xPixel = 13;
            int yPixel = yPixelMain;
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
                    panel1.Controls.Add(l);
                    if (Form1.sliding_guidingSuppportsMainPlusX[i] == null | Form1.sliding_guidingSuppportsMainPlusX[i] == "")
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
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFn(Form1.sliding_guidingSuppportsMainPlusX[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = 118;
                        ptb.Y = yPixel - 5;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFxVerticalPlusX()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 6; //столбец из sup 
            int i = 0;
            int xPixel = 541;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fx";
            Point pl = new Point();
            pl.X = 581;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    Label ll = new Label();
                    ll.Text = Form1.stringsInLicad[i];
                    Point pp = new Point();
                    pp.X = xPixel - 120;
                    pp.Y = yPixel + 5;
                    ll.Location = pp;
                    ll.Width = 80;
                    panel1.Controls.Add(ll);
                    if (Form1.sliding_guidingSuppportsSecondPlusX_X[i] == null | Form1.sliding_guidingSuppportsSecondPlusX_X[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondPlusX_X[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFyVerticalPlusX()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 5; //столбец из sup 
            int i = 0;
            int xPixel = 647;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fy";
            Point pl = new Point();
            pl.X = 690;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondPlusX_Y[i] == null | Form1.sliding_guidingSuppportsSecondPlusX_Y[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondPlusX_Y[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFzVerticalPlusX()
        {
            minusXorY = true; //если прижим по -х/у
            numberOfColumn = 7; //столбец из sup 
            int i = 0;
            int xPixel = 753;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fz";
            Point pl = new Point();
            pl.X = 794;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondPlusX_Z[i] == null | Form1.sliding_guidingSuppportsSecondPlusX_Z[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFn(Form1.sliding_guidingSuppportsSecondPlusX_Z[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    yPixel = yPixel + 30;
                }
                i++;
            }
            yPixel = yPixel + 40;
            Label l = new Label();
            l.Text = "-------------------------------------------------------------------------------------------------------Вертикальная труба, усилие на отрыв вдоль \"-X\"--------------------------------------------------------------------------------";
            Point p = new Point();
            p.X = 0;
            p.Y = yPixel;
            l.Location = p;
            l.Width = 1035;
            panel1.Controls.Add(l);
            yPixel = yPixel + 50;
            yPixelMain = yPixel;
        }
        ////////////////////////////
        void doMainVerticalMinusX()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 7; //столбец из sup 
            int i = 0;
            int xPixel = 13;
            int yPixel = yPixelMain;
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
                    panel1.Controls.Add(l);
                    if (Form1.sliding_guidingSuppportsMainMinusX[i] == null | Form1.sliding_guidingSuppportsMainMinusX[i] == "")
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
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFn(Form1.sliding_guidingSuppportsMainMinusX[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = 118;
                        ptb.Y = yPixel - 5;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFxVerticalMinusX()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 6; //столбец из sup 
            int i = 0;
            int xPixel = 541;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fx";
            Point pl = new Point();
            pl.X = 581;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    Label ll = new Label();
                    ll.Text = Form1.stringsInLicad[i];
                    Point pp = new Point();
                    pp.X = xPixel - 120;
                    pp.Y = yPixel + 5;
                    ll.Location = pp;
                    ll.Width = 80;
                    panel1.Controls.Add(ll);
                    if (Form1.sliding_guidingSuppportsSecondMinusX_X[i] == null | Form1.sliding_guidingSuppportsSecondMinusX_X[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondMinusX_X[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFyVerticalMinusX()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 5; //столбец из sup 
            int i = 0;
            int xPixel = 647;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fy";
            Point pl = new Point();
            pl.X = 690;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondMinusX_Y[i] == null | Form1.sliding_guidingSuppportsSecondMinusX_Y[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondMinusX_Y[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFzVerticalMinusX()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 7; //столбец из sup 
            int i = 0;
            int xPixel = 753;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fz";
            Point pl = new Point();
            pl.X = 794;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondMinusX_Z[i] == null | Form1.sliding_guidingSuppportsSecondMinusX_Z[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFn(Form1.sliding_guidingSuppportsSecondMinusX_Z[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    yPixel = yPixel + 30;
                }
                i++;
            }
            yPixel = yPixel + 40;
            Label l = new Label();
            l.Text = "-------------------------------------------------------------------------------------------------------Вертикальная труба, усилие на отрыв вдоль \"+Y\"--------------------------------------------------------------------------------";
            Point p = new Point();
            p.X = 0;
            p.Y = yPixel;
            l.Location = p;
            l.Width = 1035;
            panel1.Controls.Add(l);
            yPixel = yPixel + 50;
            yPixelMain = yPixel;
        }
        ////////////////////////////
        void doMainVerticalPlusY()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 6; //столбец из sup 
            int i = 0;
            int xPixel = 13;
            int yPixel = yPixelMain;
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
                    panel1.Controls.Add(l);
                    if (Form1.sliding_guidingSuppportsMainPlusX[i] == null | Form1.sliding_guidingSuppportsMainPlusX[i] == "")
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
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsMainPlusX[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = 118;
                        ptb.Y = yPixel - 5;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFxVerticalPlusY()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 7; //столбец из sup 
            int i = 0;
            int xPixel = 541;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fx";
            Point pl = new Point();
            pl.X = 581;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    Label ll = new Label();
                    ll.Text = Form1.stringsInLicad[i];
                    Point pp = new Point();
                    pp.X = xPixel - 120;
                    pp.Y = yPixel + 5;
                    ll.Location = pp;
                    ll.Width = 80;
                    panel1.Controls.Add(ll);
                    if (Form1.sliding_guidingSuppportsSecondPlusY_X[i] == null | Form1.sliding_guidingSuppportsSecondPlusY_X[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFn(Form1.sliding_guidingSuppportsSecondPlusY_X[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFyVerticalPlusY()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 5; //столбец из sup 
            int i = 0;
            int xPixel = 647;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fy";
            Point pl = new Point();
            pl.X = 690;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondPlusY_Y[i] == null | Form1.sliding_guidingSuppportsSecondPlusY_Y[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondPlusY_Y[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFzVerticalPlusY()
        {
            minusXorY = true; //если прижим по -х/у
            numberOfColumn = 6; //столбец из sup 
            int i = 0;
            int xPixel = 753;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fz";
            Point pl = new Point();
            pl.X = 794;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondPlusY_Z[i] == null | Form1.sliding_guidingSuppportsSecondPlusY_Z[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondPlusY_Z[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    yPixel = yPixel + 30;
                }
                i++;
            }
            yPixel = yPixel + 40;
            Label l = new Label();
            l.Text = "-------------------------------------------------------------------------------------------------------Вертикальная труба, усилие на отрыв вдоль \"-Y\"--------------------------------------------------------------------------------";
            Point p = new Point();
            p.X = 0;
            p.Y = yPixel;
            l.Location = p;
            l.Width = 1035;
            panel1.Controls.Add(l);
            yPixel = yPixel + 50;
            yPixelMain = yPixel;
        }
        ////////////////////////////
        void doMainVerticalMinusY()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 6; //столбец из sup 
            int i = 0;
            int xPixel = 13;
            int yPixel = yPixelMain;
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
                    panel1.Controls.Add(l);
                    if (Form1.sliding_guidingSuppportsMainMinusY[i] == null | Form1.sliding_guidingSuppportsMainMinusY[i] == "")
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
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsMainMinusY[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = 118;
                        ptb.Y = yPixel - 5;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFxVerticalMinusY()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 7; //столбец из sup 
            int i = 0;
            int xPixel = 541;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fx";
            Point pl = new Point();
            pl.X = 581;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    Label ll = new Label();
                    ll.Text = Form1.stringsInLicad[i];
                    Point pp = new Point();
                    pp.X = xPixel - 120;
                    pp.Y = yPixel + 5;
                    ll.Location = pp;
                    ll.Width = 80;
                    panel1.Controls.Add(ll);
                    if (Form1.sliding_guidingSuppportsSecondMinusY_X[i] == null | Form1.sliding_guidingSuppportsSecondMinusY_X[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFn(Form1.sliding_guidingSuppportsSecondMinusY_X[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFyVerticalMinusY()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 5; //столбец из sup 
            int i = 0;
            int xPixel = 647;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fy";
            Point pl = new Point();
            pl.X = 690;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondMinusY_Y[i] == null | Form1.sliding_guidingSuppportsSecondMinusY_Y[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondMinusY_Y[i]);
                        //
                        double dou = Math.Abs(double.Parse(tb.Text, CultureInfo.InvariantCulture));
                        tb.Text = "0";
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                }
                yPixel = yPixel + 30;
                i++;
            }
        }
        void doMainAddFzVerticalMinusY()
        {
            minusXorY = false; //если прижим по -х/у
            numberOfColumn = 6; //столбец из sup 
            int i = 0;
            int xPixel = 753;
            int yPixel = yPixelMain;

            Label lab = new Label();
            lab.Text = "Fz";
            Point pl = new Point();
            pl.X = 794;
            pl.Y = yPixelMain - 18;
            lab.Location = pl;
            lab.Height = 18;
            panel1.Controls.Add(lab);

            while (i < Form1.stringsInLicad.Length)
            {
                if (Form1.stringsInLicad[i] != null & Form1.stringsInLicad[i] != "")
                {
                    if (Form1.sliding_guidingSuppportsSecondMinusY_Z[i] == null | Form1.sliding_guidingSuppportsSecondMinusY_Z[i] == "")
                    {
                        TextBox tb = new TextBox();
                        tb.Text = "0";
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    else
                    {
                        TextBox tb = new TextBox();
                        tb.Text = doCalcFzFh(Form1.sliding_guidingSuppportsSecondMinusY_Z[i]);
                        //
                        Size size = new Size();
                        size.Width = 100;
                        size.Height = 22;
                        tb.Size = size;
                        Point ptb = new Point();
                        ptb.X = xPixel;
                        ptb.Y = yPixel;
                        tb.Location = ptb;
                        panel1.Controls.Add(tb);
                    }
                    yPixel = yPixel + 30;
                }
                i++;
            }
        }
        ////////////////////////////

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Скользящие_направляющие_v2_Load(object sender, EventArgs e)
        {
            this.Text = "Расчетная точка: " + Введите_номер_расчетной_точки.calcNum;
        }
        string doCalcFzFn(string formula)
        {
            int iv = 2;
            while (iv <= 31)//30 нагрузок, 1 строка - формула
            {
                string valOld = "F" + (iv - 1).ToString() + "F";
                string valNew = "A" + iv.ToString();
                if (formula.Contains(valOld)) // строчка 2, а режим первый
                {
                    formula = formula.Replace(valOld, valNew); // первый режим во второй строчке экселя A1
                    Form1.ObjWorkSheetFormula.Cells[iv, 1].Value = FzFn(iv - 1);
                }
                iv++;
            }
            Form1.ObjWorkSheetFormula.Cells[1, 1].FormulaLocal = "=" + formula;

            return Form1.ObjWorkSheetFormula.Cells[1, 1].Value.ToString().Replace(",", ".");
        }
        string doCalcFzFh(string formula)
        {
            int iv = 2;
            while (iv <= 31)//30 нагрузок, 1 строка - формула
            {
                string valOld = "F" + (iv - 1).ToString() + "F";
                string valNew = "A" + iv.ToString();
                if (formula.Contains(valOld)) // строчка 2, а режим первый
                {
                    formula = formula.Replace(valOld, valNew); // первый режим во второй строчке экселя A1
                    Form1.ObjWorkSheetFormula.Cells[iv, 1].Value = FzFh(iv - 1);
                }
                iv++;
            }
            Form1.ObjWorkSheetFormula.Cells[1, 1].FormulaLocal = "=" + formula;

            return Form1.ObjWorkSheetFormula.Cells[1, 1].Value.ToString().Replace(",", ".");
        }
        string FzFn(int numberOfLoad)
        {
            string forReturn = "";
            if (numberOfLoad == 1)
            {
                forReturn = double.Parse(Form1.supFile[Введите_номер_расчетной_точки.iBegin + numberOfLoad - 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[7], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
            }
            if (numberOfLoad == 2)
            {
                forReturn = double.Parse(Form1.supFile[Введите_номер_расчетной_точки.iBegin + numberOfLoad - 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[4], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
            }
            if (numberOfLoad > 2)
            {
                forReturn = double.Parse(Form1.supFile[Введите_номер_расчетной_точки.iBegin + numberOfLoad - 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[3], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
            }
            return forReturn;
        }
        string FzFh(int numberOfLoad)
        {
            string forReturn = "";
            if (numberOfLoad == 1)
            {
                forReturn = double.Parse(Form1.supFile[Введите_номер_расчетной_точки.iBegin + numberOfLoad - 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[6], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
            }
            if (numberOfLoad == 2)
            {
                forReturn = double.Parse(Form1.supFile[Введите_номер_расчетной_точки.iBegin + numberOfLoad - 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[3], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
            }
            if (numberOfLoad > 2)
            {
                forReturn = double.Parse(Form1.supFile[Введите_номер_расчетной_точки.iBegin + numberOfLoad - 2].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[2], CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture);
            }
            return forReturn;
        }
    }
}
