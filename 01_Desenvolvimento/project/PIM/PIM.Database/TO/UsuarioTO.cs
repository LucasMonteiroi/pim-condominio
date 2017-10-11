namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.Modelo;
    using System.Collections.Generic;

    public class UsuarioTO : RetornoTO
    {
        public int Identificador { get; set; }
        public int IdColaborador { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdGrupo { get; set; }

        internal void PreencherTO(Usuario entidade)
        {
            Identificador = entidade.Identificador;
            IdColaborador = entidade.IdColaborador;
            Login = entidade.Login;
            Senha = entidade.Senha;
            IdGrupo = entidade.IdGrupo;
        }

        internal void PreencherEntidade(Usuario entidade)
        {
            entidade.IdColaborador = IdColaborador;
            entidade.IdGrupo = IdGrupo;
            entidade.Login = Login;
            entidade.Senha = Senha;
        }
    }

    public class ListaUsuarioTO : RetornoTO
    {
        public List<UsuarioTO> Lista { get; set; }

        public ListaUsuarioTO()
        {
            Lista = new List<UsuarioTO>();
        }
    }
}
