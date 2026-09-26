using System.ComponentModel.DataAnnotations;

namespace UserRoles.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Se Requiere el Correo Electrónico" )]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Se Requiere la Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Recordarme")]
        public bool RememberMe { get; set; }

    }
}
