using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoteriaProjectWebApi.Models
{
    public class ProfileType
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileTypeId { get; set; }
        [ForeignKey("")]
    }
}
