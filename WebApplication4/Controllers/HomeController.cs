using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string authSecret = "dWa02vmBpMFhNY1iXel4ReTZRdJedZklY2QVxXvr";
            string basePath = "https://proje2-25a28-default-rtdb.firebaseio.com/";
            string  senderAppName = "proje2";

            IFirebaseClient client;
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = authSecret,
                BasePath=basePath
            };

            client = new FireSharp.FirebaseClient(config);

            if(client !=null && !string.IsNullOrEmpty(basePath) && !string.IsNullOrEmpty(authSecret))
            {
                var data = new
                {
                    Name = "Test",
                    Mobile="234234"
                };
                var response = client.Push("/kullanicilar", data);
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}