﻿using System;
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
            textBox4.BackColor = slider1.kolor;
            
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = slider1.wartosc_r.ToString();
            textBox2.Text = slider1.wartosc_g.ToString();
            textBox3.Text = slider1.wartosc_b.ToString();
            textBox4.BackColor = slider1.kolor;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
