using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string url = "https://softuni.bg/";
            HttpClient httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            Console.Write(html);
        }
    }
}
