using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace mailGonderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gonderenMailAdres.Text = "";
            gonderenMailSifre.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alanMailAdres.Text = "";
            mailKonu.Text = "";
            gonderilenMesaj.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // gmail'e erişmemizi sağladı--basit mail gönderme protokolü, 587 portu çalışıyor 465 portu çalışmıyor...
                MailMessage mesaj = new MailMessage();
                mesaj.To.Add(alanMailAdres.Text);
                mesaj.From = new MailAddress(gonderenMailAdres.Text);
                mesaj.Subject = mailKonu.Text;
                mesaj.Body = gonderilenMesaj.ToString();
                NetworkCredential guvenlik = new NetworkCredential(gonderenMailAdres.Text, gonderenMailSifre.Text);
                client.Credentials = guvenlik;
                client.EnableSsl = true;
                client.Send(mesaj);
                MessageBox.Show("Mail Başarıyla Gönderildi.", "Mail Gönderme");
            }
            catch
            {
                MessageBox.Show("Mail Gönderme Başarısız.","Mail Gönderme");
            }
        }
    }
}
