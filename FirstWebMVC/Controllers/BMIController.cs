using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
namespace FirstWebMVC.Controllers;
public class BMIController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult CalculateBMI()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CalculateBMI(BMIModel model)
    {
        ViewBag.BMI = model.CalculateBMI();
        return View(model);
    }
}
