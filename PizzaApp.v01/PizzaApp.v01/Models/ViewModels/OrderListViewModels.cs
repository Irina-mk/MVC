using PizzaApp.v01.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.v01.Models.ViewModels
{
    public class OrderListViewModels
    {
        public string FirstPizza { get; set; }
        public int NumberOfOrders { get; set; }
        public string FirstCustomerName { get; set; }


        public List<Order> Orders { get; set; }


    }
}
