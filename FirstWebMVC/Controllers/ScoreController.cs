using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
namespace FirstWebMVC.Controllers;
public class ScoreController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
     public IActionResult CalculateFinalScore()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CalculateFinalScore(ScoreModel model)
    {
        ViewBag.FinalScore = model.CalculateFinalScore();
        return View(model);
    }
}
