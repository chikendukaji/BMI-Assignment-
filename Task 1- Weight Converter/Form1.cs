using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightConverter
{
    public partial class Form1 : Form
    {
        double kilogram; double pounds;
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kilogram = 0; pounds = 0;
            if(comboBox1.SelectedIndex == 0)
            {
                pounds = Convert.ToDouble(textBox1.Text);
                kilogram = (pounds * 0.4535);
                textBox1.Text = Convert.ToString(kilogram);

            }
            else if(comboBox1.SelectedIndex == 1)
            {
                kilogram = Convert.ToDouble(textBox1.Text);
                pounds = (kilogram * 2.205);
                textBox1.Text = Convert.ToString(pounds);

            }
            else
            {
                textBox1.Text = ("error");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
