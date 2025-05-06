using System.ComponentModel.DataAnnotations;

namespace Amadeus.Models
{
    public class Destinations
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Combination { get; set; }

        [Required]
        public required string FirstCityId { get; set; }

        [Required]
        public required string SecondCityId { get; set; }
    }
}