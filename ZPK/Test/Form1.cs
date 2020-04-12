using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = slider1.Slider1V.ToString();
            textBox2.Text = slider1.Slider2V.ToString();
            textBox3.Text = slider1.Slider3V.ToString();
            textBox4.BackColor = slider1.bgColor;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
