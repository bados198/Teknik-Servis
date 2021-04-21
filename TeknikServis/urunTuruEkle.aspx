<%@ Page Title="" Language="C#" MasterPageFile="~/anaMenu.Master" AutoEventWireup="true" CodeBehind="urunTuruEkle.aspx.cs" Inherits="TeknikServis.urunTuruEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Ürün Türü Adı:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Sisteme Ekle" OnClick="Button1_Click" />
</p>
<p>
    Ürün Türü ID&#39;si Veritabanı Tarafından Otomatik Verilmektedir. Model Girileceği Zaman Tür ID&#39;sini Elinizle Girmeniz Gerekmekte.</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>
