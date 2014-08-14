using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace cv
{
    public partial class isBasvurusu2 : System.Web.UI.Page
    {

        static SqlConnection conn;
        //kişisel bilgiler kısmı
        static string tcNo, ad, soyad, dogTar, dogYer, uyruk, cinsiyet, medeniDurum;
        //iletişim bilgileri kısmı
        static string adres, il, telefon, eMail;
        //eğitim bilgileri kısmı
        static string egitimDurumu, okulAdi, bolumAdi, notOrt, baslangicTarih, bitisTarih, yabanciDil, dilSeviye, calisilacakBolum;
       

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
            tcNo = TextBox1.Text;
            ad= txtAd.Text;
            soyad= txtSoyad.Text;
            dogTar=txtDogumTar.Text;
            dogYer = DropDownListDogumYer.SelectedItem.ToString();
            uyruk=txtUyruk.Text;
            cinsiyet = DropDownListCins.SelectedItem.ToString();
            medeniDurum = DropDownListMedeni.SelectedItem.ToString();

            //iletişim bilgileri kısmı
            adres= txtAdres.Text;
            il=DropDownListSehir.SelectedItem.ToString();
            telefon=txtTel.Text;
            eMail = txtEmail.Text;

            //eğitim bilgileri kısmı
            egitimDurumu = DropDownList1.SelectedItem.ToString();
            okulAdi= txtOkulAd.Text;
            bolumAdi=TextBox2.Text;
            notOrt=TextBox3.Text;
            baslangicTarih=TextBox6.Text;
            bitisTarih= TextBox7.Text;
            yabanciDil=TextBox4.Text;
            dilSeviye=TextBox5.Text;
            calisilacakBolum = DropDownListListBolum.SelectedItem.ToString();
        }

        public void dbBaglan()
        {
            conn = new SqlConnection("Data Source=CENG\\BYNMHNDS; Initial Catalog=insKay; Integrated Security=True");
            
        }

        public void dbEkle()
        {
            string ekle = "insert into tCvIs values('" + tcNo + "', '" + ad + "', '" + soyad + "', '" + dogTar + "', '" + dogYer + "', '" + uyruk + "', '" + cinsiyet + "', '" + medeniDurum + "', '" + adres + "', '" + il + "', '" + telefon + "', '" + eMail + "', '" + egitimDurumu + "', '" + okulAdi + "', '" + bolumAdi + "', '" + notOrt + "', '" + baslangicTarih + "', '" + bitisTarih + "', '" + yabanciDil + "', '" + dilSeviye + "', '" + calisilacakBolum + "')";
            SqlCommand cmd = new SqlCommand(ekle, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}