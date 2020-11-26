using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcTut.Models;
using AspNetMvcTut.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcTut.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult Index()
        {
            var products = ProductsRepository.GetAll();
            return View(products);
        }

        [HttpPost("Products")]
        public IActionResult Register(UserProduct user)
        {

            ProductsRepository.Add(user);

            return View("Thanks", user);
        }
    }
}
