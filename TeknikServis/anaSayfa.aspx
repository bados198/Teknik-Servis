<%@ Page Title="" Language="C#" MasterPageFile="~/anaMenu.Master" AutoEventWireup="true" CodeBehind="anaSayfa.aspx.cs" Inherits="TeknikServis.anaSayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    .auto-style1 {
        font-size: large;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <span class="auto-style1"><strong>SİSTEM NASIL ÇALIŞIR?<br />
        <br />
        </strong>Öncelikle azıralı gelen ürünün model ve markası kayıtlarımızda var mı yok mu kontrol edilir.
        <br />
        <br />
        Eğer yoksa Markalar kısmına Marka ismi kayıt edilir, sonra da Modeller kısmına gelinip Ürün Türü, Marka İsmi, ve Model bilgileri kaydedilir.</span></p>
    <p>
        Müşteri eğer kayıtlı değilse Müşteri Ekle&#39;den Müşteri Bilgileri ile kaydedilir.<span class="auto-style1"><br />
        <br />
        Sonra Arızalı Ürün Ekle&#39;den Modeller tablosundaki Model ID&#39;si ile kaydedilir.<br />
        <br />
        Daha sonra da arızası tespit edilip, müşteri ile iletişim kurulduktan sonra eğer müşteri onarım bedelini onaylarsa onarım sağlandıktan sonra Kargoya Veriliş, Onarım Tarihi ve Onarım Ücreti ile Onarılan Ürünler&#39;e kaydedilir.<br />
        <br />
        Eğer müşteri onarımın sağlanmasını istemiyorsa yine aynı şekilde bilgiler girilir, Onarım Tarihi ve Onarım Ücreti kısmı &quot;-&quot; ile doldurulur.<br />
        <br />
        Gerekli bilgiler girildikten sonra eğer yapılacak başka bir işlem yoksa Çıkış&#39;tan sistemden çıkılır, yeniden giriş yapılmak istendiğinde ise Login Ekranı&#39;ndan administrator şifresi ile giriş yapılır.</span></p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
</asp:Content>
