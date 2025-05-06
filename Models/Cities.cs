using System.ComponentModel.DataAnnotations;

namespace Amadeus.Models
{
    public class City
    {
        [Key]
        public required int Id { get; set; }
        [Required]
        public required string Image { get; set; }
        [Required]
        public required string Country { get; set; }
        [Required]
        public required string Language { get; set; }
        [Required]
        public required string UnmissablePlace { get; set; }
        [Required]
        public required string Continent { get; set; }
        [Required]
        public required string CityHash { get; set; }
    }
}