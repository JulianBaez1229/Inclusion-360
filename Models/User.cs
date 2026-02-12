using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class User
    {
        [Key]
        [Display (Name ="User ID")]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string Name { get; set; }

        
        public string Email { get; set; }

    }
}
