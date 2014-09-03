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
    public partial class pArama : Form
    {
        public pArama()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=ONURMT\\SQLSERVER; Initial Catalog=insKay; Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        
        static string egitimDurumu, cinsiyet;
        
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
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

            cinsiyet = comboBox1.Text;


            

            string bolum = comboBolum.Text;



            string sorgu = "SELECT tKimlik.ad,tKimlik.soyad,tKimlik.medeniHali,tEgitim.sehir,tEgitim.telefon,tEgitim.egitimDurumu FROM tKimlik INNER JOIN tEgitim ON tKimlik.tcNo=tEgitim.tcNo INNER JOIN tSirket ON tEgitim.tcNo = tSirket.tcNo WHERE tEgitim.egitimDurumu='" + egitimDurumu + "' AND tKimlik.cinsiyet='" + cinsiyet + "' AND tSirket.calistigiBolum='" + bolum + "' ";
            
            cmd.CommandText = sorgu;
            cmd.Connection = conn;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tablo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tablo"; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void eArama_Load(object sender, EventArgs e)
        {
            
            
            
        }

        
    }
}
