using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class LoginVM
    {
        [Required]
        public string EmailOrUsername { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsPresistant { get; set; }
    }
}
