using System.ComponentModel.DataAnnotations;
using DaHo.Library.Wpf;

namespace DaHo.School.M120.Ebanking.Models
{
    public class LoginModel : ModelBase
    {
        [Required(ErrorMessage = "Der Benutzername muss angegeben werden")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Das Passwort muss angegeben werden")]
        public string Password { get; set; }
    }
}
