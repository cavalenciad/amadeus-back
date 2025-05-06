using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Amadeus.Models
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }
        public required string Category { get; set; }
        public required string Text { get; set; }

        [JsonIgnore]
        public required List<QuestionOptions> Options { get; set; }
    }
}