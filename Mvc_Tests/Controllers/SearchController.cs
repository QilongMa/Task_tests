using Mvc_Tests.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Linq;
using System;

namespace Mvc_Tests.Controllers
{
    public class SearchController : Controller
    {
        private ICollection<Person> Get_Infor() {
            ICollection<Person> data;
            using (StreamReader r = new StreamReader(Server.MapPath("~/MOCK_DATA.json"))) {
                string json = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            return data;
        }
        // GET: Search
        public ActionResult Index()
        {
            ViewBag.flag = false;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string search_input) {
            ICollection<Person> data = Get_Infor();
            ICollection<Person> show = new List<Person>();
            string target = search_input.ToLower();
            // ignore id
            foreach (var item in data) {
                if (item.city.ToLower().Contains(target) ||
                    item.email.ToLower().Contains(target) ||
                    item.gender.ToLower().Contains(target) ||
                    item.name.ToLower().Contains(target)) {
                    show.Add(item);
                }
            }
            ViewBag.flag = true;
            return View(show);
        }
    }
}