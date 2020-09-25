using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.v01.DB;
using PizzaApp.v01.Models.Domain;
using PizzaApp.v01.Models.Enum;
using PizzaApp.v01.Models.ViewModels;

namespace PizzaApp.v01.Controllers
{
    public class OrderController : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            ViewBag.Title = "Welcome to the Orders page";
            Order firstOrder = StaticDb.Orders.FirstOrDefault();
            OrderListViewModels ordersViewModel = new OrderListViewModels()
            {
                FirstPizza = firstOrder.Pizza.Name,
                NumberOfOrders = StaticDb.Orders.Count,
                FirstCustomerName = $"{firstOrder.User.FirstName} {firstOrder.User.LastName}",
                Orders = StaticDb.Orders
            };
            return View(ordersViewModel);
        }
        public IActionResult Details(int id)
        {
            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            OrderDetailsViewModel orderDetails = new OrderDetailsViewModel()
            {
                Id = order.Id,
                User = order.User.FirstName,
                Name = order.Pizza.Name,
                Size = order.Pizza.Size,
                Price = order.Price,
                Delivered = order.Delivered
            };
            return View(orderDetails);
        }



        [HttpGet("Order")]
        public IActionResult Create(string error)
        {
            ViewBag.Error = error == null ? "" : error;
            OrderViewModel model = new OrderViewModel();
            return View();
        }


        [HttpPost("Order")]
        public IActionResult Create(OrderViewModel model)
        {
            Pizza pizza = StaticDb.Menu.FirstOrDefault(x => x.Name == model.PizzaName && x.Size == model.Size);
            if (pizza == null)

                return RedirectToAction("Create", new { error = "There is no such pizza in the menu. " });


            StaticDb.UserId++;
            User user = new User()
            {
                Id = StaticDb.UserId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                Phone = model.Phone
            };
            StaticDb.OrderId++;
            Order order = new Order()
            {
                Id = StaticDb.OrderId,
                Delivered = false,
                Pizza = pizza,
                Price = pizza.Price + 2,
                User = user
                

            };
            StaticDb.Users.Add(user);
            StaticDb.Orders.Add(order);
            return View("_Thankyou");
        }
 




    }
}
