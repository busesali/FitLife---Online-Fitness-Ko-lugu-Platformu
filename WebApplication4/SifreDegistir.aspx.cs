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
    public partial class SifreDegistir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sifre = Session["Sifre"].ToString();

            }
        }

        protected async void btnGuncelle_Click(object sender, EventArgs e)
        {
            string eskiSifre = txteskiSifre.Text;
            string yeniSifre = txtSifre.Text;
            string tekraryenisifre = txttekraryenisifre.Text;

            string ad = Session["Ad"].ToString();
            string soyad = Session["Soyad"].ToString();
            string email = Session["Email"].ToString();
            string telefon = Session["Telefon"].ToString();
            string dogumtarihi = Session["Dogumtarihi"].ToString();
            string kullaniciid = Session["KullaniciId"].ToString();
            string SecilenHedef = Session["SecilenHedef"].ToString();
            string cinsiyet = Session["Cinsiyet"].ToString();

            // Firebase veritabanı yapılandırması
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "dWa02vmBpMFhNY1iXel4ReTZRdJedZklY2QVxXvr",
                BasePath = "https://proje2-25a28-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            string sifre = Session["Sifre"].ToString();

            // Güncellenecek kullanıcının ID'si
            string id = Session["KullaniciId"].ToString();
            if (eskiSifre == sifre)
            {
                if (yeniSifre == tekraryenisifre)
                {




                    var data = new
                    {
                        Ad = ad,
                        Soyad = soyad,
                        Email = email,
                        Telefon = telefon,
                        Dogumtarihi = dogumtarihi,
                        KullaniciId = kullaniciid,
                        SecilenHedef = SecilenHedef,
                        Sifre = yeniSifre,
                        Tekrarsifre = tekraryenisifre,
                        Cinsiyet=cinsiyet


                    };

                    // Veritabanında güncelleme yapma isteği
                    SetResponse response = await client.SetAsync("kullanicilar/" + id, data);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        lblErrorMessage.Text = "";
                        lblHataMessage.Text = "";
                        lblMessage.Text = "Şifreniz başarıyla güncellendi.";

                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    lblErrorMessage.Text = "";
                    lblHataMessage.Text = "Girdiğiniz yeni şifreler eşleşmiyor. Lütfen tekrar deneyiniz.";
                }
            }
            else
            {
                lblHataMessage.Text = "";
                lblErrorMessage.Text = "Girdiğiniz eski şifre yanlış. Lütfen tekrar deneyiniz.";
            }
        }
    }
}