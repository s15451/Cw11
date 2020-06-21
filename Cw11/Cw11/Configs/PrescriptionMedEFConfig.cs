using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Configs
{
    public class PrescriptionMedEFConfig : IEntityTypeConfiguration<PrescriptionMedicament>
    {
        public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
        {
            builder.HasKey(pm => new { pm.IdMedicament, pm.IdPrescription });

            builder
                .Property(pm => pm.Details)
                .HasMaxLength(160);
        }
    }
}
