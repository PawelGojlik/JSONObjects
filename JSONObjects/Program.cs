using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace JSONObjects
{

    class Program
    {
        static void Main(string[] args)
        {
            string json;

            using (WebClient webClient = new WebClient())
            {
                json = webClient.DownloadString("https://api.jsonbin.io/b/5caefde5814711458b4021df/5");
            }

            var JSONObjectsList = JsonConvert.DeserializeObject<List<JSONObject>>(json).OrderBy(o=>o.value);

            

            foreach (var item in JSONObjectsList)
            {
                Console.WriteLine("id: {0} ,name: {1}, value: {2}, registered: {3}",
                    item.id, item.name, item.value, item.registered);
            }
        }
    }
}
