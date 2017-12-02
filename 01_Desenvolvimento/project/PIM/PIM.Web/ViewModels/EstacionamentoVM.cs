namespace PIM.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class EstacionamentoVM
    {
        public int Identificador { get; set; }

        [Display(Name = "Apartamento")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public int IdApartamento { get; set; }

        [Display(Name = "Vagas Disponíveis")]
        [Required(ErrorMessage = "As {0} são obrigatórias")]
        public int VagasDisponiveis { get; set; }

        public string Apartamento { get; set; }
    }
}