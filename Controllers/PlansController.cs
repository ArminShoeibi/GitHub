using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHub.Controllers
{
    public class PlansController : Controller
    {
        public async Task<IActionResult> Index()
        {
            await Task.Delay(1000); // just for simulating 
            return View();
        }
    }
}
