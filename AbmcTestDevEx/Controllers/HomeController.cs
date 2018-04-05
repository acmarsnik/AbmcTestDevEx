using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using System.Net;
using AbmcTestDevEx.Models;
using System.IO;

namespace AbmcTestDevEx.Controllers
{
    //[Route("api/[controller]")]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View(SampleData.Orders);
        }

        public ActionResult AbmcFlat()
        {
            return View(AbmcFlatController.abmcFlatList);
        }

        public ActionResult AbmcAsIs()
        {
            return View(AbmcAsIsController.abmcAsIsList);
        }

        // Generated Code
        //public IActionResult Index()
        //{
        //    return View();
        //}  

    }
}
