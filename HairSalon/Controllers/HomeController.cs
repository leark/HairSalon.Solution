using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _db;

    public HomeController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "Eau Claire's Salon";
      return View();
    }

    [HttpPost]
    public ActionResult Search(string searchTerm)
    {
      List<Stylist> stylists = _db.Stylists.Where(s => s.Name.Contains(searchTerm)).ToList();
      List<Client> clients = _db.Clients.Where(c => c.Name.Contains(searchTerm)).ToList();
      (List<Stylist> stylists, List<Client> clients) model = (stylists, clients);
      ViewBag.PageTitle = "Search Result";
      ViewBag.SearchTerm = searchTerm;
      return View(model);
    }
  }
}