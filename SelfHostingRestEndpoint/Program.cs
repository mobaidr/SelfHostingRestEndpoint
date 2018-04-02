using Microsoft.Owin.Hosting;
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
            WebApp.Start<Startup>(@"http://localhost");

            await Task.Delay(-1);
        }
    }
}
