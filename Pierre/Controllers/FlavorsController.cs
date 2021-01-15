using Pierre.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// using System.Threading.Tasks;

namespace Pierre.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierreContext _db;
    public FlavorsController(PierreContext db)
    {
      _db = db;
    }
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
    public ActionResult Create (Flavor flavor, int treatId)
    {
      _db.Flavors.Add(flavor);
      if (treatId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor() { TreatId = treatId, FlavorId = flavor.FlavorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }
    public ActionResult Edit(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor flavor)
    {
      _db.Entry(flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      _db.Flavors.Remove(thisFlavor);
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }
  }
}