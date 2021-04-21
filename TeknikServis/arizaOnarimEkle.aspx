<%@ Page Title="" Language="C#" MasterPageFile="~/anaMenu.Master" AutoEventWireup="true" CodeBehind="arizaOnarimEkle.aspx.cs" Inherits="TeknikServis.arizaOnarimEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Arızalı Ürün ID&#39;si:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="arizaFkId" runat="server"></asp:TextBox>
</p>
<p>
    Arıza Onarım TeşhisTarihi:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="onarimTeshisTar" runat="server"></asp:TextBox>
</p>
<p>
    Arıza Nedeni:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="onarimNedeni" runat="server"></asp:TextBox>
</p>
    <p>
    Arıza Onarım Tarihi:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="onarimTar" runat="server"></asp:TextBox>
</p>
<p>
    Arıza Onarım Ücreti:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="onarimUcret" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Sisteme Ekle" OnClick="Button1_Click" />
</p>
<p>
    Arızalı Ürün Onarımı ID&#39;si Veritabanı Tarafından Otomatik Verilmektedir. Arızalı Ürün Onarımı Girileceği Zaman Aırzalı Ürün D&#39;sini Elinizle Girmeniz Gerekmekte.
</p>
<p>
    Eğer Müşteri <strong>ONARIM İSTEMEZSE</strong> <em>Onarım Tarihi</em> VE <em>Onarım Ücreti Kısmı</em> <strong>&quot;-&quot;</strong> İLE <strong>DOLDURULACAK</strong>.</p>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <p>
        &nbsp;</p>
</asp:Content>
