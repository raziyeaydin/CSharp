using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace insKay
{
    public partial class pKimlik : Form
    {
        public SqlConnection conn;
        public string kimlikSeriNo, tcKimlikNo, soyad, ad, aAdi, bAdi, dogumYer,cinsiyet, medHali, din, kanGrubu;
        public string il, ilce, mahKoy, ciltNo, aSiraNo, verYer, verNeden, kayNo, verTarih, dogumTarih;

        public pKimlik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bilgiAl();
            dbGonder();

            pBilgi bilgi = new pBilgi(textBox2.Text);
            bilgi.Show();
            this.Close();
            
            
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
            dogumTarih = dateTimePicker1.Value.ToShortDateString();
            cinsiyet = comboBox3.Text;
            medHali = textBox8.Text;
            din = textBox9.Text;
            kanGrubu = comboBox2.Text;
            il = textBox17.Text;
            ilce = textBox16.Text;
            mahKoy = textBox15.Text;
            ciltNo = textBox14.Text;
            aSiraNo = textBox4.Text;
            verYer = textBox7.Text;
            verNeden = comboBox1.Text;
            kayNo = textBox10.Text;
            verTarih = dateTimePicker2.Value.ToShortDateString();
            
        }

        public void dbGonder()
        {

            string ekle = "insert into tKimlik values('" + kimlikSeriNo + "','" + tcKimlikNo + "' , '" + soyad + "', '" + ad + "', '" + aAdi + "', '" + bAdi + "', '" + dogumYer + "','" + dogumTarih + "','" + medHali + "', '" + din + "', '" + kanGrubu + "', '" + il + "', '" + ilce + "', '" + mahKoy + "', '" + ciltNo + "', '" + aSiraNo + "', '" + verYer + "', '" + verNeden + "', '" + kayNo + "', '" + verTarih + "', '" + dogumTarih + "', '" + cinsiyet + "')";
            //MessageBox.Show("ekleme cümlesi okundu");
            conn = new SqlConnection("Data Source=ONURMT\\SQLSERVER; Initial Catalog=insKay; Integrated Security=True");
            //MessageBox.Show("bağlantı kuruldu");
            conn.Open();
            SqlCommand cmd = new SqlCommand(ekle, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ekleme yapıldı");
            conn.Close();

        }
    }
}
