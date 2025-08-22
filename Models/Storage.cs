namespace SecurePharmaAPI.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        // C'est une simple propriété. La validation se fera ailleurs.
        public int Capacity { get; set; }

        public StorageTemperature storageTemperature { get; set; }

        // La propriété de navigation est toujours là.
        public ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();
    }
}