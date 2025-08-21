namespace SecurePharmaAPI.Models
{
    public class Doctor : Person
    {

        public string Specialization { get; set; } = String.Empty; // Spécialisation du médecin
        public string LicenseNumber { get; set; } = String.Empty; // Numéro de licence du médecin
        public string? ContactNumber { get; set; } // Numéro de contact du médecin

        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    }
}
