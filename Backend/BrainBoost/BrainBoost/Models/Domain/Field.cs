using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace BrainBoost.Models.Domain
{
    [Table("Field")]
    public class Field
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
