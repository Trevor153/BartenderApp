using BartenderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {
        private IMenuRepository repository1;
        private IOrderRepository repository2;

        public HomeController(IMenuRepository repo1, IOrderRepository repo2)
        {
            repository1 = repo1;
            repository2 = repo2;
        }
        public ViewResult Index()
        {
            return View();
        }//end ViewResult

        //[HttpGet]
        public ViewResult CreateOrder(int orderID) => View(repository2.OrderQueue
            .FirstOrDefault(o => o.ID == orderID));

        //[HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                repository2.SaveOrder(order);
                return RedirectToAction("Index");
            }
            else
            {
                return View("PlaceOrder", order);
            }
        }
        public ViewResult Customer() => View("PlaceOrder", new ViewModel
        {
            Menu = repository1.Menu,
            OrderQueue = repository2.OrderQueue
        });

        public ViewResult Bartender()
        {
            return View("OrderQueue");
        }//end ViewResult

    }//end HomeController
}//end namespace
