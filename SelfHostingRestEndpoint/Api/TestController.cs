using System.Web.Http;

namespace SelfHostingRestEndpoint.Api
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string Name()
        {
            return "Mohammed Obaidur Rahman";
        }
    }
}
