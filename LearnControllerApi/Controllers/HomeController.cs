using Microsoft.AspNetCore.Mvc;

namespace LearnControllerApi.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController
    {
        [HttpGet]
        public string GetMessage()
        {
            return "Hello World";
        }
    }
}
