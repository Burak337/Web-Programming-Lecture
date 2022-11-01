using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class student
    {
        [Required(ErrorMessage = "Please write your name!")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please write your email!")]
        [EmailAddress(ErrorMessage = "Please write a correct email!")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please write your phone!")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please select confirm option!")]
        public bool Confirm { get; set; }
    }
}