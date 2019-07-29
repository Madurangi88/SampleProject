using Microsoft.Extensions.DependencyInjection; 
using Test.Business.Interfaces;
using Test.Business.Services;

namespace Test.Api.Helpers
{
    public class ServiceInjector
    {
        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>(); 
            services.AddTransient<IDestinationService, DestinationService>(); 

        }
    }
}
