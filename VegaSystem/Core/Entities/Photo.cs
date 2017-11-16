namespace VegaSystem.Core.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Photo
    {
        public int Id { get; set; }

        public int VehicleId { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }
    }
}