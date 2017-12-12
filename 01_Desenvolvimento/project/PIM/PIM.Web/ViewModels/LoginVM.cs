namespace PIM.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class LoginVM
    {
        public string Login { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public string CPF { get; set; }
    }
}