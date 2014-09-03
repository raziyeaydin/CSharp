using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace insKay
{
    public partial class sirketBilgisi : Form
    {
        public sirketBilgisi()
        {
            InitializeComponent();
        }

        static string tcNo, calistigiBolum, maas;

        public sirketBilgisi(string tcNo)
        {
            InitializeComponent();

            sirketBilgisi.tcNo = tcNo;
            textBox1.Text = tcNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilgiAl();
            dbEkle();
            this.Close();

        }

        public void bilgiAl()
        {
            textBox1.Text = sirketBilgisi.tcNo;
            
            tcNo = textBox1.Text;
            calistigiBolum = comboBox1.Text;
            maas = textBox2.Text;
        }

        public void dbEkle()
        {
            SqlConnection conn = new SqlConnection("Data Source=ONURMT\\SQLSERVER; Initial Catalog=insKay; Integrated Security=True");
            //MessageBox.Show("bağlantı kuruldu");
            string ekle = "insert into tSirket values('" + tcNo + "','"+ calistigiBolum +"','"+ maas +"')";
            SqlCommand cmd = new SqlCommand(ekle, conn);
            //MessageBox.Show("ekleme cümlesi okundu");
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("ekleme yapıldı");
            conn.Close();

        }
    }
}
