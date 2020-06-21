using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Configs
{
    public class DoctorEFConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder
                .HasKey(doc => doc.IdDoctor);

            builder
                .Property(doc => doc.FirstName)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(doc => doc.LastName)
                .HasMaxLength(40)
                .IsRequired();

            builder
                .Property(d => d.Email)
                .HasMaxLength(30);

            var doctors = new List<Doctor>();
            doctors.Add(new Doctor { IdDoctor = 1, FirstName = "Mariusz", LastName = "Monokiel", Email = "mamo@gmail.com" });
            doctors.Add(new Doctor { IdDoctor = 2, FirstName = "Anastazja", LastName = "Ambona", Email = "anam@wp.pl" });
            doctors.Add(new Doctor { IdDoctor = 3, FirstName = "Kamil", LastName = "Komin", Email = "kako@yahoo.com" });

            builder
                .HasData(doctors);
        }
    }
}
