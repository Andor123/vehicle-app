using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers 
{
    public class VehicleController : Controllers 
    {
        //
        // GET: /Index/

        public IActionResult Index() 
        {
            var model = new Index { };

            return View("index", model);
        }

        //
        // GET: /Vehicles/

        public IActionResult Vehicles() 
        {
            var model = new Vehicles { };

            return View("vehicles", model);
        }

        public IActionResult Edit() 
        {
            var model = new Edit { };

            return PartialView("_editpartial", model);
        }
    }
}