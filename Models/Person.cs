namespace SecurePharmaAPI.Models
{
    public abstract class Person
    {
        public int Id { get; set; } // Identifiant unique du patient
        public string FirstName { get; set; } = string.Empty; // prénom du patient
        public string LastName { get; set; } = string.Empty; // nom de famille du patient
        public DateTime DateOfBirth { get; set; } // Date de naissance de la personne
    }
}