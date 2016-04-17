using System.Collections.Generic;
using System.Web.Http;

namespace TodoService.Controllers
{
    [RoutePrefix("api/todo")]
    public class TodoController : ApiController
    {
        [HttpGet]
        [Route("test")]
        public string Test()
        {
            return "I am alive";
        }
    }
}
