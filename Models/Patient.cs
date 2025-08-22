

namespace SecurePharmaAPI.Models
{
    public class Patient: Person
    {

        public string SocialSecurityNumber { get; set; } = string.Empty; // Numéro de sécurité sociale

        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();    


    }
}
