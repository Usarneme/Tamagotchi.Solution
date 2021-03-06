using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TamagotchiNamespace;
namespace Tamagotchi.Controllers
{
  public class TamagotchiController : Controller
  {
    [HttpGet("/Tamagotchi/")]
    public IActionResult Index()
    {
      List<TamagotchiNamespace.Tamagotchi> allPets = TamagotchiNamespace.Tamagotchi.allTamagotchis;
      return View(allPets);
    }

    [HttpGet("/Tamagotchi/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/Tamagotchi/new")]
    public ActionResult CreateNew(string hunger, string sleepiness, string attentionNeed, string name)
    {
      new TamagotchiNamespace.Tamagotchi(int.Parse(hunger), int.Parse(sleepiness), int.Parse(attentionNeed), name);
      return RedirectToAction("Index");
    }

    [HttpPost("/Tamagotchi/{Id}/feed")]
    public ActionResult Feed(string id)
    {
      TamagotchiNamespace.Tamagotchi.Feed(int.Parse(id));
      return RedirectToAction("Index");
    }

    [HttpPost("/Tamagotchi/{Id}/rest")]
    public ActionResult Rest(string id)
    {
      TamagotchiNamespace.Tamagotchi.Rest(int.Parse(id));
      return RedirectToAction("Index");
    }

    [HttpPost("/Tamagotchi/{Id}/attention")]
    public ActionResult Attention(string id)
    {
      TamagotchiNamespace.Tamagotchi.GiveAttention(int.Parse(id));
      return RedirectToAction("Index");
    }
  }
}
