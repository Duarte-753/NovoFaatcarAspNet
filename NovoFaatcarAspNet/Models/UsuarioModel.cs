using System.ComponentModel.DataAnnotations;

namespace NovoFaatcarAspNet.Models
{
    public class UsuarioModel
    {

        public int Id { get; set; }      

        [Required(ErrorMessage = "Digite o Nome do funcionario")]
        [MaxLength(40)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o nome de Usuário")]
        [MaxLength(20)]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Digite a senha desse Usuário")]
        [MaxLength(20)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Digite um email para recuperação de senha.")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        [MaxLength(40)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o celular para contato.")]
        [Phone(ErrorMessage = "O celular informado não é valido.")]
        [MaxLength(11)]
        public string Celular { get; set; }

    }
}
