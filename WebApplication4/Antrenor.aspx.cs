using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WebApplication4
{
    public partial class Antrenor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string combinedQueryString = Request.Url.Query; 

                if (!string.IsNullOrEmpty(combinedQueryString))
                {
                    var queryStringParams = System.Web.HttpUtility.ParseQueryString(combinedQueryString);

                    string adSoyad = queryStringParams["name"];
                    string email = queryStringParams["mail"];
                    string telefon = queryStringParams["telefon"];

                    if (!string.IsNullOrEmpty(adSoyad))
                    {
                        lblUserName.Text = adSoyad;
                    }

                    if (!string.IsNullOrEmpty(email))
                    {
                        lblMail.Text = email;
                    }

                    if (!string.IsNullOrEmpty(telefon))
                    {
                        LabelTelefon.Text = telefon;
                    }
                }
               
                    

                    // Mevcut kullanıcı verilerini yükle
                    string deneyim = Session["Deneyimleri"].ToString();
                    string telefonNumarasi = Session["Telefon"].ToString();
                    string Email = Session["Email"].ToString();


                // TextBox'lara bu verileri yerleştir
                txtExperience.Text = deneyim;
                txtContact.Text = telefonNumarasi;
                txtMail.Text = Email;


            }
        }


        protected async void btnGuncelle_Click(object sender, EventArgs e)
        {
            string yenideneyim = txtExperience.Text;
            string yenitelefonNumarasi = txtContact.Text;
            string yeniEmail = txtMail.Text;
           
            string ad = Session["Ad"].ToString();
            string soyad = Session["Soyad"].ToString();
            string dogumtarihi = Session["DogumTarihi"].ToString();
            string kullaniciid = Session["Id"].ToString();
            string  uzmanlikalani= Session["UzmanlikAlani"].ToString();
            string cinsiyet = Session["Cinsiyet"].ToString();
            string  sifre= Session["Sifre"].ToString();
            string tekrarsifre = Session["TekrarSifre"].ToString();

            // Firebase veritabanı yapılandırması
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "dWa02vmBpMFhNY1iXel4ReTZRdJedZklY2QVxXvr",
                BasePath = "https://proje2-25a28-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            // Güncellenecek kullanıcının ID'si
            string id = Session["Id"].ToString();

            var data = new
            {
                Ad = ad,
                Soyad = soyad,
                Email = yeniEmail,
                Telefon = yenitelefonNumarasi,
                DogumTarihi = dogumtarihi,
                Id = kullaniciid,
                UzmanlikAlani = uzmanlikalani,
                Sifre = sifre,
                TekrarSifre = tekrarsifre,
                Cinsiyet = cinsiyet,
                Deneyimleri = yenideneyim 


            };

            // Veritabanında güncelleme yapma isteği
            SetResponse response = await client.SetAsync("antrenorler/" + id, data);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Başarılı güncelleme
                Response.Redirect("YeniSayfa.aspx");
            }
            else
            {
                // Güncelleme başarısız

            }
        }


    }
}