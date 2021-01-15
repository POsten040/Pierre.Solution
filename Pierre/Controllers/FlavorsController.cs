using Pierre.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Pierre.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierreContext _db;
    public FlavorsController(PierreContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Flavors = _db.Flavors.ToList();
      ViewBag.Treats = _db.Treats.ToList();
      return View();
    }
    public ActionResult Create()
    {
      ViewBag.Treats = _db.Treats.ToList();
      return View();
    }
    [HttpPost]
    public ActionResult Create (Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }
  }
}