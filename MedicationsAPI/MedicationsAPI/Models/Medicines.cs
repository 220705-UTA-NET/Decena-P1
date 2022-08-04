using System.ComponentModel.DataAnnotations;

namespace MedicationsAPI.Models
{
    public class Medicines
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public int Tablets { get; set; }
        public string Price { get; set; }

    }


}
