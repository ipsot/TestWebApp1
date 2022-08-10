using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace ConsoleClient
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter");
            Console.ReadKey();

            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            string jsonData = webClient.DownloadString("https://localhost:44321/api/test/getperson");
            Person person = JsonConvert.DeserializeObject<Person>(jsonData);

            Console.WriteLine($"Name:{person.Name} Age:{person.Age}");
            Console.ReadKey();
        }
    }
}
