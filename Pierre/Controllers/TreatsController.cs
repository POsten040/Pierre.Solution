using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pierre.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace Pierre.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierreContext _db;
    private readonly UserManager<ApplicationUser> _userManager; 
    public TreatsController(UserManager<ApplicationUser> userManager, PierreContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats.ToList();
      List<Treat> userTreats = _db.Treats.ToList();
      return View(userTreats);
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
      ViewBag.Flavors = _db.Flavors.ToList();
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat treat, int flavorId)
    {
      if (flavorId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor() {FlavorId = flavorId, TreatId = treat.TreatId});
      }
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