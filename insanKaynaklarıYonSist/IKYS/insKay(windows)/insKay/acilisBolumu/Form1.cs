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
    public partial class Form1 : Form
    {

        pKimlik kimlik = new pKimlik();
        pArama personelarama = new pArama();
        cv2 cv2 = new cv2();
        eArama elemanArama = new eArama();

        public Form1()
        {
            InitializeComponent();
        }

        private void kayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kimlik.Show();
        }

        private void personelAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelarama.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_personelkayıt_Click(object sender, EventArgs e)
        {
            kimlik.Show();
        }

        private void elemanAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_elemanarama_Click(object sender, EventArgs e)
        {
            elemanArama.Show();
        }

        private void btn_personelarama_Click(object sender, EventArgs e)
        {
            personelarama.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cv_Click(object sender, EventArgs e)
        {
            cv2.Show();
        }

      
    }
}
