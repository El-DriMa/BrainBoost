using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost.Models.Domain
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly BirthDate { get; set; }
        
        
    }
}
