<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profilduzenle.aspx.cs" Inherits="WebApplication4.Profilduzenle" Async="true" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Profil Düzenle</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 50%;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 8px;
            background-color: #f9f9f9;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-group label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .form-group input[type="text"] {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .form-group input[type="submit"] {
            padding: 10px;
            border: none;
            border-radius: 5px;
            background-color: #007bff;
            color: #fff;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .form-group input[type="submit"]:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <div class="container">
        <h2>Profil Düzenle</h2>
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="txtAd">Ad:</label>
                <asp:TextBox ID="txtAd" runat="server" placeholder="Adınızı girin"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtSoyad">Soyad:</label>
                <asp:TextBox ID="txtSoyad" runat="server" placeholder="Soyadınızı girin"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtEmail">E-Posta:</label>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="E-postanızı girin"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtTelefon">Telefon:</label>
                <asp:TextBox ID="txtTelefon" runat="server" placeholder="Telefon numaranızı girin"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtDogumTarihi">Doğum Tarihi:</label>
                <asp:TextBox ID="txtDogumTarihi" runat="server" placeholder="Doğum tarihinizi girin"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtKullaniciid"></label>
                <asp:TextBox ID="txtKullaniciid" runat="server" ></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtKullaniciHedefleri"></label>
                <asp:TextBox ID="txttxtKullaniciHedefleri" runat="server" ></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
            </div>
        </form>
    </div>
</body>
</html>
