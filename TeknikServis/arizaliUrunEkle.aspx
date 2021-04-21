<%@ Page Title="" Language="C#" MasterPageFile="~/anaMenu.Master" AutoEventWireup="true" CodeBehind="arizaliUrunEkle.aspx.cs" Inherits="TeknikServis.arizaliUrunEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Model ID&#39;si:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="modelFkId" runat="server"></asp:TextBox>
</p>
<p>
    Müşteri ID&#39;si:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="musteriFkId" runat="server"></asp:TextBox>
</p>
<p>
    Ürün Arıza Nedeni:&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="arizaNedeni" runat="server"></asp:TextBox>
</p>
<p>
    Ürün Geliş Tarihi:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="arizaGelisTar" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="Sisteme Ekle" OnClick="Button1_Click" />
</p>
<p>
    Arızalı Ürün ID&#39;si Veritabanı Tarafından Otomatik Verilmektedir. Arızalı Ürün Girileceği Zaman Model ID&#39;si ve Müşteri ID&#39;sini Elinizle Girmeniz Gerekmekte.</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>
