using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cw11.Configs
{
    public class MedicamentEFConfig : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(m => m.IdMedicament);

            builder
                .Property(m => m.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(m => m.Description)
                .HasMaxLength(50);

            builder
                .Property(m => m.Type)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}

