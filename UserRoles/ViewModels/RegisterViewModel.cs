using System.ComponentModel.DataAnnotations;

namespace UserRoles.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Se Requiere el Nombre")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Se Requiere el Correo Electrónico")]
        [EmailAddress(ErrorMessage = "El formato del correo no es válido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Se Requiere la Contraseña")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "La Contraseña debe tener entre 8 y 40 caracteres")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Las Contraseñas no coinciden")] // <-- Cambiado a "ConfirmPassword"
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Se Requiere confirmar la Contraseña")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty; // <-- Estandarizado y limpia la propiedad extra
    }
}
