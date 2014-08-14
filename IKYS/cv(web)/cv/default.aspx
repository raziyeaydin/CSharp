<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="cv._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>deneme</title>
</head>
<body style=" background:#000000; color:#ffffff; font-family: Arial;">
    <form id="form1" runat="server">
   
            
    <div style="height:500px; width:600px; margin: 0 auto; background:#000000 url(bg.png) no-repeat center;">
    
       <div style="margin:30px 0px 30px 110px; float:left;"><h1 style="font-size:16px;">McEaglr's İNSAN KAYNAKLARI YÖNETİM SİSTEMİ</h1></div>
       <div class="clear"></div>
       <div style="margin:30px 0px 30px 44px; float:left;"> 
           
           <asp:Button ID="btnIs" runat="server" BackColor="#99CCFF" BorderStyle="Solid" Height="58px" Text="İş Başvurusu" Width="256px" OnClick="btnIs_Click" />
        
        <asp:Button ID="btnStaj" runat="server" BackColor="#99CCFF" BorderStyle="Solid" Height="58px" Text="Staj Başvurusu" Width="256px" OnClick="btnStaj_Click" />
       </div>
       <p style="margin:210px 0px 30px 210px; font-size:11px; float:left;">© McEaglr's İnsan Kaynakları Yönetim Sistemi</p> 
       
    </div>
      
           
    </form>
</body>
</html>
