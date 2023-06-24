using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infra.Data.EFCore.Mapping;

public class BuildingMap : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.ToTable("TABELA_EDIFICIO")
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

        builder.HasMany(b => b.Apartments)
            .WithOne(a => a.Building)
            .HasForeignKey(a => a.BuildingId);
    }
}