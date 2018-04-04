using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using AbmcTestDevEx.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AbmcTestDevEx.Controllers {

    [Route("api/[controller]")]
    public class OrdersController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        }

        public ActionResult Index()
        {
            return View(DrawFromAbmcsController.result);
        }

    }
}