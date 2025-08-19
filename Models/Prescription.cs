namespace SecurePharmaAPI.Models
{
    public class Prescription
    {
        public int Id { get; set; } // Identifiant de l'ordonnance
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Date de création de l'ordonnance
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Date de dernière mise à jour de l'ordonnance
        public string Remarks { get; set; } = string.Empty; // Remarques ou instructions supplémentaires


        // Relations avec d'autres entités
        public int? DoctorId { get; set; } // Identifiant du médecin (clé étrangère)  
        public Doctor? Doctor { get; set; } = null!; // Médecin qui a prescrit l'ordonnance
        public int PatientId { get; set; } // Identifiant du patient (clé étrangère)
        public Patient Patient { get; set; } = null!; // Patient pour qui l'ordonnance est émise

        // Médicaments prescrits dans cette ordonnance
        public ICollection<PrescriptionMedicine> PrescriptionMedicines { get; set; } = new List<PrescriptionMedicine>();
    }

}
