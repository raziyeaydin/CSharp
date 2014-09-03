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
    public partial class persEgitimBilgisi : Form
    {
        
        static string tcNo,adres,sehir,tel,eMail,okulAdi,bolumAdi,egitimDurumu,basTarih,bitTarih,notOrt;
        


        public persEgitimBilgisi()
        {
            InitializeComponent();
        }

        public persEgitimBilgisi(string tcNo)
        {
            InitializeComponent();

            persEgitimBilgisi.tcNo = tcNo;
            textBox4.Text = tcNo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sirketBilgisi sirket = new sirketBilgisi(textBox4.Text);
            bilgiAl();
            dbEkle();
            this.Close();
            sirket.Show();
        }

        public void bilgiAl(){

            textBox4.Text = persEgitimBilgisi.tcNo;
            tcNo = textBox4.Text;
            adres = richTextBox1.Text;
            sehir = textBox5.Text;
            tel = textBox1.Text;
            eMail = textBox2.Text;
            okulAdi = richTextBox2.Text;
            bolumAdi = richTextBox3.Text;
            notOrt =textBox3.Text;
            basTarih = dateTimePicker1.Value.ToShortDateString();
            bitTarih = dateTimePicker2.Value.ToShortDateString();

            if(radioButton1.Checked){
                egitimDurumu = "lise";
            }
            else if (radioButton2.Checked)
            {
                egitimDurumu = "önlisans";
            }
            else if (radioButton3.Checked)
            {
                egitimDurumu = "lisans";
            }
            else if(radioButton4.Checked)
            {
                egitimDurumu = "yüksek lisans";
            }

           


        }

        public void dbEkle()
        {
            SqlConnection conn = new SqlConnection("Data Source=ONURMT\\SQLSERVER; Initial Catalog=insKay; Integrated Security=True");
            //MessageBox.Show("bağlantı kuruldu");
            string ekle = "insert into tEgitim values('" + tcNo + "', '" + adres + "', '" + sehir + "', '" + tel + "', '" + eMail + "', '" + egitimDurumu + "', '" + okulAdi + "', '" + bolumAdi + "', '" + notOrt + "','" + basTarih + "','" + bitTarih + "')";
            SqlCommand cmd = new SqlCommand(ekle, conn);
            //MessageBox.Show("ekleme cümlesi okundu");
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("ekleme yapıldı");
            conn.Close();
        
        }
    }
}
