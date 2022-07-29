using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      ViewBag.PageTitle = "View All Clients";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add New Client";
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client client = FindClientById(id);
      return View(client);
    }

    public ActionResult Delete(int id)
    {
      Client client = FindClientById(id);
      return View(client);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult Deleted(int id)
    {
      Client client = FindClientById(id);
      _db.Clients.Remove(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    private Client FindClientById(int id)
    {
      return _db.Clients.FirstOrDefault(c => c.ClientId == id);
    }
  }
}