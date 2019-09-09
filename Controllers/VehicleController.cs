using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers 
{
    public class VehicleController : Controllers 
    {
        //
        // GET: /Index/

        public ActionResult Index() 
        {
            return View();
        }

        //
        // GET: /Vehicles/

        public ActionResult Vehicles() 
        {
            return View();
        }

        public IActionResult Edit() 
        {
            var model = new Edit { };

            return PartialView("_editpartial", model);
        }
    }
}