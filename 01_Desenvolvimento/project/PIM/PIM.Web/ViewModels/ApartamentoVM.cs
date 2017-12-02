namespace PIM.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class ApartamentoVM
    {
        public int Identificador { get; set; }

        [Required(ErrorMessage = "O {0} do apartamento é obrigatório")]
        public int Bloco { get; set; }

        [Required(ErrorMessage = "O {0} do apartamento é obrigatório")]
        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O {0} do apartamento é obrigatório")]
        [Display(Name = "Contrato")]
        public int IdContrato { get; set; }

        public string DescricaoContrato { get; set; }
    }
}