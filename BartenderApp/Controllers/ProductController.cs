using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderApp.Models;
namespace BartenderApp.Controllers
{
    public class ProductController : Controller
    {
        private IMenuRepository repository;
        public ProductController(IMenuRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View("Index", repository.Menu);
    }
}