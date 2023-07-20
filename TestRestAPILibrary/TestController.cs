using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace TestRestAPILibrary
{
    //[ApiController]
    //[Route("test")]
    public abstract class TestController: ControllerBase
    {
        IConfiguration configuration;

        public TestController(IConfiguration configuration) 
        {
            this.configuration = configuration;
        }

        [HttpGet("env-name")]
        public ActionResult GetEnvironmentName()
        {
            return Ok(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
        }

        [HttpGet("hi")]
        public ActionResult Ping()
        {
            return Ok("hello");
        }
    }
}