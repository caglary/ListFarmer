using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Concrete;
using ListFarmerWeb.Models;
using Microsoft.AspNetCore.Mvc;
namespace ListFarmerWeb.Controllers
{
    public class FarmerController : Controller
    {
        public IActionResult Add()
        {
            var ciftciAddViewModel = new CiftciAddViewModel
            {
                Ciftci = new Ciftci()
            };
            return View(ciftciAddViewModel);
        }
        [HttpPost]
        public IActionResult Add(Ciftci ciftci)
        {
            return View();
        }
    }
}