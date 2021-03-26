using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day; int month; int year; int week; int century;
            // sunday = 0 monday = 1 tuesday = 2 wednesday = 3 thursday = 4 friday = 5 saturday = 6
            // Mar = 1 Apr = 2 May = 3 Jun = 4 Jul = 5 Aug = 6 Sep = 7 Oct = 8 Nov = 9 Dec = 10 Jan = 11 Feb = 12
            day = Convert.ToInt32(textBox1.Text);
            month = Convert.ToInt32(textBox2.Text);
            year = Convert.ToInt32(textBox3.Text);
            century = Convert.ToInt32(textBox5.Text);

            week = ((int)(day + (((13 * month)-1) /5)  + year + (year / 4) + (century / 4) -(2 * century)) % 7);

            textBox4.Text = Convert.ToString(week);

        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
