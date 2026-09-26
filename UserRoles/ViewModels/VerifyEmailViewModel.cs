using System.ComponentModel.DataAnnotations;

namespace UserRoles.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Se Requiere el Correo Electrónico")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
