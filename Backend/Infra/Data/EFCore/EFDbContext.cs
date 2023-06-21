using Backend.Domain.Entities;
using Backend.Infra.Data.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Backend.Infra.Data.EFCore;

public class EFDbContext : DbContext
{
    public DbSet<City> Cities { get; set; }
    public DbSet<Building> Buildings { get; set; }
    public DbSet<Apartment> Apartaments { get; set; }
    public DbSet<CondominiumPayment> CondominiumPayments { get; set; }
    

    public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CityMap());
        modelBuilder.ApplyConfiguration(new BuildingMap());
        modelBuilder.ApplyConfiguration(new ApartmentMap());
        modelBuilder.ApplyConfiguration(new CondominiumPaymentMap());
    }
}