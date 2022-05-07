using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace webWhyPark.Models
{
    public class LoginCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email { get; set; } = null!;

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Obrigatório informar uma senha!")]
        public string Senha { get; set; } = null!;

        [ForeignKey("CadastroCliente")]
        public int CadastroClienteFk { get; set; }

    }

}