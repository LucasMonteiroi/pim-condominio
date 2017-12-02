namespace PIM.Web.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ColaboradorVM
    {
        public int Identificador { get; set; }

        [Required(ErrorMessage = "O {0} do colaborador é obrigatório")]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }

        public string RG { get; set; }

        [Required(ErrorMessage = "O {0} do colaborador é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "A {0} do colaborador é obrigatória")]
        [Display(Name = "Função")]
        public string Funcao { get; set; }

        [Display(Name = "Data de Contratação")]
        public DateTime? DataContrato { get; set; }

        [Display(Name = "Salário")]
        public decimal? Salario { get; set; }

    }
}