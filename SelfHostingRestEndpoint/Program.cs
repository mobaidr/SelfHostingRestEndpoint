using Microsoft.Owin.Hosting;
using System;
using System.Threading.Tasks;


namespace SelfHostingRestEndpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            StartOwinWebApp().GetAwaiter().GetResult();
        }

        private static async Task StartOwinWebApp()
        {
            int appPort = Convert.ToInt32(Environment.GetEnvironmentVariable("PORT") ?? "4080");
            string host = appPort != 4080 ? "*" : "localhost";
            string hostUrl = $"http://{host}:{appPort}";

            Console.WriteLine($"host URL : {hostUrl}");

            StartOptions so = new StartOptions
            {
                Port = appPort
            };
            so.Urls.Add(hostUrl);

            WebApp.Start<Startup>(so);

            await Task.Delay(-1);
        }
    }
}
