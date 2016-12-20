using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication12
{

    class Program
    {
        public static void Main(string[] args)
        {
            var json = new WebClient().DownloadString("http://www.omdbapi.com/?s=kod");

            Console.Write(json);
          
            dynamic stuff = JsonConvert.DeserializeObject(json);

            Console.WriteLine(stuff);

            Console.ReadLine();
        }

    }
}
