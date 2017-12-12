namespace PIM.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class DependenteVM
    {
        public int Identificador { get; set; }

        [Required(ErrorMessage = "O {0} do dependente é obrigatório")]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        [Required(ErrorMessage = "O {0} do dependente é obrigatório")]
        [Display(Name = "Morador Responsável")]
        public int IdMorador { get; set; }

        [Display(Name = "Grau de Parentesco")]
        [Required(ErrorMessage = "O {0} do dependente é obrigatório")]
        [StringLength(1)]
        public string GrauParentesco { get; set; }

        public string NomeMorador { get; set; }
    }
}