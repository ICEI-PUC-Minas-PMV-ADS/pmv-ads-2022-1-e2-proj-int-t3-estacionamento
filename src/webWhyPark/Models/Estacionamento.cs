using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace webWhyPark.Models
{
    public class Estacionamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "Obrigatório informar a razão social!")]
        public string RazaoSocial { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o CNPJ!")]
        public string CNPJ { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o Telefone!")]
        public string Telefone { get; set; } = null!;

        [Required(ErrorMessage = "Obrigatório informar o email!")]

        public string Email { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public string Cargo { get; set; } = "gestor";

    }

}