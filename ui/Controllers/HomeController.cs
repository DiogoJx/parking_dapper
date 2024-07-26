using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace parking_dapper.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public IActionResult Index()
    {
        return View();
    }


}
