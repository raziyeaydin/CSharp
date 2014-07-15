using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string key = @"http\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            string defaultbrowserpath = ((string)registryKey.GetValue(null, null)).Split('"')[1];
            Process.Start(defaultbrowserpath, "https://www.google.com.tr/");
        
        }
    }
}
