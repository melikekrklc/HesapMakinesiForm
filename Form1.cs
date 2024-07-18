using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formuygörn12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = (Math.Sin(sayi1 * (Math.PI / 180)));
            textBox3.Text = sonuc.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double toplam = sayi1 + sayi2;
            textBox3.Text = toplam.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double fark = sayi1 - sayi2;
            textBox3.Text = fark.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double carpim = sayi1 * sayi2;
            textBox3.Text = carpim.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double bölüm = sayi1 / sayi2;
            textBox3.Text = bölüm.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = (Math.Cos(sayi1 * (Math.PI / 180)));
            textBox3.Text = sonuc.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = (Math.Sin(sayi1 * (Math.PI / 180))) / (Math.Cos(sayi1 * (Math.PI / 180)));
            textBox3.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = Math.Pow(sayi1, sayi2);
            textBox3.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = sayi1 * sayi1 * sayi1;
            textBox3.Text = sonuc.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = sayi1 * sayi1;
            textBox3.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = Math.Log(sayi1);
            textBox3.Text = sonuc.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = Math.Log10(sayi1);
            textBox3.Text = sonuc.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = 1 / sayi1;
            textBox3.Text = sonuc.ToString();
        }
    }
}
