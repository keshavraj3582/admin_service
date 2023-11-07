using System.ComponentModel.DataAnnotations;

namespace Admin_service.Models
{
    public class Admin
    {
        [Required]
        public string Email { get; set; }
        public string Role { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
