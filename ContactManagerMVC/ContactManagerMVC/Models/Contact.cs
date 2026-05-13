using System.ComponentModel.DataAnnotations;

namespace ContactManagerMVC.Models
{
    public class Contact
    {
        /*escribir "prop" y espacio para que sea mas facil escribir*/
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "The name can't exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "e-mail is required")]
        [EmailAddress(ErrorMessage = "The email format is invalid")]
        [StringLength(150)]
        public string Email { get; set; }

        [Phone(ErrorMessage = "The email format is invalid")]
        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string Address { get; set; }
    }
}
