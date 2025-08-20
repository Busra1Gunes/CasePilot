using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CasePilotContextFactory : IDesignTimeDbContextFactory<CasePilotContext>
    {
        public CasePilotContext CreateDbContext(string[] args)
        {
            // appsettings.json’u oku
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WebAPI"))
               .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CasePilotContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);

            return new CasePilotContext(optionsBuilder.Options, configuration);
        }
    }
}
