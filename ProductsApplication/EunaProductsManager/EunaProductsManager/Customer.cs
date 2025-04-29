using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EunaProductsManager
{
    internal class Customer
    {
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        //public List<Orders> orders { get; set; }

        //public void setOrdersList(List<Orders> order)
        //{
        //    this.orders = order;
        //}
    }
}
