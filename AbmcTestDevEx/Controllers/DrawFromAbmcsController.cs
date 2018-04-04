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

namespace AbmcTestDevEx.Controllers
{
    [Route("api/[controller]")]
    public class DrawFromAbmcsController : Controller
    {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://www.jasonbase.com/things/jWne.json");
                var result = JsonConvert.DeserializeObject<List<DrawFromAbmc.RootObject>>(json);
                return DataSourceLoader.Load(result, loadOptions);
            }
        }

    }
}