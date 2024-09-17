using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryKurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
      
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 sf = new Form5();
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 sf = new Form4();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 sf = new Form3();
            sf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sf = new Form2();
            sf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 sf = new Form6();
            sf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 sf = new Form7();
            sf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 sf = new Form8();
            sf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 sf = new Form9();
            sf.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 sf = new Form10();
            sf.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form11 sf = new Form11();
            sf.Show();
        }
    }
}
