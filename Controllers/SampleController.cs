using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sampleSystem.Models;

namespace sampleSystem.Controllers;

public class SampleController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    Sample mod = new Sample();
    public IActionResult List() {
        return Json(mod.List());
    }

    [HttpPost]
    public IActionResult Create(Sample m){
        mod.Create(m);
        return Json(new { message = "Success" });
    }
    
    public IActionResult Sample() {
        return View();
    }

    [HttpPost]
    public IActionResult Update(Sample m){
        mod.Update(m);
        return Json(new { message = "Success" });
    }

    [HttpPost]
    public IActionResult Delete(int id){
        mod.Delete(id);
        return Json(new { message = "Success" });
    }

    public IActionResult Privacy()
    {
        return View();
    }


}
