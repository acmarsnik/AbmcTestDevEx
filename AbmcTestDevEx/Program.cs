using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using AbmcTestDevEx.Models;

namespace AbmcTestDevEx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://www.jasonbase.com/things/2dqn.json");
                //EmptyData.empty = JsonConvert.DeserializeObject<List<Empty>>(json);
            }
        var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
