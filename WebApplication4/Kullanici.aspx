

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kullanici.aspx.cs" Inherits="WebApplication4.Kullanici" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Bootstrap CSS -->
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">

    <!-- Bootstrap Icons -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons/font/bootstrap-icons.css" rel="stylesheet">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Danışan Sayfası</title>
    <style>
        /* CSS Stilleri */
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }

        header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            background-color: #333;
            color: #fff;
            padding: 10px;
        }

        .bi-person-gear {
            font-size: 30px;
            color: white;
            margin-right: 10px;
        }

        h1 {
            margin: 0;
            text-align: center;
            flex: 1; /* Yeni eklenen özellik */
        }

        nav ul {
            list-style: none;
            padding: 0;
            margin: 0;
            display: flex;
            justify-content: space-around;
            background-color: #f0f0f0;
            border-radius: 5px;
        }

        nav ul li {
            display: inline;
        }

        nav ul li a {
            display: block;
            padding: 10px 20px;
            text-decoration: none;
            color: #333;
            font-weight: bold;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        nav ul li a:hover {
            background-color: #ddd;
        }

        main {
            padding: 20px;
        }

        .egzersiz-planlari,
        .beslenme-programlari,
        .ilerleme {
            border: 1px solid #ccc;
            padding: 10px;
            margin-bottom: 20px;
        }
    #lblWelcomeMessage {
        font-size: 2em;
        text-align: center;
        margin-top: 50px; /* İstediğiniz boşluğu ayarlayabilirsiniz */
    }
    .user-info {
        display: flex;
        align-items: center;
        margin-right: 20px; /* İstediğiniz boşluğu ayarlayabilirsiniz */
    }

    .user-info label {
        margin: 0;
        color: #fff; /* İstediğiniz renk */
        font-size: 18px; /* İstediğiniz boyut */
    }
           .form-group {
            text-align: center;
            margin-bottom: 20px;
        }

        
        .form-group select {
    width: 25%;
    font-size: 1.5em;
    text-align-last: center; /* ComboBox içeriğinin merkezde görünmesini sağlar */
    appearance: none; /* Default dropdown stilini kaldırır */
    -moz-appearance: none;
    -webkit-appearance: none;
    padding: 5px; /* ComboBox içeriğinin daha geniş olmasını sağlar */
}
</style>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.bundle.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <header>
        <h1>FitLife - Danışan Sayfası</h1>
        <div class="user-info">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
        <div class="dropdown">
            <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                <i class="bi bi-person-gear"></i>
            </button>
            <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                <a class="dropdown-item" href="Profilduzenle.aspx" >Kullanıcı Bilgilerini Düzenle</a>
                 <a class="dropdown-item" href="SifreDegistir.aspx">Şifreyi Değiştir</a>
            </div>
            
        </div>
    </header>

    <nav>
        <ul>
            <li><a href="#egzersizler">Egzersiz Planları</a></li>
            <li><a href="#beslenme">Beslenme Programları</a></li>
            <li><a href="#ilerleme">İlerleme Kayıtları</a></li>
        </ul>
    </nav>
    <main>
        <div>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</div>
        <div class="form-group">
       <div>
                <h2>Antrenörler</h2>
                <asp:DropDownList ID="ddlAntrenorler" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAntrenorler_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
             </div>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>


        
    
        </form>
        <section id="egzersizler" class="egzersiz-planlari">
        <h2>Egzersiz Planları</h2>
      
        
    </section>
    <section id="beslenme" class="beslenme-programlari">
        <h2>Beslenme Programları</h2>
      
        
    </section>
    <section id="ilerleme" class="ilerleme">
        <h2>İlerleme Kayıtları</h2>
      
        <div> <asp:Label ID="lblWelcomeMessage" runat="server" Text=""></asp:Label> </div>
    </section>
</main>
</body>
</html>







































