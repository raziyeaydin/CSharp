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

namespace yOtomasyon
{
    public partial class kimlik_bilgisi : Form
    {
        public kimlik_bilgisi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=byn_mhnds;Database=otomasyon;Integrated Security=True");
        private void kimlik_bilgisi_Load(object sender, EventArgs e)
        {

        }

        Egitim egitim = new Egitim();
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("insert into tKimlik(TC,AD,SOYAD,CINSIYET,DOGUM_TARIHI,UYRUK,ANNE_AD,BABA_AD,DOGUM_YERI,KAN_GRUBU,MEDENI_HALI,DINI,SON_GECERLILIK_TARIHI,SERI_NO) values('"+textBox4.Text +"','"+textBox2.Text +"','"+textBox1.Text +"','"+comboBox1.SelectedItem.ToString() +"','"+dateTimePicker1.Text +"','"+textBox8.Text +"','"+textBox5.Text +"','"+textBox6.Text +"','"+textBox7.Text +"','"+comboBox2.SelectedItem.ToString() + "','" + comboBox3.SelectedItem.ToString() + "','" + comboBox4.SelectedItem.ToString() + "','" + dateTimePicker2.Text + "','" + textBox3.Text + "')", con);
            
            con.Open();
            
            DateTime tarih1, tarih2 ;
            tarih1 = Convert.ToDateTime(dateTimePicker1.Text);
            dateTimePicker1.Text = tarih1.ToShortDateString();

            tarih2 = Convert.ToDateTime(dateTimePicker2.Text);
            dateTimePicker2.Text = tarih2.ToShortDateString();


            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("veriniz eklendi");

            egitim.Show();
        
        }
    }
}
