using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infra.Data.EFCore.Mapping;

public class BuildingMap : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.ToTable("tbl_edificio")
            .Property(b => b.Id)
            .HasColumnName("CODIGO_EDIFICIO");
        
        builder
            .Property(b => b.Name)
            .HasColumnName("NOME_EDIFICIO");

        builder
            .Property(b => b.Floors)
            .HasColumnName("ANDARES");
        
        builder
            .Property(b => b.CityId)
            .HasColumnName("CODIGO_CIDADE");

        builder
            .HasOne(b => b.City);

        builder.HasMany(b => b.Apartaments)
            .WithOne(a => a.Building)
            .HasForeignKey(a => a.BuildingId);
    }
}