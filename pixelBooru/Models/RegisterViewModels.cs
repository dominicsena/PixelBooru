using System.ComponentModel.DataAnnotations;

namespace pixelBooru.Models
{
    public class RegisterViewModels
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "a username is required")]
        public string? Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "a password is required")]
        public string? Password { get; set; }

        
    }
}
