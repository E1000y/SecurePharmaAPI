namespace SecurePharmaAPI.Models
{
    public class Medicine
    {
        public int Id { get; set; } // Identifiant unique (clé primaire)
        public string Name { get; set; } = string.Empty; // Nom du médicament
        public string Description { get; set; } = string.Empty; // Détails ou composition
        public string Manufacturer { get; set; } = string.Empty; // Laboratoire fabricant
        public DateTime ExpiryDate { get; set; } // Date de péremption
        public decimal Price { get; set; } // Prix unitaire
        public int StockQuantity { get; set; } // Quantité disponible en stock

        // Température de stockage (enum que tu as déjà défini)
        public StorageTemperature StorageTemperature { get; set; }

        // Navigation vers les prescriptions où ce médicament est utilisé
        public ICollection<PrescriptionMedicine> PrescriptionMedicines { get; set; } = new List<PrescriptionMedicine>();
    }

}
