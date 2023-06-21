using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infra.Data.EFCore.Mapping;

public class ApartmentMap : IEntityTypeConfiguration<Apartment>
{
    public void Configure(EntityTypeBuilder<Apartment> builder)
    {
        builder.ToTable("tbl_apartamento")
            .Property(a => a.Id)
            .HasColumnName("CODIGO_APARTAMENTO");

        builder.HasOne(a => a.Building);

        builder
            .Property(a => a.Floor)
            .HasColumnName("ANDAR");
        
        builder
            .Property(a => a.BadroomsQuantity)
            .HasColumnName("NUMERO_QUARTOS");

        builder.HasMany(a => a.Payments)
            .WithOne(a => a.Apartment)
            .HasForeignKey(a => a.ApartamentId);
    }
}