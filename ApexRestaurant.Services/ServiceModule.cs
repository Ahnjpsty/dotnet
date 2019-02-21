using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;

namespace ApexRestaurant.Services
{
    public class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
        }
        
    }
}