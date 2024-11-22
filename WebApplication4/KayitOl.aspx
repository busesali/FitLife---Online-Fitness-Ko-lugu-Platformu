<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="WebApplication4.KayitOl" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Kayıt Ol</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #a3f0c8; /* Fitness temasına uygun yeşil tonu */
        }

        .container {
            max-width: 600px;
            margin: 20px auto;
            background-color: rgba(255, 255, 255, 0.8); /* Arka plan rengi ve opaklığı */
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }


        .window {
            width: 500px;
            height: 500px;
            margin: 0 auto;
        }

        h1 {
            text-align: center;
            margin-bottom: 20px;
        }

        .mb-3 {
            margin-bottom: 15px;
        }

        input[type="text"],
        input[type="password"] {
            width: calc(100% - 20px);
            padding: 10px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        input[type="submit"] {
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
        <div class="container">
            <h1>Kayıt Ol</h1>
            <div class="window">
                <div class="container">
                    <h1>Kayıt</h1>
                    <p>Hesap oluşturmak için lütfen formu doldurun.</p>
                    <hr>
                    <div class="mb-3">
                        Ad <asp:Literal ID="ltAdkayıt" runat="server"></asp:Literal>
                    </div>
                    <div class="mb-3">
                        Soyad <asp:Literal ID="ltsoyadkayıt" runat="server"></asp:Literal>
                    </div>
                    <div class="mb-3">
    Cinsiyet:
    <asp:DropDownList ID="ddlCinsiyet" runat="server">
        <asp:ListItem Text="Kadın" Value="Kadın" />
        <asp:ListItem Text="Erkek" Value="Erkek" />
    </asp:DropDownList>
</div>

                    <div class="mb-3">
                        E-posta <asp:Literal ID="ltEmailkayıt" runat="server"></asp:Literal>
                    </div>
                    <div class="mb-3">
                        Şifre <asp:Literal ID="ltPassword" runat="server"></asp:Literal>
                    </div>
                    <div class="mb-3">
                        Şifreyi tekrar girin <asp:Literal ID="ltRepeatPassword" runat="server"></asp:Literal>
                    </div>
                    <div class="mb-3">
                        Doğum Tarihi <asp:Literal ID="ltdogumkayıt" runat="server"></asp:Literal>
                    </div>
                    <div class="mb-3">
                        Telefon Numarası <asp:Literal ID="lttelefonkayıt" runat="server"></asp:Literal>
                    </div>
                     <div class="mb-3">
                        Hedefinizi Seçin:
                        <asp:DropDownList ID="ddlHedefler" runat="server">
                            <asp:ListItem Text="Kilo Alma" Value="Kilo Alma" />
                            <asp:ListItem Text="Kilo Verme" Value="Kilo Verme" />
                            <asp:ListItem Text="Kilo Koruma" Value="Kilo Koruma" />
                            <asp:ListItem Text="Kas Kazanma" Value="Kas Kazanma" />
                        </asp:DropDownList>
                    </div>
                    <asp:Button ID="btnKayitOl" runat="server" Text="Kayıt Ol" CssClass="kayit-btn" OnClick="btnKayitOl_Click" />
                </div>
            </div>
        </div>
    </form>
</body>

</html>
