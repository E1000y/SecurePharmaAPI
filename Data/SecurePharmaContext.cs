using Microsoft.EntityFrameworkCore;
using SecurePharmaAPI.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SecurePharmaAPI.Data
{
    public class SecurePharmaContext : DbContext
    {
        public SecurePharmaContext(DbContextOptions<SecurePharmaContext> options)
            : base(options)
        {
        }

        // Déclaration des tables
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<PrescriptionMedicine> PrescriptionMedicines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration de la clé primaire composite pour PrescriptionMedicine
            modelBuilder.Entity<PrescriptionMedicine>()
                .HasKey(pm => new { pm.PrescriptionId, pm.MedicineId });

            // Relations Prescription <> PrescriptionMedicine
            modelBuilder.Entity<PrescriptionMedicine>()
                .HasOne(pm => pm.Prescription)
                .WithMany(p => p.PrescriptionMedicines)
                .HasForeignKey(pm => pm.PrescriptionId);

            // Relations Medicine <> PrescriptionMedicine
            modelBuilder.Entity<PrescriptionMedicine>()
                .HasOne(pm => pm.Medicine)
                .WithMany(m => m.PrescriptionMedicines)
                .HasForeignKey(pm => pm.MedicineId);
        }
    }
}
