namespace PIM.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class AdvertenciaVM
    {
        public int Identificador { get; set; }

        [Required(ErrorMessage = "O {0}da ocorrência é obrigatório")]
        public decimal Valor { get; set; }

        public string Pago { get; set; }

        [Required(ErrorMessage = "O {0}da ocorrência é obrigatório")]
        [Display(Name = "Ocorrência")]
        public int IdOcorrencia { get; set; }

        public string MotivoOcorrencia { get; set; }
    }
}