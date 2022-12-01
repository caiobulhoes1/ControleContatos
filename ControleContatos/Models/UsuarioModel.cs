using ControleContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do Usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o Login do Usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o Email do Usuario")]
        [EmailAddress(ErrorMessage = "O Email informado não é valido")]
        public string Email { get; set; }
        [EmailAddress(ErrorMessage = "Digite o Perfil do Usuário")]
        public PerfilEnum Perfil { get; set; }
        [Required(ErrorMessage = "Digite a Senha do Usuário")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }

    }
}
