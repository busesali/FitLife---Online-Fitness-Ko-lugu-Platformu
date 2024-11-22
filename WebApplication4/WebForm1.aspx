<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Fitness Website</title>
  <style>
    /* Reset CSS */
    * {
      margin: 0;
      padding: 0;
      box-sizing: border-box;
    }

    /* Genel stiller */
    body {
      font-family: Arial, sans-serif;
      line-height: 1.6;
    }

    header {
      background-color: #333;
      color: #fff;
      padding: 1rem;
    }

    nav ul {
      list-style: none;
    }

    nav ul li {
      display: inline;
      margin-right: 20px;
    }

    nav ul li a {
      color: #fff;
      text-decoration: none;
    }

    main {
      padding: 20px;
    }

    .hero {
      text-align: center;
      padding: 50px 0;
      background-color: #f4f4f4;
    }

    .hero h1 {
      font-size: 2.5em;
      margin-bottom: 20px;
    }

    .cta-button {
      display: inline-block;
      padding: 10px 20px;
      background-color: #333;
      color: #fff;
      text-decoration: none;
      border-radius: 5px;
      transition: background-color 0.3s ease;
    }

    .cta-button:hover {
      background-color: #555;
    }

    .services {
      text-align: center; /* Antrenörlerin bulunduğu bölümü ortalar */
      margin-top: 50px; /* Başlık ile içerik arasındaki boşluğu ayarlar */
    }

      .services-title {
          font-size: 2em;
          margin-bottom: 20px;
      }
    .service {
      text-align: center;
width: 40%; /* Bir antrenör kutusunun genişliği */
margin-bottom: 20px;
display: inline-block;
    }

    .service img {
      width: 100%;
      border-radius: 50%;
margin-bottom: 10px;
    }

    .about {
      text-align: center;
      padding: 50px 0;
      background-color: #f4f4f4;
    }

    .coaches {
      text-align: center; /* Antrenörlerin bulunduğu bölümü ortalar */
      margin-top: 50px; /* Başlık ile içerik arasındaki boşluğu ayarlar */
    }
    
    .section-divider {
      text-align: center;
      margin: 50px 0; /* Bölümler arasındaki boşluğu ayarlar */
    }

    .section-divider hr {
      width: 50%; /* Çizgi uzunluğunu ayarlar */
      border: 1px solid #ccc; /* Çizgi rengi ve kalınlığı */
      margin: 20px auto; /* Çizgi etrafındaki boşluğu ayarlar */
    }

    .services-title {
      font-size: 2em;
      margin-bottom: 20px;
    }

    .coach {
      text-align: center;
      width: 30%; /* Bir antrenör kutusunun genişliği */
      margin-bottom: 20px;
      display: inline-block;
    }

      .coach img {
          width: 100%;
          border-radius: 50%;
          margin-bottom: 10px;
      }

  </style>
</head>
<body>
  <header>
    <nav>
      <ul>
        <li><a href="#">Anasayfa</a></li>
        <li><a href="#">Hakkımızda</a></li>
        <li><a href="#">Hizmetler</a></li>
        <li><a href="#">Eğitmenler</a></li>
        <li><a href="#">İletişim</a></li>
        <li style="float:right"><a href="Giris.aspx">Giriş Yap</a></li>
      </ul>
    </nav>
  </header>

  <main>

    <section class="hero">
      <h1>Fit Olmak Hiç Bu Kadar Kolay Olmamıştı!</h1>
      <p>En iyi eğitmenlerle birlikte sağlıklı bir yaşama adım atın.</p>
      <a href="KayitOl.aspx" class="cta-button" id="KayitOlButton" >Hemen Kaydol</a>
    </section>

   <section class="about">
  <h2>Hakkımızda</h2>
  <p>FitLife, sağlıklı bir yaşam tarzı benimseyen herkes için fitness hizmetleri sunar. Profesyonel eğitmenlerimizle birlikte, sizlere en iyi hizmeti sunmayı amaçlıyoruz.</p>
 </section>

           


        <section class="section-divider">
  <h2 class="services-title">Hizmetlerimiz</h2>
  <hr> <!-- Çizgiyi ekler -->
</section>

    <section class="services">

      <div class="service">
        <h3>Antrenman Programları</h3>
        <p>Kişiye özel antrenman programları oluşturarak hedefinize en kısa sürede ulaşmanızı sağlıyoruz.</p>
      </div>
      <div class="service">
        <h3>Beslenme Programları</h3>
        <p>Vücudun ihtiyacı olan doğru besinleri belirleyerek kişiye özel beslenme programı oluşturuyoruz.</p>
      </div>
      <!-- Diğer hizmetler buraya eklenebilir -->
    </section>


  </main>

  <footer>
    <p>&copy; 2023 FitnessWebsite. Tüm hakları saklıdır.</p>
  </footer>
</body>
</html>
