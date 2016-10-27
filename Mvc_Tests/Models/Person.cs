using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Tests.Models {
    public class Person {
        public int id { get; set; }
        public string gender { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string city { get; set; }

        public static explicit operator List<object>(Person v) {
            throw new NotImplementedException();
        }
    }
}