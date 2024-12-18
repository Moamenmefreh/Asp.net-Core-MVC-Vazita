using System.ComponentModel.DataAnnotations;

namespace Hayaat_Karima.Models
{
    public class Pateint
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [EmailAddress]

        public string Email { get; set; }
    }
}
