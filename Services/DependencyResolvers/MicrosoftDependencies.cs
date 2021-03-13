using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DependencyResolvers
{
    public static class MicrosoftDependencies
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthManager>();
        }
    }
}
