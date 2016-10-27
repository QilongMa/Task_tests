using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panda {
    public class data {
        public int id { get; set; }
        public string apiPassword { get; set; }
        //public string apiPasswordCreateDate { get; set; }
        //public string apiPasswordLastUsedDate { get; set; }
        //public bool receiveEmail { get; set; }
        //public bool receiveSmsNotifications { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
    }
    public class dataInfo {
        public data data { get; set; }
        public string error { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }
}