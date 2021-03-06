﻿using PizzaApp.v01.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.v01.Models.ViewModels
{
    public class OrderViewModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public string PizzaName { get; set; }
        public PizzaSize Size { get; set; }
    }
}
