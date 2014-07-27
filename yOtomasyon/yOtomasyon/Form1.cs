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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=byn_mhnds;Database=otomasyon;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        kimlik_bilgisi kb = new kimlik_bilgisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tYurt(blokAD,katNO,odaNO,yatakNO,odaTEL) values('"+comboBox1.SelectedItem.ToString() +"','"+comboBox2.SelectedItem.ToString() +"','"+comboBox3.SelectedItem.ToString() +"','"+comboBox4.SelectedItem.ToString() +"','"+textBox1.Text +"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("veriniz eklendi");

           /*
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox1.Text = "";
           */

            kb.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
