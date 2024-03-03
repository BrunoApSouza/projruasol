using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ruasolidariav2.Controllers
{
    public class Voluntario
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public int Telefone { get; set; }

        [Display(Name = "Email")]
        [Column("E-mail")]
        public string Email { get; set; }

        [Display(Name = "Beneficiario")]
        [Column("Beneficiario")]
        public string Beneficiario { get; set; }
    }
}
