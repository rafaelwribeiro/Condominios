using System.Data;
using Backend.Domain.Entities;
using Backend.Domain.Report;
using Backend.Infra.Data.EFCore.Mapping;
using Microsoft.Data.SqlClient;
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

    public async Task<IList<CondominiumPaymentRankingReport>> ExecuteStoredProcPaymentRank(DateTime startDate, DateTime finalDate)
    {
        var result = new List<CondominiumPaymentRankingReport>();
        var id = 0;
        using (var command = Database.GetDbConnection().CreateCommand())
        {
            command.CommandText = "sp_ranking_condominio";
            command.CommandType = CommandType.StoredProcedure;

            var startDateParam = new SqlParameter("@dt_inicio", SqlDbType.DateTime)
            {
                Value = startDate
            };
            command.Parameters.Add(startDateParam);

            var dataFinalParam = new SqlParameter("@dt_termino", SqlDbType.DateTime)
            {
                Value = finalDate
            };
            command.Parameters.Add(dataFinalParam);

            await Database.OpenConnectionAsync();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(new CondominiumPaymentRankingReport
                    {
                        Id              = id++,
                        ApartmentId     = reader.GetInt32(0),
                        BuildingId      = reader.GetInt32(1),
                        BuildingName    = reader.GetString(2),
                        SizeM2          = reader.GetDecimal(3),
                        Floor           = reader.GetInt32(4),
                        RoomQuantity    = reader.GetInt32(5),
                        CityName        = reader.GetString(6),
                        State           = reader.GetString(7),
                        Value           = reader.GetDecimal(8)
                    });
                }
            }
        }
        return result;
    }
}