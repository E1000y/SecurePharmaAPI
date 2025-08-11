namespace SecurePharmaAPI.Models
{
    public class Prescription
    {
        public int Id { get; set; } // Identifiant de l'ordonnance
        public string PatientName { get; set; } = string.Empty; // Nom du patient
        public string DoctorName { get; set; } = string.Empty; // Nom du médecin
        public DateTime PrescriptionDate { get; set; } // Date de prescription
        public DateTime ExpiryDate { get; set; } // Date d'expiration

        // Médicaments prescrits dans cette ordonnance
        public ICollection<PrescriptionMedicine> PrescriptionMedicines { get; set; } = new List<PrescriptionMedicine>();
    }

}
