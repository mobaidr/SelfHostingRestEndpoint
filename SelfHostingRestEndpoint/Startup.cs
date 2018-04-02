using Newtonsoft.Json.Serialization;
using Owin;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;

namespace SelfHostingRestEndpoint
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultAction",
            //    routeTemplate: "api/{controller}"
            //);

            config.Routes.MapHttpRoute(
               name: "ControllerWithAction",
               routeTemplate: "api/{controller}/{action}"
           );

            //config.Routes.MapHttpRoute(
            //    name: "DefaultAction",
            //    routeTemplate: "api/{controller}"
            //);

            ((DefaultContractResolver)config.Formatters.JsonFormatter.SerializerSettings.ContractResolver).IgnoreSerializableAttribute = true;
            appBuilder.UseWebApi(config);
        }
    }
}
