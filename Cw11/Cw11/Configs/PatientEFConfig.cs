using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Configs
{
    public class PatientEFConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.IdPatient);

            builder
                .Property(p => p.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .HasMaxLength(40)
                .IsRequired();

            builder
                .Property(p => p.BirthDate)
                .HasColumnType("Date");

            var patients = new List<Patient>();
            patients.Add(new Patient { IdPatient = 1, FirstName = "Natalia", LastName = "Noga", BirthDate = DateTime.Now.AddYears(-35)});
            patients.Add(new Patient { IdPatient = 2, FirstName = "Zygmunt", LastName = "Zakole", BirthDate = DateTime.Now.AddDays(-7656) });
            patients.Add(new Patient { IdPatient = 3, FirstName = "Bartosz", LastName = "Brzoza", BirthDate = DateTime.Now.AddDays(-4550) });

            builder.HasData(patients);
        }
    }
}
