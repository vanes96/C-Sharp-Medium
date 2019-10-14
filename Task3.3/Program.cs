using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("https://yandex.ru/");
            var jsonData = new Dictionary<string, string>
            {
              {"CustomerId", "5"},
              {"CustomerName", "Pepsi"}
            };

            HttpContent content = new StringContent(JsonConvert.SerializeObject(jsonData), Encoding.UTF8, "application/json");

            //var task = Task.Run(() => SendURI(uri, "POST", content));
            var task = Task.Run(() => SendRequest(uri, "GET", content));

            task.Wait();

            Console.WriteLine(task.Result);
            Console.ReadLine();
        }

        static async Task<string> SendRequest(Uri uri, string method = "GET", HttpContent content = null)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = new HttpMethod(method),
                    RequestUri = uri,
                    Content = content
                };

                HttpResponseMessage result = null;

                switch(method)
                {
                    case "GET":
                        result = await client.GetAsync(uri);
                        if (result.IsSuccessStatusCode)
                            response = await result.Content.ReadAsStringAsync();
                        break;

                    case "POST":
                        result = await client.PostAsync(uri, content);
                        if (result.IsSuccessStatusCode)
                            response = result.StatusCode.ToString();
                        break;
                }
            }

            return response;
        }

    }
}
