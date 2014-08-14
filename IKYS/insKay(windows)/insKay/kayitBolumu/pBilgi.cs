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
    public partial class pBilgi : Form
    {
        persEgitimBilgisi egitim = new persEgitimBilgisi();

        static string tcNo, verIl, verIlce, belNo, verTarih,sinif, duzenleyen, kartNo;
        static string sskNo, sskbelNo,sskAcTrh;
       
        public pBilgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilgiAlma();
            dbEkleme();
            egitim.Show();
            this.Close();

        }

        private void pBilgi_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void bilgiAlma()
        {
            tcNo = textBox2.Text;
            verIl = txt_il.Text;
            verIlce = txt_ilçe.Text;
            belNo = textBox1.Text;
            verTarih = dtp_tarih.Value.ToShortDateString();
            sinif = cbox_sınıf.Text;
            duzenleyen = txt_düzenleyen.Text;
            kartNo = txt_kartno.Text;
            
            sskNo = txt_sskno.Text;
            sskAcTrh = dtp_açılıştarih.Value.ToShortDateString();
            sskbelNo = textBox7.Text;
        }

        public void dbEkleme()
        {
            string ekle1 = "insert into tSurucu(tcNo,il,ilce,belgeNo,verildigiTarih,sinif,duzenleyen,kartNo) values('" + tcNo + "', '" + verIl + "', '" + verIlce + "', '" + belNo + "', '" + verTarih + "', '" + sinif + "', '" + duzenleyen + "', '" + kartNo + "')";
           // MessageBox.Show("ekleme cümlesi okundu");
            SqlConnection conn1 = new SqlConnection("Data Source=CENG\\BYNMHNDS; Initial Catalog=insKay; Integrated Security=True");
            //MessageBox.Show("bağlantı kuruldu");
            conn1.Open();
            SqlCommand cmd1 = new SqlCommand(ekle1, conn1);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("ekleme yapıldı");
            conn1.Close();


            string ekle2 = "insert into tSSK(tcNo,sskNo,acilisTarih,belgeNo) values('" + tcNo + "', '" + sskNo + "', '" + sskAcTrh + "', '" + sskbelNo + "')";
            //MessageBox.Show("ekleme cümlesi okundu");
            SqlConnection conn2 = new SqlConnection("Data Source=CENG\\BYNMHNDS; Initial Catalog=insKay; Integrated Security=True");
            //MessageBox.Show("bağlantı kuruldu");
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand(ekle2, conn2);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("ekleme yapıldı");
            conn2.Close();

        }
        
    }
}
