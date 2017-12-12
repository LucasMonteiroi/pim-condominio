namespace PIM.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class AdvertenciaVM
    {
        public int Identificador { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Required(ErrorMessage = "O {0}da ocorrência é obrigatório")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        public string Pago { get; set; }

        [Required(ErrorMessage = "O {0}da ocorrência é obrigatório")]
        [Display(Name = "Ocorrência")]
        public int IdOcorrencia { get; set; }

        public string MotivoOcorrencia { get; set; }

        public bool CheckPag { get; set; }
    }
}