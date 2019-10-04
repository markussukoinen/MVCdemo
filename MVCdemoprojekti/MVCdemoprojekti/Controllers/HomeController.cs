﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCdemoprojekti.Models;

namespace MVCdemoprojekti.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // asiakkaiden lukumäärä
            NorthwindContext context = new NorthwindContext();
            int lkm = context.Customers.Count();

            ViewBag.AsiakkaidenLkm = lkm;

            //listaus asiakkaista (generic type)
            List<Customers> asiakkaat = context.Customers.ToList();

            ViewBag.KaikkiAsiakkaat = asiakkaat;



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
