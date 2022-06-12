using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace webWhyPark.Models
{
    public class Cliente

    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; } = null!;

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string Email { get; set; } = null!;

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Obrigatório informar uma senha!")]
        public string Senha { get; set; } = null!;

        public string Cargo { get; set; } = "cliente";

    }
}