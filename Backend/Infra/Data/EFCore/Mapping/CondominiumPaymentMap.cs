using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Infra.Data.EFCore.Mapping;

public class CondominiumPaymentMap : IEntityTypeConfiguration<CondominiumPayment>
{
    public void Configure(EntityTypeBuilder<CondominiumPayment> builder)
    {
        builder.ToTable("TABELA_PAGAMENTOS_CONDOMINIO")
            .Property(c => c.Id)
            .HasColumnName("CODIGO_CONDOMINIO");
        
        builder.Property(c => c.CreatedAt)
            .HasColumnName("DATA_PAGAMENTO");

        builder.Property(c => c.Value)
            .HasColumnName("VALOR_PAGAMENTO");

        builder.HasOne(c => c.Apartment);
    }
}