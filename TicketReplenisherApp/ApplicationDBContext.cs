using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TicketReplenisherApp
{
    public partial class ApplicationDBContext : DbContext
    { 
        public DbSet<TariffManyTransports> TariffManyTransportsTable { get; set; }
        public DbSet<TariffOneTransport> TariffOneTransportTable { get; set; }
        public DbSet<Tariff> TariffTable { get; set; }
        public DbSet<Ticket> TicketTable { get; set; }
        public DbSet<TariffManyTransports.TariffGroups> TariffGroupsTable { get; set; }
        public DbSet<Ticket.UserAccount> UserAccounts { get; set; }
        
        public ApplicationDBContext() { }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TicketReplenisherDB;Trusted_Connection=True;");
        }*/
    }
}
