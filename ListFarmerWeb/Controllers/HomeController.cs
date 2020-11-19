using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ListFarmerWeb.Models;
using Entity.Concrete;
namespace ListFarmerWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return RedirectToAction("index2"); 
        }
        public IActionResult Index2()
        {
            List<Ciftci> liste = new List<Ciftci>();
            List<Mgd> listeMgd = new List<Mgd>();
            for (int i = 0; i < 5; i++)
            {
                Ciftci c = new Ciftci();
                c.Id = new Guid();
                c.Isim = FakeData.NameData.GetFirstName();
                c.Mahalle = FakeData.PlaceData.GetStreetName();
                c.KayitTarih = FakeData.DateTimeData.GetDatetime();
                c.Soyisim = FakeData.NameData.GetSurname();
                c.Tc = FakeData.NumberData.GetDouble().ToString().Substring(2, 11);
                c.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                Mgd m = new Mgd();
                m.tc = c.Tc;
                m.isletmeAdi = c.Isim + " " + c.Soyisim;
                m.toplamDesteklemeMiktari = FakeData.NumberData.GetNumber(180,12000);
                listeMgd.Add(m);
                liste.Add(c);
            }
            var model = new CiftciListViewModel()
            {
                Ciftciler = liste,
                MgdTutar = listeMgd
            };
            
            return View(model);
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
