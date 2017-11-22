namespace PIM.Web.ViewModels
{
    using System;
    using System.Linq;
    using System.Web;

    public class MoradorVM
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Email { get; set; }
    }
}