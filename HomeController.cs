
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CoreNet_Project_2_Web_Avancer.Models;

namespace CoreNet_Project_2_Web_Avancer.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Commandes()
    {

        return View();

    }

    public IActionResult Merci(InformationVache model)
    {

        if (model.Nom == null)
        {
            return RedirectToAction("Commandes");
        }
        else if (model.DateDeNaissance == null)
        {
            return RedirectToAction("Commandes");
        }
        else if (model.Budget == 0)
        {
            return RedirectToAction("Commandes");
        }
        else if (model.Telephone == null)
        {
            return RedirectToAction("Commandes");
        }

        //Si Tous l'information important est a jour
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
