namespace PIM.Database.TO
{
    using System;
    using System.Collections.Generic;

    public class PermissaoAcessoTO
    {
        public int Identificador { get; set; }
        public int IdGrupo { get; set; }
        public string Nome { get; set; }
    }

    public class ListaPermissaoAcessoTO
    {
        public List<PermissaoAcessoTO> Lista { get; set; }

        public ListaPermissaoAcessoTO()
        {
            Lista = new List<PermissaoAcessoTO>();
        }
    }
}
