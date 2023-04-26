using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using TVStore.Models;

namespace TVStore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.TVId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.User + " Спасибо, " + " за покупку!";
        }
       TVContext db;
        public HomeController(TVContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.TVs.ToList());
        }
    }
}
