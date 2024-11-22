<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SifreDegistir.aspx.cs" Inherits="WebApplication4.SifreDegistir" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Şifre Değiştirme</title>
    <style>
        /* CSS Stilleri */
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #f5f5f5;
        }

        #changePasswordForm {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 300px;
        }

        #changePasswordForm div {
            margin-bottom: 10px;
        }

        #changePasswordForm label {
            display: block;
            font-weight: bold;
        }

        #changePasswordForm input[type="text"] {
            width: calc(100% - 10px);
            padding: 5px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        #changePasswordForm .btnGuncelle {
            background-color: #333;
            color: #fff;
            padding: 8px 16px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        #changePasswordForm .btnGuncelle:hover {
            background-color: #555;
        }

        .error-message {
            color: red;
        }

        .success-message {
            color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="changePasswordForm">
            <div>
                <label for="txteskiSifre">Eski Şifre</label>
                <asp:TextBox ID="txteskiSifre" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <label for="txtSifre">Yeni Şifre</label>
                <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <label for="txttekraryenisifre">Tekrar Yeni Şifre</label>
                <asp:TextBox ID="txttekraryenisifre" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblErrorMessage" runat="server" Text="" CssClass="error-message"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblHataMessage" runat="server" Text="" CssClass="error-message"></asp:Label>
            </div>
            <div>
                <asp:Label ID="lblMessage" runat="server" Text="" CssClass="success-message"></asp:Label>
            </div>
            <asp:Button ID="btnGuncelle" runat="server" Text="Değiştir" CssClass="btnGuncelle" OnClick="btnGuncelle_Click" />
        </div>
    </form>
</body>
</html>
