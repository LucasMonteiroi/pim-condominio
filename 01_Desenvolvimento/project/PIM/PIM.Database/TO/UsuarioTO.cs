namespace PIM.Database.TO
{
    using System.Collections.Generic;

    public class UsuarioTO
    {
        public int Identificador { get; set; }
        public int IdColaborador { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int IdPermissao { get; set; }
    }

    public class ListaUsuarioTO
    {
        public List<UsuarioTO> Lista { get; set; }

        public ListaUsuarioTO()
        {
            Lista = new List<UsuarioTO>();
        }
    }
}
