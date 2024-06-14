using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using poe_progs_3.Models;

namespace poe_progs_3.Controllers
{
    public class StuedntController1 : Controller
    {
        public IActionResult Index()
        {
            return View(new modules());
        }

        [HttpPost]

        public ActionResult Index(modules m)
        {

            m.total = m.modulePerWeek = m.numberOfHours;

            return View(m);

        }
       
    }
}
