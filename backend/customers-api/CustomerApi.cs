using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using customerApi.Data;
using customerApi.Model;

namespace customerApi
{
    public class CustomerApi
    {
        private readonly ICustomerData _data;

        public CustomerApi(ICustomerData data)
        {
            _data = data;
        }

        [FunctionName("GetCustomers")]
        public async Task<IActionResult> GetCustomers(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "customers")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Retrieving customers");
            var customers = _data.GetCustomers();
            return new OkObjectResult(customers);
        }
    }
}
