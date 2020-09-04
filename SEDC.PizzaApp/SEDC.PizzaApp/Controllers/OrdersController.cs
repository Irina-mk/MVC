using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details (int? id)
        {
            if (id != null)
            {
                return View();
            }
            return new EmptyResult();
        }

        public IActionResult JsonData()
        {
            Order order = new Order
            {
                Id = 1,
                Title = "Large Margarita"

            };
            return new JsonResult(order);
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult GetAllOrders()
        {
            //Bonus
            List<Order> model = StaticDb.Orders;
            return View(model);
        }




    }
}
