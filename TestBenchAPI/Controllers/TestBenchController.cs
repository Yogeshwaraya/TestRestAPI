using Microsoft.AspNetCore.Mvc;
using TestRestAPILibrary;

namespace TestRestAPI.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestBenchController : TestController
    {
        private readonly ILogger<TestBenchController> _logger;

        public TestBenchController(IConfiguration configuration, 
            ILogger<TestBenchController> logger) : base(configuration)
        {
            _logger = logger;
        }
    }
}