using Microsoft.AspNetCore.Mvc;
using AITeammate.Models;

namespace AITeammate.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View();
    }
}
