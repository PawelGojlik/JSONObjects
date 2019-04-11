using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace JSONObjects
{
    public class JSONObjectList
    {
        private readonly List<JSONObject> list;

            public JSONObjectList(string url)
            {
                using (WebClient webClient = new WebClient())
                {
                list = JsonConvert.DeserializeObject<List<JSONObject>>(webClient.DownloadString(url));
                }
             }
        public void Sort()
        {
            list.OrderBy(i => i.value);
        }

        public void SaveToXML(string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(JSONObject));

                using (FileStream file = File.Create(path))
                {
                    foreach (var item in list)
                    {
                        writer.Serialize(file, item);
                    }
                }
        }
    }
}
