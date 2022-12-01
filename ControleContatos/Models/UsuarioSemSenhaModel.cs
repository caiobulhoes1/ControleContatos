using ControleContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do Usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o Login do Usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o Email do Usuario")]
        [EmailAddress(ErrorMessage = "O Email informado não é valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o Perfil do Usuario")]
        public PerfilEnum? Perfil { get; set; }

    }
}
