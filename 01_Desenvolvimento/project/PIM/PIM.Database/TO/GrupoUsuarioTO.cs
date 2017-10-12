namespace PIM.Database.TO
{
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System.Collections.Generic;

    public class GrupoUsuarioTO : RetornoTO
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }

        internal void PreencherTO(GrupoUsuario entidade)
        {
            Identificador = entidade.Identificador;
            Nome = entidade.Nome;
        }

        internal void PreencherEntidade(GrupoUsuario entidade)
        {
            entidade.Nome = Nome;
        }
    }

    public class ListaGrupoUsuarioTO : RetornoTO
    {
        public List<GrupoUsuarioTO> Lista { get; set; }

        public ListaGrupoUsuarioTO()
        {
            Lista = new List<GrupoUsuarioTO>();
        }
    }
}
