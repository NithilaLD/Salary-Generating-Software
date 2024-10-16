using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Genarating_Software
{
    public partial class Form2 : Form
    {
        Bitmap bmp;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text) * int.Parse(textBox4.Text);
            textBox6.Text = a.ToString();
            int b;
            if (textBox3.Text == "April" || textBox3.Text == "December") { b = a * 15 / 100; }
            else { b = 0; }
            textBox7.Text = b.ToString();
            int c = a + b;
            textBox8.Text = c.ToString();
            int d = a * 8 / 100;
            textBox9.Text = d.ToString();
            int f = a * 3 / 100;
            textBox10.Text = f.ToString();
            int g = 25;
            textBox11.Text = g.ToString();
            int h = d + f + g;
            textBox12.Text = h.ToString();
            int i = c - h;
            textBox13.Text = i.ToString();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            string a = "Pay Slip";
            this.Text = a;
            label13.Hide();
            label16.Hide();
            label17.Hide();
            button1.Hide();
            button2.Hide();
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bmp = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printDocument1.Print();
        }
    }
}
