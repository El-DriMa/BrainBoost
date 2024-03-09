using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost.Models.Domain
{
    [Table("Answer")]
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Question Question { get; set; }
    }
}
