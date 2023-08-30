//import
using Microsoft.AspNetCore.Mvc;

//namespace
namespace RazorFun.Controllers;

public class IndexController: Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult IndexView()
    {
        return View("IndexView");
    }
}