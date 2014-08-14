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
    public partial class Form1 : Form
    {

        pKimlik kimlik = new pKimlik();

        public Form1()
        {
            InitializeComponent();
        }

        private void kayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kimlik.Show();
        }
    }
}
