using System;
using System.Web.UI.WebControls;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;

namespace WebApplication4
{
    public partial class Kullanici : System.Web.UI.Page
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "dWa02vmBpMFhNY1iXel4ReTZRdJedZklY2QVxXvr",
            BasePath = "https://proje2-25a28-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillAntrenorlerDropDown();
            }
        }


        private void FillAntrenorlerDropDown()
        {
            client = new FireSharp.FirebaseClient(config);

            // Kullanıcı ID'sini oturumdan al
            string kullaniciID = Session["KullaniciId"].ToString();

            // Kullanıcının SecilenHedef değerini al
            FirebaseResponse userResponse = client.GetAsync("kullanicilar/" + kullaniciID).Result;
            string secilenHedef = "";
            if (userResponse.Body != "null")
            {
                JObject userData = userResponse.ResultAs<JObject>();
                secilenHedef = userData["SecilenHedef"].ToString();
            }

            // Tüm antrenörlerin veritabanından alınması
            FirebaseResponse response = client.GetAsync("antrenorler").Result;
            if (response.Body != "null")
            {
                var antrenorler = response.ResultAs<JObject>(); // Veriyi JObject olarak al

                foreach (var antrenor in antrenorler)
                {
                    var antrenorData = antrenor.Value as JObject;
                    if (antrenorData != null)
                    {
                        // Antrenörün UzmanlikAlani değerini al
                        string uzmanlikAlani = antrenorData["UzmanlikAlani"].ToString();

                        // Eğer kullanıcının seçtiği hedef ile antrenörün uzmanlık alanı eşleşiyorsa combobox'a ekle
                        if (secilenHedef == uzmanlikAlani)
                        {
                            string adSoyad = $"{antrenorData["Ad"]} {antrenorData["Soyad"]}";
                            ddlAntrenorler.Items.Add(new ListItem(adSoyad, antrenor.Key));
                        }
                    }
                }
            }
        }

        protected void ddlAntrenorler_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "dWa02vmBpMFhNY1iXel4ReTZRdJedZklY2QVxXvr",
                BasePath = "https://proje2-25a28-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);


            string selectedAntrenorId = ddlAntrenorler.SelectedValue;

            // Kullanıcının oturum bilgisinden kullanıcı ID'sini alalım
            string kullaniciID = Session["KullaniciId"].ToString(); 


            // Kullanıcıya ait düğümü veritabanından alalım
            FirebaseResponse userResponse = client.GetAsync("kullanicilar/" + kullaniciID).Result;
            if (userResponse.Body != "null")
            {
                JObject userData = userResponse.ResultAs<JObject>(); // Kullanıcıya ait veriyi al

                // Seçilen antrenör bilgilerini kullanıcı düğümüne kaydet
                userData["Antrenoru"] = new JObject
                {
                    ["AdSoyad"] = ddlAntrenorler.SelectedItem.Text // Seçilen antrenörün adı ve soyadını kaydet
                                                                   
                };

                // Veritabanına güncellenmiş kullanıcı verisini kaydet
                FirebaseResponse updateResponse = client.UpdateAsync("kullanicilar/" + kullaniciID, userData).Result;
                if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    
                    lblWelcomeMessage.Text = "Seçilen Antrenör başarıyla kaydedildi!";
                }
                else
                {
                    // Veritabanına kaydedilirken bir hata oluştu
                    lblWelcomeMessage.Text = "Seçilen Antrenör kaydedilirken bir hata oluştu!";
                }
            }

            FirebaseResponse antrenorResponse = client.GetAsync("antrenorler/" + selectedAntrenorId).Result;
            if (antrenorResponse.Body != "null")
            {
                // Antrenör verisini JObject olarak al
                JObject antrenorData = antrenorResponse.ResultAs<JObject>();

                // Kullanıcı adı ve soyadını al
                string adSoyad = Session["AdSoyad"].ToString();

                // Kullanıcının adı ve soyadını içeren JObject oluştur
                JObject danisaniData = new JObject
                {
                    ["AdSoyad"] = adSoyad
                };

                // Seçilen antrenör düğümüne "Danisani" sütununu ekle
                antrenorData["Danisani"] = danisaniData;

                // Veritabanına güncellenmiş antrenör verisini kaydet
                FirebaseResponse updateResponse = client.UpdateAsync("antrenorler/" + selectedAntrenorId, antrenorData).Result;
                if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    lblWelcomeMessage.Text = "Seçilen Antrenör başarıyla kaydedildi!";
                }
                else
                {
                    lblWelcomeMessage.Text = "Seçilen Antrenör kaydedilirken bir hata oluştu!";
                }
            }
        }
    }

}