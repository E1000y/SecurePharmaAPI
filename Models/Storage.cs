namespace SecurePharmaAPI.Models
{
    public class Storage
    {
        public int Id {get; set;}
        public string nom { get; set; } = string.Empty;
        public string location { get; set; } = string.Empty;
        public StorageTemperature storageTemperature { get; set; }
        private int capacity;
        public ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();
        public int Capacity
        {
            get => capacity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Capacity cannot be negative.");
                }
                capacity = value;
            }
        }
        public int CurrentStock => Medicines.Count;
       

    }
}
