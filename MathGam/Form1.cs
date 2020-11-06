using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGam
{
    public partial class Form1 : Form
    {
        private const string V = " + ";
        int s1;
        int s2;
        int ss;
        int yy;
        int pp;
        int dd;
        int bb;
        //newmode
        int im;
        //newmode
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            im = random.Next(4);
            createAQ(im);
        }

        public void clack(object sender, EventArgs e)
        {
            String gir = textBox1.Text;
            if(gir == Convert.ToString(ss))
            {
                pp += 5;
                dd += 1;
                im = random.Next(4);
                createAQ(im);
            }
            else if(gir == "")
            {
                bb += 1;
                im = random.Next(4);
                createAQ(im);
            }
            else
            {
                yy += 1;
                pp -= 2;
                im = random.Next(4);
                createAQ(im);
            }
        }
        public void createAQ(int imm)
        {
            switch (imm)
            {
                case 0:
                    s1 = random.Next(1,16);
                    s2 = random.Next(1,16);
                    ss = s1 + s2;
                    Thread.Sleep(500);
                    label1.Text = " " + s1 + " + " + s2 + " ";
                    label2.Text = "True Answers: " + dd;
                    label3.Text = "False Answers: " + yy;
                    label4.Text = "Null Answers: " + bb;
                    label5.Text = "Points: " + pp;
                    break;
                case 1:
                    s1 = random.Next(1,16);
                    s2 = random.Next(1,16);
                    if (s2 > s1)
                    {
                        ss = s2 - s1;
                        Thread.Sleep(500);
                        label1.Text = " " + s2 + " - " + s1 + " ";
                    }
                    else
                    {
                        ss = s1 - s2;
                        Thread.Sleep(500);
                        label1.Text = " " + s1 + " - " + s2 + " ";
                    }
                    label2.Text = "True Answers: " + dd;
                    label3.Text = "False Answers: " + yy;
                    label4.Text = "Null Answers: " + bb;
                    label5.Text = "Points: " + pp;
                    break;
                case 2:
                    s1 = random.Next(1,16);
                    s2 = random.Next(1,16);
                    ss = s1 * s2;
                    Thread.Sleep(500);
                    label1.Text = " " + s1 + " x " + s2 + " ";
                    label2.Text = "True Answers: " + dd;
                    label3.Text = "False Answers: " + yy;
                    label4.Text = "Null Answers: " + bb;
                    label5.Text = "Points: " + pp;
                    break;
                case 3:
                    do {
                        s1 = random.Next(1, 16);
                        s2 = random.Next(1, 16);
                    } while (s1 % s2 != 0);
                    if (s2 > s1)
                    {
                        ss = s2 / s1;
                        Thread.Sleep(500);
                        label1.Text = " " + s2 + " / " + s1 + " ";
                    }
                    else
                    {
                        ss = s1 / s2;
                        Thread.Sleep(500);
                        label1.Text = " " + s1 + " / " + s2 + " ";
                    }
                    label2.Text = "True Answers: " + dd;
                    label3.Text = "False Answers: " + yy;
                    label4.Text = "Null Answers: " + bb;
                    label5.Text = "Points: " + pp;
                    break;

            }
        }
    }
}
