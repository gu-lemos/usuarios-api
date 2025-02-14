using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos
{
    public class CadastrarUsuarioDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; } = string.Empty;

        [Required]
        public DateTime DataNascimento { get; set; }
    }
}
