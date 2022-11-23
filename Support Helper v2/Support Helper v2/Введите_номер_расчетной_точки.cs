using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Support_Helper_v2
{
    public partial class Введите_номер_расчетной_точки : Form
    {
        public static int iBegin;
        public static string calcNum;
        public Введите_номер_расчетной_точки()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcNum = textBox1.Text;

            int i = 0;
            while (Form1.supFile[i].Contains("Оценка нагрузок на опоры трубопровода")!= true)
            {
                i++;
            }
            i = i + 5;
            while (Form1.supFile[i].Contains("==========================================================") != true)
            {
                i++;
            }
            iBegin = i;
            bool b = false;
            while (iBegin < Form1.supFile.Length-1)
            {
                string[] lineInSupFile = Form1.supFile[iBegin].Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                if (Form1.supFile[iBegin]!="")
                {
                    if (lineInSupFile[0] == textBox1.Text)
                    {
                        b = true;
                        int p = iBegin;
                        while (Form1.supFile[p].Contains(">>>") != true)
                        {
                            p--;
                        }
                        if (Form1.supFile[p].Contains("Характеристики пружинных опор и подвесок"))
                        {
                            springs();
                        }
                        if (Form1.supFile[p].Contains("Сводная таблица нагрузок на динамические амортизаторы"))
                        {
                            hydro();
                        }
                        if (Form1.supFile[p].Contains("Сводная таблица нагрузок на жесткие стержни"))
                        {
                            rigids();
                        }
                        if (Form1.supFile[p].Contains("Сводная таблица нагрузок на скользящие, направляющие и однокомпонентные"))
                        {
                            slidingAndAnother();
                        }
                        if (Form1.supFile[p].Contains("Сводная таблица нагрузок на анкерные и 6-компонентные опоры"))
                        {
                            fixedSup();
                        }

                        break;
                    }
                }
                iBegin++;
            }
            if(b == false)
            {
                Form q = new Расчетная_точка_не_найдена();
                q.Visible = true;
                q.TopLevel = true;
            }
        }
        void springs()
        {
            Form q = new Пружины();
            q.Visible = true;
            q.TopLevel = true;
        }
        void hydro()
        {
            Form q = new Гидроамортизаторы();
            q.Visible = true;
            q.TopLevel = true;
        }
        void rigids()
        {
            Form q = new Распорки();
            q.Visible = true;
            q.TopLevel = true;
        }
        void slidingAndAnother()
        {
            string[] lineInSupFile = Form1.supFile[iBegin-1].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (lineInSupFile[1] == "SS")
            {
                Form q = new Скользящие();
                q.Visible = true;
                q.TopLevel = true;
            }
            if (lineInSupFile[1] == "SLG")
            {
                Form q = new Скользящие_направляющие_v2();
                q.Visible = true;
                q.TopLevel = true;
            }
            if (lineInSupFile[1] == "SGS")
            {
                Form q = new Скользящие_направляющие_v2();
                q.Visible = true;
                q.TopLevel = true;
            }
        }
        void fixedSup()
        {
            Form q = new Неподвижные();
            q.Visible = true;
            q.TopLevel = true;
        }

        private void Введите_номер_расчетной_точки_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
