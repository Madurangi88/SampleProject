using System.ComponentModel.DataAnnotations;

namespace Test.Business.Models
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public string ContactNo { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
