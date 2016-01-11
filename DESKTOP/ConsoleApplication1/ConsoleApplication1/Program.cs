using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Net.Http;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "http://127.0.0.1:645";
            Uri uri = new Uri(address);
            Console.WriteLine(uri.AbsolutePath); 
            HttpClient http = new HttpClient();
            HttpClientHandler cd = new HttpClientHandler();
            HttpContent hc = 
            
            http.GetStreamAsync(uri);
            Console.WriteLine(http.GetStreamAsync(uri).Result.ToString());
            Console.ReadLine();
        }
}
}
