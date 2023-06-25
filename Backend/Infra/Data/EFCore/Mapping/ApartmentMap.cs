using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infra.Data.EFCore.Mapping;

public class ApartmentMap : IEntityTypeConfiguration<Apartment>
{
    public void Configure(EntityTypeBuilder<Apartment> builder)
    {
        builder.ToTable("TABELA_APARTAMENTO")
            .Property(a => a.Id)
            .HasColumnName("CODIGO_APARTAMENTO");

        builder.HasOne(a => a.Building);

        builder
            .Property(a => a.Floor)
            .HasColumnName("ANDAR");
        
        builder
            .Property(a => a.BadroomsQuantity)
            .HasColumnName("NUMERO_QUARTOS");

        builder
            .Property(a => a.SizeM2)
            .HasColumnName("METRAGEM")
            .HasColumnType("DECIMAL(18,2)");

        builder
            .Property(a => a.BuildingId)
            .HasColumnName("CODIGO_EDIFICIO");

        builder.HasMany(a => a.Payments)
            .WithOne(a => a.Apartment)
            .HasForeignKey(a => a.ApartamentId);
    }
}