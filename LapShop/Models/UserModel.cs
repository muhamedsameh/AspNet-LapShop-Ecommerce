using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LapShop.Models
{
    public class UserModel
    {
        // note, remember to put error masseges in resourse file.


        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(20,MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
        [ValidateNever]
        public string? ReturnUrl {  get; set; }
    }
    public class RegisterUserModel : UserModel
    {
        // UserModel + firstName, LastName props.

        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter your last name.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; } = string.Empty;

    }
}
