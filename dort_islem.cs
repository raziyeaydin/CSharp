using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace dort_islem
{
    class Program
    {
        static void Main(string[] args)
        {
            public partial class Form1 : Form
            {
                public Form1()
                {
                    InitializeComponent();
                }
 
                private void button1_Click(object sender, EventArgs e)
                {
                    int sayi1 = Convert.ToInt16(textBox1.Text);
                    int sayi2 = Convert.ToInt16(textBox2.Text);
                    label1.Text = Convert.ToString(sayi1 + sayi2);
                }
 
                private void button2_Click(object sender, EventArgs e)
                {
                    int sayi1 = Convert.ToInt16(textBox1.Text);
                    int sayi2 = Convert.ToInt16(textBox2.Text);
                    label1.Text = Convert.ToString(sayi1 - sayi2);
                }
 
                private void button4_Click(object sender, EventArgs e)
                {
                    int sayi1 = Convert.ToInt16(textBox1.Text);
                    int sayi2 = Convert.ToInt16(textBox2.Text);
                    label1.Text = Convert.ToString(sayi1 * sayi2);
                }
 
                private void button3_Click(object sender, EventArgs e)
                {
                    double sayi1 = Convert.ToDouble(textBox1.Text);
                    double sayi2 = Convert.ToDouble(textBox2.Text);
                    label1.Text = Convert.ToString(sayi1 / sayi2);
                }
            }
        }
    }
