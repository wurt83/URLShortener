﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using URLShortener.Models;
using URLShortener.Repository;

namespace URLShortener.Controllers
{
    public class HomeController : Controller
    {
        private IURLRepository _URLRepo;

        public HomeController(IURLRepository URLRepo)
        {
            _URLRepo = URLRepo;
        }

        public IActionResult Index()
        {
            var URLList = _URLRepo.GetAdresses();
            return View(URLList);
        }

        public IActionResult Create(URL url)
        {
            _URLRepo.AddAddress(url);
            return RedirectToAction("Index");
        }

        public IActionResult Delete (URL url)
        {
            _URLRepo.DeleteAddress(url);
            return RedirectToAction("Index");
        }
    
        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
