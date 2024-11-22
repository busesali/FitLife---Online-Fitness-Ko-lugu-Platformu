<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Antrenor.aspx.cs" Inherits="WebApplication4.Antrenor" Async="true" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Antrenör Profil</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f3f3f3;
            margin: 0;
            padding: 0;
        }

        .container {
    width: 20%; /* Sayfa genişliğinin yarısı kadar bir form */
    margin: 20px 0;
    background-color: #fff;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    float: left; /* Sayfanın soluna yaslanması için */
    height: 800px; /* Formun uzunluğu */
    overflow-y: auto; /* Eğer içerik formun sığmasını aşıyorsa, dikey kaydırma çubuğunu göster */
}

.profile-form {
    max-width: 800px; /* Formu daha ince yapar */
    margin: 0 auto;
}

/* Diğer stiller burada devam eder */


        h1 {
            text-align: center;
        }

        .profile-form {
            max-width: 500px;
            margin: 0 auto;
        }

        .profile-form label,
        .profile-form input {
            display: block;
            margin-bottom: 10px;
        }

        .profile-form input[type="text"],
        .profile-form input[type="email"],
        .profile-form textarea {
            width: calc(100% - 20px);
            padding: 8px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        .profile-form select {
             width: 200px; /* 200 piksel genişliğinde */
            width: calc(100% - 40px); 
            padding: 8px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        .profile-form input[type="submit"] {
            width: calc(100% - 20px);
            background-color: #333;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .profile-form input[type="submit"]:hover {
            background-color: #555;
        }
        .user-info {
    display: flex;
    align-items: center;
    justify-content: center; 
    margin-right: 20px; 
}

.user-info label {
    margin: 0;
    color: #fff;
    font-size: 22px; 
    font-weight: bold; 
    text-align: center;
    text-transform: uppercase; /* Tüm metinleri büyük harfe dönüştür */
    letter-spacing: 1px; /* Harf aralığı */
}

        .user-iletisim {
    display: flex;
    align-items: center;
    justify-content: center; /* Metehan Çelep yazısını yatayda ortalar */
    margin-right: 20px; 
}

.user-iletisim label {
    margin: 0;
    color: #fff; 
    font-size: 18px; 
    text-align: center; 
}

    </style>
    <!-- CSS dosyası -->
<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">

<!-- Bootstrap CSS dosyası -->
<link href="https://stackpath.bootstrapcdn.com/bootstrap/5.1.3/css/bootstrap.min.css" rel="stylesheet">

<!-- Bootstrap Icons CSS dosyası -->
<link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-icons/1.7.0/font/bootstrap-icons.min.css" rel="stylesheet">

</head>

<body>
    <div class="container">
        <h1>
            <i class="bi bi-person-circle"></i>
        </h1>
        <div class="user-info">
            <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label>
        </div>
        <div class="user-iletisim">
            <asp:Label ID="lblMail" runat="server" Text=""></asp:Label>
        </div>
        <div class="user-iletisim">
            <asp:Label ID="LabelTelefon" runat="server" Text=""></asp:Label>
        </div>
        <button onclick="showForm()">Bilgileri Güncelle</button>
       <form runat="server" class="profile-form" id="form1" style="display: none;">
    <label for="experience">Deneyimler</label>
    <asp:TextBox ID="txtExperience" runat="server" TextMode="MultiLine" Rows="4" CssClass="textbox-style" Placeholder="Deneyimlerinizi giriniz."></asp:TextBox>
    
    <label for="contact">Telefon Numarası</label>
    <asp:TextBox ID="txtContact" runat="server" CssClass="textbox-style" Placeholder="Telefon numarası giriniz."></asp:TextBox>
    
    <label for="mail">E-Posta</label>
    <asp:TextBox ID="txtMail" runat="server" CssClass="textbox-style" Placeholder="Mail adresinizi giriniz."></asp:TextBox>
    
    <asp:Button ID="btnGuncelle" runat="server" Text="Değiştir" CssClass="profile-form" OnClick="btnGuncelle_Click" />
</form>

    </div>
    <script>
        function showForm() {
            var form = document.getElementById('form1');
            if (form.style.display === 'none') {
                form.style.display = 'block';
            } else {
                form.style.display = 'none';
            }
        }
    </script>
</body>

</html>