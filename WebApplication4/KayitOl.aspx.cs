using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Threading.Tasks;

namespace WebApplication4
{
    public partial class KayitOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltAdkayıt.Text = "<input type='text' placeholder='Enter name' name='ad' id='ad' required><br>";
                ltsoyadkayıt.Text = "<input type='text' placeholder='Enter surname' name='soyad' id='soyad' required><br>";
                ltEmailkayıt.Text= "<input type='text' placeholder='Enter mail' name='email' id='email' required><br>";
                ltPassword.Text = "<input type='text' placeholder='Enter password' name='sifre' id='sifre' required><br>";
                ltRepeatPassword.Text = "<input type='text' placeholder='Enter repeat password' name='tekrarsifre' id='tekrarsifre' required><br>";
                ltdogumkayıt.Text = "<input type='text' placeholder='Enter birthday' name='dogumtarihi' id='dogumtarihi' required><br>";
                lttelefonkayıt.Text= "<input type='text' placeholder='Enter telephone' name='telefon' id='telefon' required><br>";
            }
        }

        protected void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Formdan gelen verileri al
            string ad = Request.Form["ad"];
            string soyad = Request.Form["soyad"];
            string email = Request.Form["email"];
            string sifre = Request.Form["sifre"];
            string tekrarsifre = Request.Form["tekrarsifre"];
            string dogumtarihi = Request.Form["dogumtarihi"];
            string telefon = Request.Form["telefon"];
            string secilenHedef = ddlHedefler.SelectedValue;
            string cinsiyet = ddlCinsiyet.SelectedValue;

            string kullaniciId = Guid.NewGuid().ToString();

            string AuthSecret = "dWa02vmBpMFhNY1iXel4ReTZRdJedZklY2QVxXvr";
            string BasePath = "https://proje2-25a28-default-rtdb.firebaseio.com/";

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = AuthSecret,
                BasePath = BasePath
            };

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

         
            if (client != null && !string.IsNullOrEmpty(BasePath) && !string.IsNullOrEmpty(AuthSecret))
            {
                var data = new
                {
                    KullaniciId = kullaniciId,
                    Ad = ad,
                    Soyad = soyad,
                    Email = email,
                    Sifre=sifre,
                    Telefon=telefon,
                    Tekrarsifre=tekrarsifre,
                    Dogumtarihi=dogumtarihi,
                    SecilenHedef = secilenHedef,
                    Cinsiyet=cinsiyet
        
                };
                var response = client.Set($"kullanicilar/{kullaniciId}", data);
                Response.Write("<script>alert('Giriş Başarılı!');</script>");
                Response.Redirect("Giris.aspx");
            }
        }
    }
}
