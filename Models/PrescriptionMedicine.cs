namespace SecurePharmaAPI.Models
{
    public class PrescriptionMedicine
    {
        public int PrescriptionId { get; set; } // Clé étrangère vers Prescription
        public Prescription Prescription { get; set; } = null!; // Ordonnance associée

        public int MedicineId { get; set; } // Clé étrangère vers Medicine
        public Medicine Medicine { get; set; } = null!; // Médicament associé

        // Champs spécifiques à cette prescription
        public string DosageInstructions { get; set; } = string.Empty; // ex : "1 comprimé matin et soir"
        public int Quantity { get; set; } // Nombre d'unités prescrites
    }


}
