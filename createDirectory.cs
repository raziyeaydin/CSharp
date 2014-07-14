using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dosyaIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String name;
        String yol;
        
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            yol = "C:\\Users\\Onur\\Desktop\\"+name;
            Directory.CreateDirectory(yol);

            MessageBox.Show("klasörünüz oluşturuldu");
        }

    }
}

