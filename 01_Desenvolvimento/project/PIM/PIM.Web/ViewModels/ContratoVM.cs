namespace PIM.Web.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ContratoVM
    {
        public int Identificador { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A {0} do contrato é obrigatória")]
        public string Descricao { get; set; }

        [Display(Name = "Data do Contrato")]
        [Required(ErrorMessage = "A {0} é obrigatória")]
        public DateTime DataContrato { get; set; }

        [Display(Name = "Morador")]
        [Required(ErrorMessage = "O {0} do contrato é obrigatório")]
        public int IdMorador { get; set; }

        [Required(ErrorMessage = "O {0} do contrato é obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "A {0} do contrato é obrigatória")]
        public int Parcelas { get; set; }

        [Display(Name = "Tipo de Contrato")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string TipoContrato { get; set; }
        public string NomeMorador { get; set; }
    }
}