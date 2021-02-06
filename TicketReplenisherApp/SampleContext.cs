using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
namespace TicketReplenisherApp
{
    class SampleContext: IDesignTimeDbContextFactory<ApplicationDBContext>
    {
        public ApplicationDBContext CreateDbContext(string[] args)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder() { };
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            string connectionString = builder.Build().GetConnectionString("DefaultConnection");

            DbContextOptionsBuilder<ApplicationDBContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            optionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout(300));
            return new ApplicationDBContext(optionsBuilder.Options);
        }
    }
}
