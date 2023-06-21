using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infra.Data.EFCore.Mapping;

public class CityMap : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("tbl_cidade")
            .Property(c => c.Id)
            .HasColumnName("CODIGO_CIDADE");
        
        builder.Property(c => c.Name)
            .HasColumnName("NOME_CIDADE");

        builder.Property(c => c.State)
            .HasColumnName("ESTADO");
    }
}