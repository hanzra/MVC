﻿using MVCEssentialTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace MVCEssentialTool.Controllers
{
    public class HomeController : Controller
    {        
                private Product[] products = {
                            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                            new Product {Name = "Lifejacket", Category = "Watersports",Price = 48.95M},
                            new Product {Name = "Soccer ball", Category = "Soccer", Price= 19.50M},
                            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                                };

        public ActionResult Index()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();

            IValueCalculator calculator = ninjectKernel.Get<IValueCalculator>();

            ShoppingCart cart = new ShoppingCart(calculator);
            cart.Products = products;
            var totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}