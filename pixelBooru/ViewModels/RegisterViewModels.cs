using System.ComponentModel.DataAnnotations;

namespace pixelBooru.ViewModels
{
    public class RegisterViewModels
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "a username is required")]
        public string? Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "a password is required")]
        public string? Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Passwords do not match")]

        public string? ConfirmPassword { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter a valid email address.")]

        public string? Email { get; set; }


    }
}
