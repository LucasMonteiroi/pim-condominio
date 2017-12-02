namespace PIM.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class UsuarioVM
    {
        public int Identificador { get; set; }

        [Display(Name = "Colaborador")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public int IdColaborador { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Grupo")]
        [Required(ErrorMessage = "O {0} é obrigatório")]
        public int IdGrupo { get; set; }

        public string NomeColaborador { get; set; }
        public string NomeGrupoUsuario { get; set; }
    }
}