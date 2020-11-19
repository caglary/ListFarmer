using FarmerWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace FarmerWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Database.Operations.CiftciDal ciftciDal = new Database.Operations.CiftciDal();
            var model= ciftciDal.GetAll().OrderByDescending(I=>I.KayitTarih).ToList();
        
            return View(model);
        }
        public ActionResult Giris()
        {
            return View();
        }
    }
}