using Pierre.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Pierre.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreContext _db;
    public HomeController(PierreContext db)
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
  }
}