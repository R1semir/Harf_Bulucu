﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charornek
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle;
            char harf;
            int toplam = 0;
            cumle = textBox1.Text;
            harf = Convert.ToChar(textBox2.Text);
            
            foreach( char i in cumle)
            {
                if (harf == i)
                {
                    toplam++;
                    label4.Text = toplam.ToString();
                }
            }
        }
    }
}
