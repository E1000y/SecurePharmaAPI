namespace SecurePharmaAPI.Models
{
    public class Doctor : Person
    {

        public string Specialization { get; set; } = string.Empty; // Spécialisation du médecin
        public string LicenseNumber { get; set; } = string.Empty; // Numéro de licence du médecin
        public string ContactNumber { get; set; } = string.Empty; // Numéro de contact du médecin

        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    }
}
