using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost.Models.Domain
{
    [Table("Question")]
    public class Question
    {
        public int Id { get; set; }
        public int Text { get; set; }
        public Field Field { get; set; }
    }
}
