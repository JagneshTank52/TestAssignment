using Microsoft.AspNetCore.Mvc;

namespace TestAssignment.Web.Controllers;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {   
        return View();
    }
}
