using Pierre.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Pierre.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierreContext _db;
    public TreatsController(PierreContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }
    public ActionResult Create()
    {
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }
    [HttpPost]
    public ActionResult Create (Flavor flavor)
    {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }
  }
}