namespace PIM.Database.TO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GrupoUsuarioTO
    {
        public int Identificador { get; set; }
        public string Nome { get; set; }
    }

    public class ListaGrupoUsuarioTO
    {
        public List<GrupoUsuarioTO> Lista { get; set; }

        public ListaGrupoUsuarioTO()
        {
            Lista = new List<GrupoUsuarioTO>();
        }
    }
}
