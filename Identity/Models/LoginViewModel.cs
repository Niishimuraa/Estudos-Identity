using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha obrigatória")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Lembrar-me")]
        public bool RememberMe { get; set; }
    }
}
