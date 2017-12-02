namespace PIM.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class VisitanteVM
    {
        public int Identificador { get; set; }

        [Required(ErrorMessage = "O {0} do visitante é obrigatório")]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O {0} do visitante é obrigatório")]
        [Display(Name = "Morador Responsável")]
        public int IdMorador { get; set; }

        public string NomeMorador { get; set; }
    }
}