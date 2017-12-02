namespace PIM.Web.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class MoradorVM
    {
        public int Identificador { get; set; }

        [Required(ErrorMessage ="O {0} é obrigatório")]
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }

        public string RG { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string Telefone { get; set; }

        public string Celular { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        public string Email { get; set; }
    }
}