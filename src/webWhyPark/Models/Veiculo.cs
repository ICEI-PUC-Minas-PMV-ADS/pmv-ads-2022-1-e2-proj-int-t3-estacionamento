using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace webWhyPark.Models
{
    [Table("Veiculos")]
    public class Veiculo

    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Placa")]
        [Required(ErrorMessage = "Obrigatório informar a placa!")]
        public string Placa { get; set; } = null!;

        [Display(Name = "Cor")]
        [Required(ErrorMessage = "Obrigatório informar uma cor!")]
        public string Cor { get; set; } = null!;

        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "Obrigatório informar um modelo!")]
        public string Modelo { get; set; } = null!;

        [ForeignKey("Cliente")]
        public int ClienteFk { get; set; }
    }
}