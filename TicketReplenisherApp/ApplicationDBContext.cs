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
        public DbSet<Ticket.UserAccount> UserAccountTable { get; set; }
        public DbSet<OrderedTariffs> OrderedTariffTable { get; set; }
        
        public ApplicationDBContext() { }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderedTariffs>().HasOne(ot => ot.Tariff).WithMany().HasForeignKey(ot => ot.TariffId).OnDelete(DeleteBehavior.Cascade);// HasKey(ot => new { ot.TariffId, ot.DateOfOrder });
            modelBuilder.Entity<OrderedTariffs>().HasKey(ot => new { ot.TariffId, ot.DateOfOrder });

            modelBuilder.Entity<OrderedTariffs>().HasIndex(ot => new { ot.DateOfOrder, ot.TariffId}).IsUnique().HasDatabaseName("IX_ReversedClusteredIndex");
        }
    }
}
