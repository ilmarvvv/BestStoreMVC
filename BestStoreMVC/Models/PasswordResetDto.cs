using System.ComponentModel.DataAnnotations;

namespace BestStoreMVC.Models
{
    public class PasswordResetDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required, MaxLength(100)]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "The Confirm Password field is required")]
        [Compare("Password", ErrorMessage = "Confirm Password field is required")]
        public string ConfirmPassword { get; set; } = "";
    }
}
