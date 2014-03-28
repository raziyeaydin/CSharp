using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            string islem = String.Empty; 
            double sayi1 = 0, sayi2 = 0 ;
 
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
        }
 
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text="1";
        }
 
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text="2";
        }
 
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text="3";
        }
 
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text="4";
        }
 
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text="5";
        }
 
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text="6";
        }
 
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text="7";
        }
 
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text="8";
        }
 
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text="9";
        }
 
        private void button25_Click(object sender, EventArgs e)//SİLME
        {
            textBox1.ResetText();
        }
 
        
        private void button24_Click(object sender, EventArgs e)//KARE ALMA
        {
            int sayi1 = Convert.ToInt32(this.textBox1.Text);
            double sonuc = sayi1*sayi1;
            textBox1.Text = sonuc.ToString();
        }
 
        private void button9_Click(object sender, EventArgs e)//TOPLAMA
        {
            int sayi1 = Convert.ToInt32(this.textBox1.Text);
            int sayi2 = Convert.ToInt32(this.textBox1.Text);
            double sonuc = sayi1 + sayi2;
            textBox1.Text = sonuc.ToString();
        }
 
        private void button26_Click(object sender, EventArgs e)//KAREKOK
        {
            int sayi1 = Convert.ToInt32(this.textBox1.Text);
            double sonuc = Math.Sqrt(sayi1);
            textBox1.Text = sonuc.ToString();
                
        }
 
        private void button19_Click(object sender, EventArgs e)//FAKTÖRİYEL
        {
                int sayi1, faktoriyel = 1;
                sayi1 = Convert.ToInt32(this.textBox1.Text);
                for (int i = 1; i <= sayi1; i++)
                {
                    faktoriyel = faktoriyel * i;
                }
                textBox1.Text = faktoriyel.ToString();
        }
 
        private void button23_Click(object sender, EventArgs e)//COSİNÜS
        {
            int sayi1 = Convert.ToInt32(this.textBox1.Text);
            double sonuc = Math.Cos(sayi1);
            textBox1.Text = sonuc.ToString();
        }
 
        private void button22_Click(object sender, EventArgs e)//SİNÜS
        {
            int sayi1 = Convert.ToInt32(this.textBox1.Text);
            double sonuc = Math.Sin(sayi1);
            textBox1.Text = sonuc.ToString();
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text =".";
        }
 
        private void button3_Click(object sender, EventArgs e)//COTANJANT
        {
            int sayi1= Convert.ToInt32(this.textBox1.Text);
            double sonuc1 = Math.Tan(sayi1);
            double sonuc = 1.0/sonuc1 ;
            textBox1.Text = sonuc.ToString();
        }
 
        private void button21_Click(object sender, EventArgs e)//TANJANT
        {
            int sayi1= Convert.ToInt32(this.textBox1.Text);
            double sonuc = Math.Tan(sayi1);
            textBox1.Text = sonuc.ToString();
        }
 
        private void button27_Click(object sender, EventArgs e)//LOGARİTMA
        {
            int sayi1= Convert.ToInt32(this.textBox1.Text);
            double sonuc = Math.Log(sayi1);
            textBox1.Text = sonuc.ToString();
        }
 
        private void button10_Click(object sender, EventArgs e)//ÇIKARMA
        {
            int sayi1 = Convert.ToInt32(this.textBox1.Text);
            int sayi2 = Convert.ToInt32(this.textBox1.Text);
            double sonuc = sayi1-sayi2;
            textBox1.Text = sonuc.ToString();
        }
 
        private void button14_Click(object sender, EventArgs e)//ÇARPMA
        {
            int sayi1 = Convert.ToInt32(this.textBox1.Text);
            int sayi2 = Convert.ToInt32(this.textBox1.Text);
            double sonuc = sayi1*sayi2;
            textBox1.Text = sonuc.ToString();
        }
 
        private void button15_Click(object sender, EventArgs e)//BÖLME
        {
            int sayi1 = Convert.ToInt32(this.textBox1.Text);
            int sayi2 = Convert.ToInt32(this.textBox1.Text);
            double sonuc = sayi1/sayi2;
            textBox1.Text = sonuc.ToString();
        }
 
        private void button20_Click(object sender, EventArgs e)//MOD ALMA
        {
            int sayi1 = Convert.ToInt32(this.textBox1.Text);
            int sayi2 = Convert.ToInt32(this.textBox1.Text);
            double sonuc = sayi1%sayi2;
            textBox1.Text = sonuc.ToString();
        }
    }
}
