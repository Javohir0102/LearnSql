using LearnSql.Model;
using Microsoft.AspNetCore.Mvc;

namespace LearnControllerApi.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string GetMessage([FromQuery] string name)
        {
            return $"Hello {name}";
        }

        [HttpPost]
        public string PostMessage([FromBody] string name)
        {
            return $"Hello {name}";
        }

        [HttpPut]
        public Contact PutMessage([FromBody] Contact contact)
        {
            return contact;
        }
    }
}
