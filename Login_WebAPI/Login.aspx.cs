using System;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Web.Security;

namespace Panda {
    public partial class Login : System.Web.UI.Page {        
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_Click(object sender, EventArgs e) {
            string apiPwd;
            HttpClient client = Get_Client();            
            var username = txt_username.Text;
            var password = txt_pwd.Text;
            var usr_pwd = Encoding.UTF8.GetBytes(username + ":" + password);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(usr_pwd));

            var response = client.GetAsync("users").Result;
            if (response.IsSuccessStatusCode) {
                string res = response.Content.ReadAsStringAsync().Result;
                var deserial_Data = JsonConvert.DeserializeObject<dataInfo>(res);
                apiPwd = deserial_Data.data.apiPassword;
                HttpCookie myCookie = Get_Cookies(username, apiPwd, deserial_Data.data.firstName, deserial_Data.data.lastName, deserial_Data.data.phone);
                Response.Cookies.Add(myCookie);
                FormsAuthentication.RedirectFromLoginPage(username, true);
            }
            else {
                //throw new Exception("Invalid input!");
            }         
        }

        protected HttpClient Get_Client() {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://dev.parkingpanda.com/api/v2/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        protected HttpCookie Get_Cookies(string usrname, string apiPwd, string firstname, string lastname, string phone) {
            HttpCookie myCookie = new HttpCookie("UserSetting");
            myCookie["usrname"] = usrname;
            myCookie["passwd"] = apiPwd;
            myCookie.Expires = DateTime.Now.AddSeconds(900);
            return myCookie;
        }
    }
}