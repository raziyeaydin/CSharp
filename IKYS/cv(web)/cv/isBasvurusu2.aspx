<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="isBasvurusu2.aspx.cs" Inherits="cv.isBasvurusu2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        MURAT TİCARET KABLO SAN. AŞ.
        </center>
        <br />
        <center>
        İŞ BAŞVURU FORMU<br />
        </center>
        <div style="height: 250px">
            Kişisel Bilgiler
            <br />
            TC No:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="128px"></asp:TextBox>
            <br />
            Ad:&nbsp;
            <asp:TextBox ID="txtAd" runat="server" Width="128px"></asp:TextBox>
            <br />
            Soyad:&nbsp;
            <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
            <br />
            Dogum Tarihi:&nbsp; 
            <asp:TextBox ID="txtDogumTar" runat="server" ></asp:TextBox>
            <br />
            Doğum Yeri:&nbsp;
            <asp:DropDownList ID="DropDownListDogumYer" runat="server">
                <asp:ListItem>Adana</asp:ListItem>
                        <asp:ListItem>Adıyaman</asp:ListItem>
                        <asp:ListItem>Afyon</asp:ListItem>
                        <asp:ListItem>Ağrı</asp:ListItem>
                        <asp:ListItem>Amasya</asp:ListItem>
                        <asp:ListItem>Ankara</asp:ListItem>
                        <asp:ListItem>Antalya</asp:ListItem>
                        <asp:ListItem>Artvin</asp:ListItem>
                        <asp:ListItem>Aydın</asp:ListItem>
                        <asp:ListItem>Balıkesir</asp:ListItem>
                        <asp:ListItem>Bilecik</asp:ListItem>
                        <asp:ListItem>Bingöl</asp:ListItem>
                        <asp:ListItem>Bitlis</asp:ListItem>
                        <asp:ListItem>Bolu</asp:ListItem>
                        <asp:ListItem>Burdur</asp:ListItem>
                        <asp:ListItem>Bursa</asp:ListItem>
                        <asp:ListItem>Çanakkale</asp:ListItem>
                        <asp:ListItem>Çankırı</asp:ListItem>
                        <asp:ListItem>Çorum</asp:ListItem>
                        <asp:ListItem>Denizli</asp:ListItem>
                        <asp:ListItem>Diyarbakır</asp:ListItem>
                        <asp:ListItem>Edirne</asp:ListItem>
                        <asp:ListItem>Elazığ</asp:ListItem>
                        <asp:ListItem>Erzincan</asp:ListItem>
                        <asp:ListItem>Erzurum</asp:ListItem>
                        <asp:ListItem>Eskişehir</asp:ListItem>
                        <asp:ListItem>Gaziantep</asp:ListItem>
                        <asp:ListItem>Giresun</asp:ListItem>
                        <asp:ListItem>Gümüşhane</asp:ListItem>
                        <asp:ListItem>Hakkari</asp:ListItem>
                        <asp:ListItem>Hatay</asp:ListItem>
                        <asp:ListItem>Isparta</asp:ListItem>
                        <asp:ListItem>İçel(Mersin)</asp:ListItem>
                        <asp:ListItem>İstanbul</asp:ListItem>
                        <asp:ListItem>İzmir</asp:ListItem>
                        <asp:ListItem>Kars</asp:ListItem>
                        <asp:ListItem>Kastamonu</asp:ListItem>
                        <asp:ListItem>Kayseri</asp:ListItem>
                        <asp:ListItem>Kırklareli</asp:ListItem>
                        <asp:ListItem>Kırşehir</asp:ListItem>
                        <asp:ListItem>Kocaeli</asp:ListItem>
                        <asp:ListItem>Konya</asp:ListItem>
                        <asp:ListItem>Kütahya</asp:ListItem>
                        <asp:ListItem>Malatya</asp:ListItem>
                        <asp:ListItem>Manisa</asp:ListItem>
                        <asp:ListItem>Kahramanmaraş</asp:ListItem>
                        <asp:ListItem>Mardin</asp:ListItem>
                        <asp:ListItem>Muğla</asp:ListItem>
                        <asp:ListItem>Muş</asp:ListItem>
                        <asp:ListItem>Nevşehir</asp:ListItem>
                        <asp:ListItem>Niğde</asp:ListItem>
                        <asp:ListItem>Ordu</asp:ListItem>
                        <asp:ListItem>Rize</asp:ListItem>
                        <asp:ListItem>Sakarya</asp:ListItem>
                        <asp:ListItem>Samsun</asp:ListItem>
                        <asp:ListItem>Siirt</asp:ListItem>
                        <asp:ListItem>Sinop</asp:ListItem>
                        <asp:ListItem>Sivas</asp:ListItem>
                        <asp:ListItem>Tekirdağ</asp:ListItem>
                        <asp:ListItem>Tokat</asp:ListItem>
                        <asp:ListItem>Trabzon</asp:ListItem>
                        <asp:ListItem>Tunceli</asp:ListItem>
                        <asp:ListItem>Şanlıurfa</asp:ListItem>
                        <asp:ListItem>Uşak</asp:ListItem>
                        <asp:ListItem>Van</asp:ListItem>
                        <asp:ListItem>Yozgat</asp:ListItem>
                        <asp:ListItem>Zonguldak</asp:ListItem>
                        <asp:ListItem>Aksaray</asp:ListItem>
                        <asp:ListItem>Bayburt</asp:ListItem>
                        <asp:ListItem>Karaman</asp:ListItem>
                        <asp:ListItem>Kırıkkale</asp:ListItem>
                        <asp:ListItem>Batman</asp:ListItem>
                        <asp:ListItem>Şırnak</asp:ListItem>
                        <asp:ListItem>Bartın</asp:ListItem>
                        <asp:ListItem>Ardahan</asp:ListItem>
                        <asp:ListItem>Iğdır</asp:ListItem>
                        <asp:ListItem>Yalova</asp:ListItem>
                        <asp:ListItem>Karabük</asp:ListItem>
                        <asp:ListItem>Kilis</asp:ListItem>
                        <asp:ListItem>Osmaniye</asp:ListItem>
                        <asp:ListItem>Düzce</asp:ListItem>   
            </asp:DropDownList>
            <br />
            Uyruk:&nbsp;
            <asp:TextBox ID="txtUyruk" runat="server"></asp:TextBox>
            <br />
            Cinsiyet:&nbsp; 
            <asp:DropDownList ID="DropDownListCins" runat="server" Height="16px" Width="84px">
                <asp:ListItem>   </asp:ListItem>
                <asp:ListItem>Bay</asp:ListItem>
                <asp:ListItem>Bayan</asp:ListItem>
            </asp:DropDownList>
            <br />
            Medeni Durum:&nbsp;
            <asp:DropDownList ID="DropDownListMedeni" runat="server" Height="16px" Width="74px">
                <asp:ListItem>  </asp:ListItem>
                <asp:ListItem>Bekar</asp:ListItem>
                <asp:ListItem>Evli</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
        </div>
            <div style="height: 131px">
                İletişim Bilgileri
                <br />
                Açık Adres:&nbsp;
                    <asp:TextBox ID="txtAdres" runat="server" Width="179px"></asp:TextBox>
                <br />
                Şehir:&nbsp;
                    <asp:DropDownList ID="DropDownListSehir" runat="server">
                        <asp:ListItem>Adana</asp:ListItem>
                        <asp:ListItem>Adıyaman</asp:ListItem>
                        <asp:ListItem>Afyon</asp:ListItem>
                        <asp:ListItem>Ağrı</asp:ListItem>
                        <asp:ListItem>Amasya</asp:ListItem>
                        <asp:ListItem>Ankara</asp:ListItem>
                        <asp:ListItem>Antalya</asp:ListItem>
                        <asp:ListItem>Artvin</asp:ListItem>
                        <asp:ListItem>Aydın</asp:ListItem>
                        <asp:ListItem>Balıkesir</asp:ListItem>
                        <asp:ListItem>Bilecik</asp:ListItem>
                        <asp:ListItem>Bingöl</asp:ListItem>
                        <asp:ListItem>Bitlis</asp:ListItem>
                        <asp:ListItem>Bolu</asp:ListItem>
                        <asp:ListItem>Burdur</asp:ListItem>
                        <asp:ListItem>Bursa</asp:ListItem>
                        <asp:ListItem>Çanakkale</asp:ListItem>
                        <asp:ListItem>Çankırı</asp:ListItem>
                        <asp:ListItem>Çorum</asp:ListItem>
                        <asp:ListItem>Denizli</asp:ListItem>
                        <asp:ListItem>Diyarbakır</asp:ListItem>
                        <asp:ListItem>Edirne</asp:ListItem>
                        <asp:ListItem>Elazığ</asp:ListItem>
                        <asp:ListItem>Erzincan</asp:ListItem>
                        <asp:ListItem>Erzurum</asp:ListItem>
                        <asp:ListItem>Eskişehir</asp:ListItem>
                        <asp:ListItem>Gaziantep</asp:ListItem>
                        <asp:ListItem>Giresun</asp:ListItem>
                        <asp:ListItem>Gümüşhane</asp:ListItem>
                        <asp:ListItem>Hakkari</asp:ListItem>
                        <asp:ListItem>Hatay</asp:ListItem>
                        <asp:ListItem>Isparta</asp:ListItem>
                        <asp:ListItem>İçel(Mersin)</asp:ListItem>
                        <asp:ListItem>İstanbul</asp:ListItem>
                        <asp:ListItem>İzmir</asp:ListItem>
                        <asp:ListItem>Kars</asp:ListItem>
                        <asp:ListItem>Kastamonu</asp:ListItem>
                        <asp:ListItem>Kayseri</asp:ListItem>
                        <asp:ListItem>Kırklareli</asp:ListItem>
                        <asp:ListItem>Kırşehir</asp:ListItem>
                        <asp:ListItem>Kocaeli</asp:ListItem>
                        <asp:ListItem>Konya</asp:ListItem>
                        <asp:ListItem>Kütahya</asp:ListItem>
                        <asp:ListItem>Malatya</asp:ListItem>
                        <asp:ListItem>Manisa</asp:ListItem>
                        <asp:ListItem>Kahramanmaraş</asp:ListItem>
                        <asp:ListItem>Mardin</asp:ListItem>
                        <asp:ListItem>Muğla</asp:ListItem>
                        <asp:ListItem>Muş</asp:ListItem>
                        <asp:ListItem>Nevşehir</asp:ListItem>
                        <asp:ListItem>Niğde</asp:ListItem>
                        <asp:ListItem>Ordu</asp:ListItem>
                        <asp:ListItem>Rize</asp:ListItem>
                        <asp:ListItem>Sakarya</asp:ListItem>
                        <asp:ListItem>Samsun</asp:ListItem>
                        <asp:ListItem>Siirt</asp:ListItem>
                        <asp:ListItem>Sinop</asp:ListItem>
                        <asp:ListItem>Sivas</asp:ListItem>
                        <asp:ListItem>Tekirdağ</asp:ListItem>
                        <asp:ListItem>Tokat</asp:ListItem>
                        <asp:ListItem>Trabzon</asp:ListItem>
                        <asp:ListItem>Tunceli</asp:ListItem>
                        <asp:ListItem>Şanlıurfa</asp:ListItem>
                        <asp:ListItem>Uşak</asp:ListItem>
                        <asp:ListItem>Van</asp:ListItem>
                        <asp:ListItem>Yozgat</asp:ListItem>
                        <asp:ListItem>Zonguldak</asp:ListItem>
                        <asp:ListItem>Aksaray</asp:ListItem>
                        <asp:ListItem>Bayburt</asp:ListItem>
                        <asp:ListItem>Karaman</asp:ListItem>
                        <asp:ListItem>Kırıkkale</asp:ListItem>
                        <asp:ListItem>Batman</asp:ListItem>
                        <asp:ListItem>Şırnak</asp:ListItem>
                        <asp:ListItem>Bartın</asp:ListItem>
                        <asp:ListItem>Ardahan</asp:ListItem>
                        <asp:ListItem>Iğdır</asp:ListItem>
                        <asp:ListItem>Yalova</asp:ListItem>
                        <asp:ListItem>Karabük</asp:ListItem>
                        <asp:ListItem>Kilis</asp:ListItem>
                        <asp:ListItem>Osmaniye</asp:ListItem>
                        <asp:ListItem>Düzce</asp:ListItem>                          
                    </asp:DropDownList>
                <br />
                Telefon:&nbsp;
                <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
                <br />
                E-Mail:&nbsp;
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <br />
                <br />
            </div>
                Eğitim Bilgileri
                <br />
            <br />
            Eğitim Durumu:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Seçiniz</asp:ListItem>
            <asp:ListItem>Lise</asp:ListItem>
            <asp:ListItem Value="Önlisans">Önlisans</asp:ListItem>
            <asp:ListItem>Lisans</asp:ListItem>
            <asp:ListItem>Yüksek Lisans</asp:ListItem>
        </asp:DropDownList>
