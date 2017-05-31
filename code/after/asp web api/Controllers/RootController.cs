using System.Web.Http;

namespace asp_web_api.Controllers
{
    public class RootController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "API is ready to receive requests";
        }        
    }
}