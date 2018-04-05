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
    public class AbmcFlatController : Controller
    {
        //public static WebClient abmcFlatWebClient = new WebClient();
        //public static string abmcFlatJson = abmcFlatWebClient.DownloadString("https://www.jasonbase.com/things/jWne.json");
        //Full file path
        //public static StreamReader abmcFlatStreamReader = new StreamReader(@"C:\\Users\\amarsni\\source\\repos\\AbmcTestDevEx\\AbmcTestDevEx\\Data\\AbmcFlat.json");
        //Relative file path
        public static StreamReader abmcFlatStreamReader = new StreamReader("/Users/amarsni/source/repos/AbmcTestDevEx/AbmcTestDevEx/Data/AbmcFlat.json");
        public static string abmcFlatJson = abmcFlatStreamReader.ReadToEnd();
        public static List<AbmcFlat.RootObject> abmcFlatList = JsonConvert.DeserializeObject<List<AbmcFlat.RootObject>>(abmcFlatJson);

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
                return DataSourceLoader.Load(abmcFlatList, loadOptions);
        }

    }
}