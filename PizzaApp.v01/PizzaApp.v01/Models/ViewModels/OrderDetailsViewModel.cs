using PizzaApp.v01.Models.Domain;
using PizzaApp.v01.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.v01.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }

        public string User { get; set; }
        [Display(Name = "Order's title")]
        public string Name { get; set; }

        public PizzaSize Size { get; set; }
        public double Price { get; set; }
        [Display(Name = "Status")]
        public bool Delivered { get; set; }

    }
}
