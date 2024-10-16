using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Genarating_Software
{
    public partial class Form4 : Form
    {
        Bitmap bmp;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox6.Text);
            int b = a / 10;
            textBox7.Text = b.ToString();
            textBox8.Text = b.ToString();
            textBox9.Text = b.ToString();
            int c = b * 2;
            textBox10.Text = c.ToString();
            int d;
            if (textBox3.Text == "April" || textBox3.Text == "December") { d = b; }
            else { d = 0; }
            textBox11.Text = d.ToString();
            int f = b + b + b + c + d;
            textBox12.Text = f.ToString();
            int g = a + f;
            textBox4.Text = g.ToString();
            int h = a * 8 / 100;
            textBox15.Text = h.ToString();
            int i = a * 3 / 100;
            textBox14.Text = i.ToString();
            int j = 25;
            textBox13.Text = j.ToString();
            int k = a / 50;
            textBox5.Text = k.ToString();
            int l = 250;
            textBox16.Text = l.ToString();
            int m = h + i + j + k + l;
            textBox17.Text = m.ToString();
            int n = g - m;
            textBox18.Text = n.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "Pay Slip";
            this.Text = a;
            label13.Hide();
            label22.Hide();
            label23.Hide();
            button1.Hide();
            button2.Hide();
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bmp = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
