using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoteriaProjectWebApi.Models
{
    public class Authentication
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int AuthenticationId { get; set; }  
        public string Email { get; set; }
        public string Password { get; set; }    
        public bool Enabled { get; set; }
    }
}
