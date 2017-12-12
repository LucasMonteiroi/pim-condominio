namespace PIM.Web.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ReservaVM
    {
        public int Identificador { get; set; }

        [Display(Name = "Tipo de Reserva")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public int IdTipoReserva { get; set; }

        [Display(Name = "Morador")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public int IdMorador { get; set; }

        [Display(Name = "Data da Reserva")]
        [Required(ErrorMessage = "A {0} é obrigatória")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataReserva { get; set; }

        [Display(Name = "Confirmação de Reserva")]
        public string ConfirmacaoReserva { get; set; }

        public string NomeMorador { get; set; }

        public string TipoReserva { get; set; }
        public bool Confirmacao { get; set; }
    }
}