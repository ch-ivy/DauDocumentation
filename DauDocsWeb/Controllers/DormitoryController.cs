using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DauDocsWeb.Controllers
{
    public class DormitoryController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}