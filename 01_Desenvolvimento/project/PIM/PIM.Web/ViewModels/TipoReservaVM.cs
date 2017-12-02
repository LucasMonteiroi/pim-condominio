namespace PIM.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class TipoReservaVM
    {
        public int Identificador { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatória")]
        public string Tipo { get; set; }
    }
}