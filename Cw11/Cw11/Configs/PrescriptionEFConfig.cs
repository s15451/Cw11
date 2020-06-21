using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Configs
{
    public class PrescriptionEFConfig : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(p => p.IdPrescription);

            builder
                .Property(p => p.Date)
                .HasColumnType("Date")
                .IsRequired();

            builder
                .Property(p => p.DueDate)
                .HasColumnType("Date")
                .IsRequired();

            var prescriptions = new List<Prescription>();
            
            prescriptions.Add(new Prescription
            {
                IdPrescription = 1,
                Date = DateTime.Now.AddDays(-5),
                DueDate = DateTime.Now.AddDays(20),
                IdPatient = 2,
                IdDoctor = 1
            });
            
            prescriptions.Add(new Prescription
            {
                IdPrescription = 2,
                Date = DateTime.Now.AddDays(-20),
                DueDate = DateTime.Now.AddDays(5),
                IdPatient = 1,
                IdDoctor = 2
            });
            
            prescriptions.Add(new Prescription
            {
                IdPrescription = 3,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(25),
                IdPatient = 2,
                IdDoctor = 2
            });

            prescriptions.Add(new Prescription
            {
                IdPrescription = 3,
                Date = DateTime.Now.AddDays(-25),
                DueDate = DateTime.Now,
                IdPatient = 1,
                IdDoctor = 1
            });

            builder.HasData(prescriptions);
        }
    }
}
