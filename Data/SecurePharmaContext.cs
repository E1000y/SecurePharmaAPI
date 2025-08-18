using Microsoft.EntityFrameworkCore;
using SecurePharmaAPI.Models;


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
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Déclarer la clé composite pour PrescriptionMedicine
            modelBuilder.Entity<PrescriptionMedicine>()
                .HasKey(pm => new { pm.PrescriptionId, pm.MedicineId });

            // Configurer la relation entre Prescription et PrescriptionMedicine
            modelBuilder.Entity<Prescription>()
                .HasMany(p => p.PrescriptionMedicines)
                .WithOne(pm => pm.Prescription)
                .HasForeignKey(pm => pm.PrescriptionId);

            // Configurer la relation entre Medicine et PrescriptionMedicine
            modelBuilder.Entity<Medicine>()
                .HasMany(m => m.PrescriptionMedicines)
                .WithOne(pm => pm.Medicine)
                .HasForeignKey(pm => pm.MedicineId);

            // Configurer la relation entre Medicine et Storage

            modelBuilder.Entity<Medicine>()
                .HasOne(m => m.Storage)
                .WithMany(s => s.Medicines)
                .HasForeignKey(m => m.StorageId).IsRequired(false);

            // Configurer la relation entre Prescription et Doctor
               modelBuilder.Entity<Doctor>()
                .HasMany(d => d.Prescriptions)
                .WithOne(p => p.Doctor)
                .HasForeignKey(p => p.DoctorId).IsRequired(false);

            // Configurer la relation entre Prescription et Patient
            modelBuilder.Entity<Patient>()
                .HasMany(p => p.Prescriptions)
                .WithOne(pr => pr.Patient)
                .HasForeignKey(pr => pr.PatientId).IsRequired(false);








        }
    }
}
