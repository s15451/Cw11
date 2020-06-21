using Cw11.Configs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Models
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

        public DoctorDbContext() { }

        public DoctorDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorEFConfig());
            modelBuilder.ApplyConfiguration(new PatientEFConfig());
            modelBuilder.ApplyConfiguration(new PrescriptionEFConfig());
            modelBuilder.ApplyConfiguration(new MedicamentEFConfig());
            modelBuilder.ApplyConfiguration(new PrescriptionMedEFConfig());
        }
    }
}
