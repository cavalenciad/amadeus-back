

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Amadeus.Models
{
    public class QuestionOptions
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Text { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required string Image { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        [JsonIgnore]
        public required Questions Question { get; set; }
    }
}