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
    public partial class cvStaj : Form
    {
        public cvStaj()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=ONURMT\\SQLSERVER; Initial Catalog=insKay; Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        private void cvStaj_Load(object sender, EventArgs e)
        {
            
            cmd.CommandText = "select * from tCvStaj";
            cmd.Connection = conn;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tablo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tablo";

        }

    }
}
