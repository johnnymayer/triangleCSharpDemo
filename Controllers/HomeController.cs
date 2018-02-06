using Microsoft.AspNetCore.Mvc;
using Triangle.Models;

namespace Triangle.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult TriangleForm()
    {
        return View();
    }

    [Route("/triangle_info")]
    public ActionResult TriangleInfo()
    {

        TriData newTriData = new TriData();
        newTriData.SetSideA(int.Parse(Request.Query["sideA"]));
        newTriData.SetSideB(int.Parse(Request.Query["sideB"]));
        newTriData.SetSideC(int.Parse(Request.Query["sideC"]));
        string triResult = newTriData.Triangulate(newTriData.GetSideA(), newTriData.GetSideB(), newTriData.GetSideC());
        newTriData.SetResult(triResult);
        // System.Console.WriteLine(GetResult());
        return View(newTriData);

    }
  }
}
