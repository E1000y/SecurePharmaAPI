namespace SecurePharmaAPI.Models
{
    public class Dr : Person
    {

        public string Specialization { get; set; } = string.Empty; // Spécialisation du médecin
        public string LicenseNumber { get; set; } = string.Empty; // Numéro de licence du médecin
        public string ContactNumber { get; set; } = string.Empty; // Numéro de contact du médecin


    }
}
