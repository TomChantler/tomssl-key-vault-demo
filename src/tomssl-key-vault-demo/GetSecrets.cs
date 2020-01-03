using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace tomssl_key_vault_demo
{
    public static class GetSecrets
    {
        [FunctionName("GetSecrets")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult(new { TestSecret = Environment.GetEnvironmentVariable("TestSecret"), SpecialSecret = Environment.GetEnvironmentVariable("SpecialSecret") });
        }
    }
}
