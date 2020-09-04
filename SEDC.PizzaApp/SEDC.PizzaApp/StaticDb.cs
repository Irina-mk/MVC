using SEDC.PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza()
            {
                Id = 1,
                Name = "Margarita",
                IsOnPromotion = false

            },
              new Pizza()
            {
                Id = 2,
                Name = "Bianca",
                IsOnPromotion = true

            },
                new Pizza()
            {
                Id = 3,
                Name = "Capri",
                IsOnPromotion = false

            }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order()
            {
                Id = 1,
                Title = "Family Kapri"
            },


            new Order()
            {
                Id = 2,
                Title = "Small Iltaliana"
            },

            new Order()
            {
                Id = 3,
                Title =   "Two jumbo Quattro formaggi"
            },

             new Order()
            {
                Id = 4,
                Title =   "Three small Oliva's"
            },
              new Order()
            {
                Id = 5 ,
                Title =   "Five family Napoli's"
            }


        };

 

    }
}
