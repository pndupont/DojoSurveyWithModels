using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DOJOSURVEYWITHMODEL.Models;

namespace DOJOSURVEYWITHMODEL.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }
        [HttpPost("result")]
        public IActionResult Submission(Survey mySurvey)
        {

            return View("result", mySurvey);
        }

    }
}
        