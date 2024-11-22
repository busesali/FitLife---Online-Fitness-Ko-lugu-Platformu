using System;
using System.Net.NetworkInformation;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WebApplication4
{
    public partial class Profilduzenle : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txttxtKullaniciHedefleri.Visible = false;
                txtKullaniciid.Visible = false;

                // Mevcut kullanıcı verilerini yükle
                string ad = Session["Ad"].ToString();
                string soyad = Session["Soyad"].ToString();
                string email = Session["Email"].ToString();
                string telefon = Session["Telefon"].ToString();
                string dogumtarihi = Session["Dogumtarihi"].ToString();
                string kullaniciid = Session["KullaniciId"].ToString();
                string SecilenHedef = Session["SecilenHedef"].ToString();

                // TextBox'lara bu verileri yerleştir
                txtAd.Text = ad;
                txtSoyad.Text = soyad;
                txtEmail.Text = email;
                txtTelefon.Text = telefon;
                txtDogumTarihi.Text = dogumtarihi;
                txtKullaniciid.Text = kullaniciid;
                txttxtKullaniciHedefleri.Text= SecilenHedef;

            }
        }

        protected async void btnGuncelle_Click(object sender, EventArgs e)
        {
            string yeniAd = txtAd.Text;
            string yeniSoyad = txtSoyad.Text;
            string yeniEmail = txtEmail.Text;
            string yeniTelefon = txtTelefon.Text;
            string yenidogumTarihi = txtDogumTarihi.Text;
            string yeniKullaniciid = txtKullaniciid.Text;
            string yeniKullaniciHedefleri = txttxtKullaniciHedefleri.Text;

            string cinsiyet = Session["Cinsiyet"].ToString();
            string sifre = Session["Sifre"].ToString();
            string tekrarsifre = Session["Tekrarsifre"].ToString();

            // Firebase veritabanı yapılandırması
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "dWa02vmBpMFhNY1iXel4ReTZRdJedZklY2QVxXvr",
                BasePath = "https://proje2-25a28-default-rtdb.firebaseio.com/"
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            // Güncellenecek kullanıcının ID'si
            string id = Session["KullaniciId"].ToString();

            var data = new
            {
                Ad = yeniAd,
                Soyad = yeniSoyad,
                Email = yeniEmail,
                Telefon = yeniTelefon,
                Dogumtarihi = yenidogumTarihi,
                KullaniciId = yeniKullaniciid,
                SecilenHedef=yeniKullaniciHedefleri,
                Cinsiyet=cinsiyet,
                Sifre=sifre,
                Tekrarsifre=tekrarsifre
                

            };

            // Veritabanında güncelleme yapma isteği
            SetResponse response = await client.SetAsync("kullanicilar/" + id, data);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Başarılı güncelleme
                Response.Redirect("Kullanici.aspx");
            }
            else
            {
                
            }
        }



    }
}
