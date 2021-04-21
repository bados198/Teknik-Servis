<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisEkrani.aspx.cs" Inherits="TeknikServis.girisEkranş" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Tasarımlar/girisEkrani.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <section>
            
        </section>
       
        <div class="sec2">
            <div class="container">
                <div class="content">
                    <h2>BCE Bilgisayar Teknik Servis Uygulaması</h2>
                    <asp:TextBox ID="TextBox1" placeholder="Kullanıcı Adı" runat="server"></asp:TextBox><br />
                    <asp:TextBox ID="TextBox2" placeholder="Şifre" runat="server"></asp:TextBox><br />
                    <asp:Button ID="ButtonGiris" runat="server" Text="Giriş" OnClick="ButtonGiris_Click" />
            </div>
        </div>
    </form>
</body>
</html>
