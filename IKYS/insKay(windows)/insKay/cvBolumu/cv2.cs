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
    public partial class cv2 : Form
    {
        public cv2()
        {
            InitializeComponent();
        }

        
        cvIs cvIs = new cvIs();
        cvStaj cvStaj = new cvStaj();

        private void button1_Click(object sender, EventArgs e)
        {
            cvIs.Show();
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cvStaj.Show();
        }

        
    }
}
