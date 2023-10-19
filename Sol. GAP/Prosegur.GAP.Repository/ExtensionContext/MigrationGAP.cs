using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prosegur.GAP.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosegur.GAP.Repository.ExtensionContext
{
    public static class MigrationGAP
    {
        public static IHost MigratedDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            using (var appContext = scope.ServiceProvider.GetRequiredService<GAPDBContext>())
            {
                appContext.Database.EnsureCreated();
            }

            return host;
        }   
    }
}
