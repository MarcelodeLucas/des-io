using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sus.io.Controllers
{
    public class testCrudController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
