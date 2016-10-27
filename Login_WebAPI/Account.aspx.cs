using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Panda {
    public partial class Account : System.Web.UI.Page {
        string apiPwd;
        string usrname;
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                if (Request.Cookies["UserSetting"] != null) {
                    usrname = txt_usrname.Text = Request.Cookies["UserSetting"]["usrname"];
                    apiPwd = Request.Cookies["UserSetting"]["passwd"];

                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e) {
            HttpClient client = Get_Client();

        }

        protected HttpClient Get_Client() {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://dev.parkingpanda.com/api/v2/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}