using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      ViewBag.PageTitle = "View All Stylists";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add New Stylist";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist stylist = FindStylistById(id);
      ViewBag.Clients = _db.Clients.Where(c => c.StylistId == stylist.StylistId).ToList();
      return View(stylist);
    }

    public ActionResult Delete(int id)
    {
      Stylist stylist = FindStylistById(id);
      return View(stylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult Deleted(int id)
    {
      Stylist stylist = FindStylistById(id);
      _db.Stylists.Remove(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    private Stylist FindStylistById(int id)
    {
      return _db.Stylists.FirstOrDefault(c => c.StylistId == id);
    }
  }
}