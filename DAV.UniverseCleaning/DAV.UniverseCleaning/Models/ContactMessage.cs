using System.ComponentModel.DataAnnotations;

namespace DAV.UniverseCleaning.Models
{
    public class ContactMessage
    {
        [Required(ErrorMessage = "First Name is required!")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message is required!")]
        [UIHint("MultilineText")]
        public string Message { get; set; }
    }
}