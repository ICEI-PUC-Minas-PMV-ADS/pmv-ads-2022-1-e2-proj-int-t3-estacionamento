using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace webWhyPark.Models

{
    [Table("RedesSociais")]
    public class RedeSocial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Link { get; set; } = null!;

        [ForeignKey("Estacionamento")]
        public int EstacionamentoRedesSociaisFk { get; set; }

    }
}