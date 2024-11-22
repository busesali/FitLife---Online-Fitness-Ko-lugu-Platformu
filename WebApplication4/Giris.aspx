<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="WebApplication4.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Giriş Yap</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #f3f3f3;
        }

        .login-container {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            text-align: center;
        }

        input[type="text"],
        input[type="password"] {
            width: calc(100% - 20px);
            padding: 10px;
            margin-bottom: 15px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        input[type="submit"] {
            width: calc(100% - 20px);
            background-color: #333;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        input[type="submit"]:hover {
            background-color: #555;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
    <h1>Giriş Yap</h1>

    <div class="mb-3">
        E-Posta <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="mb-3">
        Şifre <asp:TextBox ID="txtSifre" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnGirisYap" runat="server" Text="Giriş Yap" CssClass="login-btn" OnClick="btnGirisYap_Click" />

        </div>
        <div>
        <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="Red"></asp:Label>

    </div>
            <div id="sifreResetForm" runat="server" style="display: none;">
    <div>
        <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" placeholder="Yeni Şifre"></asp:TextBox>
    </div>
    <div>
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" placeholder="Yeni Şifre Tekrar"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnResetPassword" runat="server" Text="Şifreyi Değiştir" OnClick="btnResetPassword_Click" />
    </div>
    <asp:Label ID="lblResetMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
</div>

<asp:Button ID="btnSifremiUnuttum" runat="server" Text="Şifremi Unuttum" OnClick="btnSifremiUnuttum_Click" />


</div>

    </form>
</body>
</html>
