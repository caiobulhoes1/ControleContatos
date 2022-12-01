using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Contato")]

        public string Nome { get;set; }

        [Required(ErrorMessage ="Digite o Email do Contato")]
        [EmailAddress(ErrorMessage ="O Email informado não é valido")]

        public string Email { get; set; }

        [Required(ErrorMessage ="Digite o Celular do Contat")]
        [Phone(ErrorMessage ="O Celular informado não é valido")]
        public string Celular { get; set; }

    }
}
