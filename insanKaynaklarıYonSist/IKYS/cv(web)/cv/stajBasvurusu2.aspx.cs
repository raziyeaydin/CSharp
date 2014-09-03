using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace cv
{
    public partial class stajBasvurusu2 : System.Web.UI.Page
    {
        static SqlConnection conn;
        //kişisel bilgiler kısmı
        static string tcNo, ad, soyad, adres, il;
        //eğitim ve staj bilgileri kısmıü
        static string okulAd, stajTipi, sinif, calisilacakBolum;
        //iletişim bilgileri kısmı
        static string daimiAdres, sehir, telefon, eMail;

        protected void Page_Load(object sender, EventArgs e)
        {     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            veriAl();
            dbBaglan();
            dbEkle();
        }

        public void veriAl()
        {
            //kişisel bilgiler kısmı
            tcNo=txtTC.Text;
            ad=txtAd.Text;
            soyad=txtSoyad.Text;
            adres=txtIkametAdres.Text;
            il = DropDownListIkametAdres.SelectedItem.ToString();

            //eğitim ve staj bilgileri kısmı
            okulAd = txtOkulAd.Text;
            stajTipi = RadioButtonListStajTipi.SelectedValue.ToString();
            sinif = RadioButtonListSinif.SelectedValue.ToString();
            calisilacakBolum = DropDownListListBolum.SelectedItem.ToString();

            //iletişim bilgileri
            daimiAdres = txtAdres.Text;
            sehir = DropDownListSehir.SelectedItem.ToString();
            telefon = txtTel.Text;
            eMail = txtEmail.Text;
        }

        public void dbBaglan()
        {
            conn = new SqlConnection("Data Source=ONURMT\\SQLSERVER; Initial Catalog=insKay; Integrated Security=True");

        }

        public void dbEkle()
        {
            string ekle = "insert into tCvStaj values('" + tcNo + "', '" + ad + "', '" + soyad + "', '" + adres + "', '" + il + "', '" + okulAd + "', '" + stajTipi + "', '" + sinif + "', '" + calisilacakBolum + "', '" + daimiAdres + "', '" + sehir + "', '" + telefon + "', '" + eMail + "')";
            SqlCommand cmd = new SqlCommand(ekle, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}