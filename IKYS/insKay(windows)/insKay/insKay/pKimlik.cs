using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insKay
{
    public partial class pKimlik : Form
    {

        pBilgi bilgi = new pBilgi();

        static string kimlikSeriNo, tcKimlikNo, soyad, ad, aAdi, bAdi, dogumYer, medHali, din, kanGrubu;
        static string il, ilce, mahKoy, ciltNo, aSiraNo, verYer, verNeden, kayNo, verTarih, dogumTarih;

        public pKimlik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bilgiAl();
            MessageBox.Show(kanGrubu);
            dbGonder();
            bilgi.Show();
        }


        public void bilgiAl()
        {
            kimlikSeriNo = textBox1.Text;
            tcKimlikNo = textBox2.Text;
            soyad = textBox3.Text;
            ad = textBox6.Text;
            aAdi = textBox5.Text;
            bAdi = textBox11.Text;
            dogumYer = textBox4.Text;
            medHali = textBox8.Text;
            din = textBox9.Text;
            kanGrubu = comboBox2.Text;
            il = textBox17.Text;
            ilce = textBox3.Text;
            mahKoy = textBox15.Text;
            ciltNo = textBox14.Text;
            aSiraNo = textBox4.Text;
            verYer = textBox7.Text;
            verNeden = comboBox1.Text;
            kayNo = textBox10.Text;
            verTarih = dateTimePicker2.Value.ToShortDateString();
            dogumTarih = dateTimePicker1.Value.ToShortDateString();
        }

        public void dbGonder()
        {

        }
    }
}