&nbsp;<br />
            Okul Adı :&nbsp;
            <asp:TextBox ID="txtOkulAd" runat="server" Width="161px"></asp:TextBox>
            <br />
        Bölüm Adı: <asp:TextBox ID="TextBox2" runat="server" Width="164px"></asp:TextBox>
        <br />
        Not Ortalaması:
        <asp:TextBox ID="TextBox3" runat="server" Width="100px"></asp:TextBox>
        <br />
        Başlangıç Tarihi(gg/aa/yy):
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        Bitiş Tarihi(gg/aa/yy):
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        Yabancı Dil: <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        Seviye:
        <asp:TextBox ID="TextBox5" runat="server" Width="135px"></asp:TextBox>
        <br />
        <br />
        <br />
        Çalışmak İstediğiniz Bölüm :<asp:DropDownList ID="DropDownListListBolum" runat="server" Height="16px" style="margin-left: 2px" Width="355px">
                <asp:ListItem Text ="Lütfen Seçiniz"></asp:ListItem>
                <asp:ListItem Text ="Satış Ve Pazarlama"></asp:ListItem>
                <asp:ListItem Text ="Muhasebe"></asp:ListItem>
                <asp:ListItem Text ="Finans"></asp:ListItem>
                <asp:ListItem Text ="Dış Ticaret"></asp:ListItem>
                <asp:ListItem Text ="Satın Alma"></asp:ListItem>
                <asp:ListItem Text ="Bilgi İşlem"></asp:ListItem>
                <asp:ListItem Text ="İnsan Kaynakları"></asp:ListItem>
                <asp:ListItem Text ="Mühendislik"></asp:ListItem>
                <asp:ListItem Text ="Kalite Kontrol"></asp:ListItem>
                <asp:ListItem Text ="Üretim"></asp:ListItem>
                <asp:ListItem Text ="Araştırma-Geliştirme"></asp:ListItem>
                <asp:ListItem Text ="Bakım"></asp:ListItem>
                <asp:ListItem Text ="Sistem Geliştirme"></asp:ListItem>
                <asp:ListItem Text ="Bayilik"></asp:ListItem>
            </asp:DropDownList>
                <br />
                <br />
            </div>
        <div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnIs" runat="server" OnClick="Button1_Click" Text="Gönder" Width="83px" style="height: 26px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Her alanın doğru şekilde doldurulması zorunludur.
        <br />
        <br />
    </div>
    </form>
</body>
</html>
