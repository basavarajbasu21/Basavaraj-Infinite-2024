using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_1.Controllers
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
    }

}