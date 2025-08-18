

namespace SecurePharmaAPI.Models
{
    public class Patient: Person
    {
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();    


    }
}
