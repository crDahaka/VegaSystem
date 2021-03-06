namespace VegaSystem.Entities
{
    using System.ComponentModel.DataAnnotations;
    
    public class Feature
    {
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}