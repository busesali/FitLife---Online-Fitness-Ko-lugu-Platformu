using System;
using System.Collections.Generic;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WebApplication4
{
    public partial class Giris : System.Web.UI.Page
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "dWa02vmBpMFhNY1iXel4ReTZRdJedZklY2QVxXvr",
            BasePath = "https://proje2-25a28-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciEmail = txtEmail.Text;
            string kullaniciSifre = txtSifre.Text;

            FirebaseResponse response = client.GetAsync("kullanicilar").Result;
            FirebaseResponse response1 = client.GetAsync("antrenorler").Result;

            if (response.Body != "null" && response1.Body != "null")
            {
                var uKullanicilar = response.ResultAs<Newtonsoft.Json.Linq.JObject>();
                var uAntrenorler = response1.ResultAs<Newtonsoft.Json.Linq.JObject>();

                bool girisBasarili = false;
                bool kullaniciGirisi = false;

                foreach (var user in uKullanicilar)
                {
                    var kullanicibilgisi = user.Value as Newtonsoft.Json.Linq.JObject;


                    if (kullanicibilgisi != null)
                    {
                        string userEmail = kullanicibilgisi["Email"]?.ToString();
                        string userSifre = kullanicibilgisi["Sifre"]?.ToString();

                        if (!string.IsNullOrEmpty(userEmail) && !string.IsNullOrEmpty(userSifre))
                        {
                            if (kullaniciEmail == userEmail && kullaniciSifre == userSifre)
                            {
                                string adSoyad = kullanicibilgisi["Ad"]?.ToString() + " " + kullanicibilgisi["Soyad"]?.ToString();
                                string sifre = kullanicibilgisi["Sifre"]?.ToString();
                                string tekrarsifre = kullanicibilgisi["Tekrarsifre"]?.ToString();
                                string email = kullanicibilgisi["Email"]?.ToString();
                                string telefon = kullanicibilgisi["Telefon"]?.ToString();
                                string ad = kullanicibilgisi["Ad"]?.ToString();
                                string soyad = kullanicibilgisi["Soyad"]?.ToString();
                                string id = kullanicibilgisi["KullaniciId"]?.ToString();
                                string dogumtarihi = kullanicibilgisi["Dogumtarihi"]?.ToString();
                                string kullanicihedefleri = kullanicibilgisi["SecilenHedef"]?.ToString();
                                string cinsiyet = kullanicibilgisi["Cinsiyet"]?.ToString();

                                Session["AdSoyad"] = adSoyad; // Oturum değişkenine ad ve soyadı kaydet
                                Session["Ad"] = ad; // Oturum değişkenine ad ve soyadı kaydet
                                Session["Soyad"] = soyad; // Oturum değişkenine ad ve soyadı kaydet
                                Session["Sifre"] = sifre; // Oturum değişkenine ad ve soyadı kaydet
                                Session["Tekrarsifre"] = tekrarsifre; // Oturum değişkenine ad ve soyadı kaydet
                                Session["Email"] = email; // Oturum değişkenine ad ve soyadı kaydet
                                Session["Telefon"] = telefon; // Oturum değişkenine ad ve soyadı kaydet
                                Session["KullaniciId"] = id; // Oturum değişkenine ad ve soyadı kaydet
                                Session["Dogumtarihi"] = dogumtarihi; // Oturum değişkenine ad ve soyadı kaydet
                                Session["SecilenHedef"] = kullanicihedefleri; // Oturum değişkenine ad ve soyadı kaydet
                                Session["Cinsiyet"] = cinsiyet; // Oturum değişkenine ad ve soyadı kaydet







                                string queryString = $"name={adSoyad}";

                                Response.Redirect($"Kullanici.aspx?{queryString}");

                                kullaniciGirisi = true;
                                girisBasarili = true;
                                break;
                            }
                        }
                    }
                }
                if (kullaniciGirisi)
                {
                    CompareAndUpdateAntrenor();
                    Response.Redirect("Kullanici.aspx");                    
                }
                else
                {
                    foreach (var user in uAntrenorler)
                    {
                        var antrenorbilgisi = user.Value as Newtonsoft.Json.Linq.JObject;

                        if (antrenorbilgisi != null)
                        {
                            string userEmail = antrenorbilgisi["Email"]?.ToString();
                            string userSifre = antrenorbilgisi["Sifre"]?.ToString();

                            if (!string.IsNullOrEmpty(userEmail) && !string.IsNullOrEmpty(userSifre))
                            {
                                if (kullaniciEmail == userEmail && kullaniciSifre == userSifre)
                                {
                                    string adSoyad = antrenorbilgisi["Ad"]?.ToString() + " " + antrenorbilgisi["Soyad"]?.ToString();
                                    string sifre = antrenorbilgisi["Sifre"]?.ToString();
                                    string tekrarsifre = antrenorbilgisi["TekrarSifre"]?.ToString();
                                    string email = antrenorbilgisi["Email"]?.ToString();
                                    string telefon = antrenorbilgisi["Telefon"]?.ToString();
                                    string ad = antrenorbilgisi["Ad"]?.ToString();
                                    string soyad = antrenorbilgisi["Soyad"]?.ToString();
                                    string id = antrenorbilgisi["Id"]?.ToString();
                                    string cinsiyet = antrenorbilgisi["Cinsiyet"]?.ToString();
                                    string deneyimleri = antrenorbilgisi["Deneyimleri"]?.ToString();
                                    string uzmanlikalanlari = antrenorbilgisi["UzmanlikAlani"]?.ToString();
                                    string dogumtarihi = antrenorbilgisi["DogumTarihi"]?.ToString();



                                    Session["AdSoyad"] = adSoyad; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["Ad"] = ad; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["Soyad"] = soyad; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["Sifre"] = sifre; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["TekrarSifre"] = tekrarsifre; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["Email"] = email; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["Telefon"] = telefon; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["Id"] = id; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["Cinsiyet"] = cinsiyet; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["Deneyimleri"] = deneyimleri; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["UzmanlikAlani"] = uzmanlikalanlari; // Oturum değişkenine ad ve soyadı kaydet
                                    Session["DogumTarihi"] = dogumtarihi; // Oturum değişkenine ad ve soyadı kaydet

                                    string queryString = $"?name={adSoyad}&mail={email}&telefon={telefon}";
                                    Response.Redirect($"Antrenor.aspx{queryString}");



                                    // Başarılı giriş durumu
                                    girisBasarili = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (girisBasarili)
                    {
                        Response.Redirect("Antrenor.aspx");
                    }
                    else
                    {
                        // Başarısız giriş durumu, hata mesajını göster
                        lblErrorMessage.Text = "E-posta Veya Şifre Hatalı. Lütfen Tekrar Deneyiniz";
                    }
                }
            }          
        }

        protected async void CompareAndUpdateAntrenor()
        {
            
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "dWa02vmBpMFhNY1iXel4ReTZRdJedZklY2QVxXvr",
                BasePath = "https://proje2-25a28-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            // Kullanıcı verilerini al
            string kullaniciID = Session["Id"].ToString();
            FirebaseResponse userResponse = await client.GetAsync($"kullanicilar/{kullaniciID}");
            var userData = userResponse.ResultAs<Dictionary<string, object>>();
            string selectedHedef = userData["SecilenHedef"].ToString(); // Kullanıcının seçtiği hedef

            // Antrenör verilerini al
            FirebaseResponse antrenorResponse = await client.GetAsync("antrenorler");
            var antrenorler = antrenorResponse.ResultAs<Dictionary<string, object>>();

            // Kullanıcı ve antrenörler arasında karşılaştırma yap
            foreach (var antrenor in antrenorler)
            {
                string antrenorID = antrenor.Key;
                var antrenorData = (Dictionary<string, object>)antrenor.Value;

                string uzmanlikAlani = antrenorData["UzmanlikAlani"].ToString(); // Antrenörün uzmanlık alanı

                // Karşılaştırma yap ve eşleşenleri işle
                if (selectedHedef == uzmanlikAlani)
                {
                    // Eşleşme bulundu, kullanıcının düğümüne "Antrenorum" sütunu ekle
                    var antrenorName = $"{antrenorData["Ad"]} {antrenorData["Soyad"]}";
                    userData["Antrenorum"] = antrenorName;

                    // Kullanıcının verilerini güncelle
                    SetResponse updateUserResponse = await client.SetAsync($"kullanicilar/{kullaniciID}", userData);
                    if (updateUserResponse.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        // Güncelleme başarısız
                    }
                }
            }
        }

        protected void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            // Şifre sıfırlama alanını görünür yap
            sifreResetForm.Style["display"] = "block";
            btnSifremiUnuttum.Visible = false;

        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            
        }
    }
}