using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using AbmcTestDevEx.Models;
using System.IO;

namespace AbmcTestDevEx.Controllers
{
    [Route("api/[controller]")]
    public class DrawFromAbmcsController : Controller
    {
        //public static WebClient wc = new WebClient();
        //public static string json = wc.DownloadString("https://www.jasonbase.com/things/jWne.json");
        public static StreamReader r = new StreamReader("..\\Data\\DrawFromAbmcFlat.json");
        public static string json = r.ReadToEnd();
        public static List<DrawFromAbmc.RootObject> result = JsonConvert.DeserializeObject<List<DrawFromAbmc.RootObject>>(json);

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
                return DataSourceLoader.Load(result, loadOptions);
        }

        public ActionResult Index()
        {
            return View(result);
        }

    }
}