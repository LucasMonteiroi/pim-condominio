namespace PIM.Web.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class OcorrenciaVM
    {
        public int Identificador { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Morador")]
        public int IdMorador { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória")]
        [Display(Name = "Data da Ocorrência")]
        [DataType(DataType.Date)]
        public DateTime DataOcorrencia { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string Motivo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O {0} do contrato é obrigatório")]
        public string Descricao { get; set; }

        public string NomeMorador { get; set; }
    }
}