using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Random sayi = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            char karakter;
            char[] dizi = { 'A', 'b', '3', '4', '5', '6', '7', '8' };
            int rakam = sayi.Next(0, dizi.Length);
            karakter = dizi[rakam];
            label1.Text = karakter.ToString();
        }
    }
}
