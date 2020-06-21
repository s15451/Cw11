using System.ComponentModel.DataAnnotations.Schema;

namespace Cw11.Models
{
    public class PrescriptionMedicament
    {
        [ForeignKey("Medicament")]
        public int IdMedicament { get; set; }

        public Medicament Medicament { get; set; }

        [ForeignKey("Prescription")]
        public int IdPrescription { get; set; }

        public Prescription Prescription { get; set; }

        public int? Dose { get; set; }

        public string Details { get; set; }
    }
}
