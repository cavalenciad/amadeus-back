using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Amadeus.Models
{
    public class UserAnswers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Answers { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        [JsonIgnore]
        public required User User { get; set; }
    }
}