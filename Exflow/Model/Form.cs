using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exflow.Model
{
    public class Form
    {
        //public Form()
        //{

        //}
        //public Form(string customerName,string info)
        //{

        //    CustomerName = customerName;
        //    Info = info;
        //}



        public string CustomerName { get; set; }
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Info { get; set; }
    }
}