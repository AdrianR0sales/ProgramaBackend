using System.ComponentModel.DataAnnotations;

namespace UserRoles.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Se Requiere el Correo Electrónico")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Se Requiere la Contraseña")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "La Contraseña debe tener entre 8 y 40 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Nueva Contraseña")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Las Contraseñas no coinciden")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Se Requiere confirmar la Contraseña")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Nueva Contraseña")]
        public string ConfirmNewPassword { get; set; }
    }
}