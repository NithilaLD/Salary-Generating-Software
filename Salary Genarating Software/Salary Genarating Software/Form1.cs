namespace Salary_Genarating_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            radioButton3.Checked = false;

        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            radioButton4.Checked = false;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            radioButton5.Checked = false;
        }
    }
}