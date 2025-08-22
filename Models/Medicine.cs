using Microsoft.EntityFrameworkCore;

namespace SecurePharmaAPI.Models
{
    public class Medicine
    {
        public int Id { get; set; } // Identifiant unique (clé primaire)
        public string Name { get; set; } = string.Empty; // Nom du médicament
        public string? Description { get; set; }  // Détails ou composition
        public string? Manufacturer { get; set; } // Laboratoire fabricant
        public DateTime? ExpiryDate { get; set; } // Date de péremption
        [Precision(18, 2)] // Précision pour les valeurs monétaires
        public decimal? Price { get; set; } // Prix unitaire
        public int StockQuantity { get; set; } = string.Empty; // Quantité disponible en stock

        // Température de stockage (enum que tu as déjà défini)
        public StorageTemperature StorageTemperature { get; set; }

        // Navigation vers les prescriptions où ce médicament est utilisé
        public ICollection<PrescriptionMedicine> PrescriptionMedicines { get; set; } = new List<PrescriptionMedicine>();


        public Storage Storage { get; set; } = null!; // Stockage associé à ce médicament
        public int StorageId { get; set; } // Clé étrangère vers Storage
    }

}
