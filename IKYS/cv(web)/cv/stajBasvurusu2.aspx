<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stajBasvurusu2.aspx.cs" Inherits="cv.stajBasvurusu2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <center>
            &nbsp;MURAT TİCARET KABLO SAN. AŞ.
        </center>
        <br />
        <center>
            STAJ BAŞVURU FORMU<br />
        </center>

        <div style="height: 189px">
            ***Kişisel Bilgiler
            <br />
            <br />
            T.C. Kimlik No :&nbsp;
            <asp:TextBox ID="txtTC" runat="server"></asp:TextBox>
            <br />
            Ad:&nbsp;
            <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
            <br />
            Soyad:&nbsp;
            <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
            <br />
            İkametgah Adresi:&nbsp;<asp:TextBox ID="txtIkametAdres" runat="server"></asp:TextBox>
            <br />
            İkametgah İli:&nbsp;
            <asp:DropDownList ID="DropDownListIkametAdres" runat="server">
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
            <br />
            <br />
            </div>

            <div>
            ***Eğitim ve Staj Bilgileri<br />
            <br />
            Okul Adı :&nbsp;
            <asp:TextBox ID="txtOkulAd" runat="server" Width="161px"></asp:TextBox>
            <br />
            Staj Tipi :<asp:RadioButtonList ID="RadioButtonListStajTipi" runat="server" Height="16px" style="margin-left: 2px" Width="355px">
                <asp:ListItem Value="Lise" Text="Lise" ></asp:ListItem>
                <asp:ListItem Value="Üniversite" Text="Üniversite"></asp:ListItem>
            </asp:RadioButtonList>
            Sınıf :<asp:RadioButtonList ID="RadioButtonListSinif" runat="server" Height="16px" style="margin-left: 2px" Width="355px">
                <asp:ListItem Value="1" Text="1. sınıf" ></asp:ListItem>
                <asp:ListItem Value="2" Text="2. Sınıf "></asp:ListItem>
                <asp:ListItem Value="3" Text="3. Sınıf"></asp:ListItem>
                <asp:ListItem Value="4" Text="4. Sınıf"></asp:ListItem>
            </asp:RadioButtonList>
            Çalışmak İstenen Bölüm :<asp:DropDownList ID="DropDownListListBolum" runat="server" Height="16px" style="margin-left: 2px" Width="355px">
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
            ***İletişim Bilgileri
            <br />
            <br />Daimi Adres:&nbsp;
            <asp:TextBox ID="txtAdres" runat="server"></asp:TextBox>
            <br />Şehir:&nbsp;
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
            <br />Telefon:&nbsp;
            <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
            <br />E-Mail:&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnStaj" runat="server" Text="Gönder" Width="98px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;Her alanın doğru şekilde doldurulması zorunludur.
        
        <br />
    
    </div>
    </form>
</body>
</html>
