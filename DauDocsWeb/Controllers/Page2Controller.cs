using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DauDocsWeb.Controllers
{
    public class Page2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}