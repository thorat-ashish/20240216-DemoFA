using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DemoFA
{
    public class HTTPExample
    {
        private readonly ILogger<HTTPExample> _logger;

        public HTTPExample(ILogger<HTTPExample> logger)
        {
            _logger = logger;
        }

        [Function("HTTPExample")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions! Deployed via Azure DevOps!!");
        }
    }
}
