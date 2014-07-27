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
    public partial class Egitim : Form
    {
        public Egitim()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=byn_mhnds;Database=otomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tEgitim(ogrenciNO,okulAD,fakulteAD,bolumAD,sinifNO) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.SelectedItem.ToString() + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("veriniz eklendi");
        }
    }
}
