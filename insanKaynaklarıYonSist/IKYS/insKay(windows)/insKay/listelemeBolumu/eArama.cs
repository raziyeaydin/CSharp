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
    public partial class eArama : Form
    {

        static string egitim, cinsiyet, bolum;

        public eArama()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=ONURMT\\SQLSERVER; Initial Catalog=insKay; Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            egitim = comboBox2.Text;
            bolum = comboBox3.Text;
            cinsiyet = comboBox1.Text;

            string sorgu = "select ad,soyad from tCvIs where calisilacakBolum='" + bolum + "' and cinsiyet='" + cinsiyet + "' and egitimDurumu='" + egitim + "'";
            
            cmd.CommandText = sorgu;
            cmd.Connection = conn;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tablo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tablo"; 

        }

       
    }
}
