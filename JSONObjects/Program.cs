using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JSONObjects
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var jsonObjectList = new JSONObjectList("https://api.jsonbin.io/b/5caefde5814711458b4021df/5");
                Console.WriteLine("Data read correctly");

                jsonObjectList.Sort();
                Console.WriteLine("Data sorted");

                jsonObjectList.SaveToXML("D:\\file.xml");
                Console.WriteLine("File saved");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: {0}", e);
                return;
            }

            Console.WriteLine("Operation successful!");
        }
    }
}
