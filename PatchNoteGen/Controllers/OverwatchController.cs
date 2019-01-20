using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatchNoteGen.Models;

namespace PatchNoteGen.Controllers
{
    public class OverwatchController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult button()
        {
            Console.WriteLine("test2");
            return View();
        }
    }
}
