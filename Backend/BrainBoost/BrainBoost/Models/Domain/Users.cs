using System.ComponentModel.DataAnnotations.Schema;

namespace BrainBoost.Models.Domain
{
    [Table("Users")]
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly BirthDate { get; set; }
        public int TotalScore { get; set; }
        
        
    }
}
