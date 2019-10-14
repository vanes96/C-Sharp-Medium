using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Task.Run(() => SendRequestAsync(new Uri("https://yandex.ru/"))).Wait();
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Console.ReadKey();
            }
            //var jsonData = new Dictionary<string, string> { {"Field1", "value1"}, {"Field2", "value2"} };
            //HttpContent content = new StringContent(JsonConvert.SerializeObject(jsonData), Encoding.UTF8, "application/json");
        }

        static async Task SendRequestAsync(Uri uri, string callbackMethodName = "WriteResponseContent", string httpMethod = "GET", HttpContent httpContent = null)
        {
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = new HttpMethod(httpMethod),
                    RequestUri = uri,
                    Content = httpContent
                };

                HttpResponseMessage responseMessage = null;
                MethodInfo callbackMethod = typeof(Program).GetMethod(callbackMethodName);

                switch (httpMethod)
                {
                    case "GET":
                        responseMessage = await client.GetAsync(uri);                        
                        break;
                    case "POST":
                        responseMessage = await client.PostAsync(uri, httpContent);
                        break;
                }

                if (responseMessage.IsSuccessStatusCode)
                    callbackMethod.Invoke(null, new object[] { responseMessage.StatusCode.ToString() });
            }
        }

        public static void WriteResponseContent(string responseContent)
        {
            Console.WriteLine(responseContent);
            Console.ReadKey();
        }
    }
}
