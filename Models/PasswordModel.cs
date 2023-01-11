using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Password_Keep.Models
{
    public class PasswordModel
    {
        [Key]
        public int PasswordId { get; set; }
        
        [Column(TypeName ="nvarchar(15)")]
        [DisplayName("Platform")]
        [Required(ErrorMessage ="This field is required")]
        [MaxLength(15,ErrorMessage ="This field accepts only 15 letters long platform")]
        public string PlatformName { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [DisplayName("Password")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(15, ErrorMessage = "This field accepts only 15 letters long passwords")]
        public string StoredPassword { get; set; }
    }
}
