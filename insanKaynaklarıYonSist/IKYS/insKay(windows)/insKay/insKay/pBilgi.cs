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
    public partial class pBilgi : Form
    {

        static string verIl, verIlce, belNo, verTarih,sinif, duzenleyen, kartNo;
        static string sskNo, sskbelNo,sskAcTrh;
       
        public pBilgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilgiAlma();
            dbEkleme();

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

        }
        
    }
}
