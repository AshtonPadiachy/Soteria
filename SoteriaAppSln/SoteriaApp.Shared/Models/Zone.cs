using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoteriaProjectWebApi.Models
{
    public class Zone
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ZoneId { get; set; }

        public string Description { get; set; }
    }
}
