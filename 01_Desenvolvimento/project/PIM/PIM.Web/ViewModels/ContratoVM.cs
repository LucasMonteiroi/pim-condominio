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
        [DataType(DataType.Date)]
        public DateTime DataContrato { get; set; }

        [Display(Name = "Morador")]
        [Required(ErrorMessage = "O {0} do contrato é obrigatório")]
        public int IdMorador { get; set; }

        [Required(ErrorMessage = "O {0} do contrato é obrigatório")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "A {0} do contrato é obrigatória")]
        [Range(0, 1000)]
        public int Parcelas { get; set; }

        [Display(Name = "Tipo de Contrato")]
        public string TipoContrato { get; set; }
        public string NomeMorador { get; set; }
    }
}