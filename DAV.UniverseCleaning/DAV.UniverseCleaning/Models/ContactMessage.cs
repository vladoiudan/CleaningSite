using System.ComponentModel.DataAnnotations;

namespace DAV.UniverseCleaning.Models
{
    public class ContactMessage
    {
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message is required!")]
        [UIHint("MultilineText")]
        public string Message { get; set; }
    }
}