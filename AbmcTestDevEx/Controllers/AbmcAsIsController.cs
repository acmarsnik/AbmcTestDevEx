using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AbmcTestDevEx.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AbmcTestDevEx.Controllers
{
    public class AbmcAsIsController : Controller
    {

        //public static WebClient abmcAsIsWebClient = new WebClient();
        //public static string abmcAsIsJson = abmcAsIsWebClient.DownloadString("https://www.jasonbase.com/things/2dqn.json");
        //Full file path
        //public static StreamReader abmcAsIsStreamReader = new StreamReader(@"C:\\Users\\amarsni\\source\\repos\\AbmcTestDevEx\\AbmcTestDevEx\\Data\\AbmcAsIs.json");
        //Relative file path
        public static StreamReader abmcAsIsStreamReader = new StreamReader("/Users/amarsni/source/repos/AbmcTestDevEx/AbmcTestDevEx/Data/AbmcAsIs.json");
        public static string abmcAsIsJson = abmcAsIsStreamReader.ReadToEnd();
        public static List<AbmcAsIs.RootObject> abmcAsIsList = JsonConvert.DeserializeObject<List<AbmcAsIs.RootObject>>(abmcAsIsJson);

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(abmcAsIsList, loadOptions);
        }

        [HttpGet]
        public object GetContributorItemDetailsByTrimbleItemId(string trimbleItemId, DataSourceLoadOptions options)
        {

            AbmcAsIs.RootObject abmcRootObjectByTrimbleItemId = abmcAsIsList.FirstOrDefault(c => c.trimbleItemId == trimbleItemId);

            return DataSourceLoader.Load(abmcRootObjectByTrimbleItemId.contributorItemDetails, options);
        }
    }
}