using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pierre.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public ActionResult Index()
    {
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }
    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }
    [HttpPost]
    public ActionResult Create (Treat treat, int flavorId)
    {
      _db.Treats.Add(treat);
      if (flavorId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor() { FlavorId = flavorId, TreatId = treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }
    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat treat)
    {
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index", "Home");
    }
  }
}