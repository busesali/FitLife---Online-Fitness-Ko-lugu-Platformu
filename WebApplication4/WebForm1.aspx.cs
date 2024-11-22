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

    public partial class WebForm1 : System.Web.UI.Page
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

        protected void KayitOlButton_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("KayitOl.aspx"); 
        }
    }
}