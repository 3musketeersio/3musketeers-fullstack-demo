using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using customerApi.Data;

[assembly: FunctionsStartup(typeof(customerApi.Startup))]

namespace customerApi
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<ICustomerData, InMemoryCustomerData>();
        }
    }
}