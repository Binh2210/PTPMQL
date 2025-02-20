using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
namespace FirstWebMVC.Controllers;
public class InvoiceController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult CalculateTotalPrice()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CalculateTotalPrice(InvoiceModel model)
    {
        ViewBag.TotalPrice = model.CalculateTotalPrice();
        return View(model);
    }
}
