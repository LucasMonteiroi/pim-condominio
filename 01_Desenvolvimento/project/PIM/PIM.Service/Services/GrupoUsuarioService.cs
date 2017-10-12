namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;

    public static class GrupoUsuarioService
    {
        private static GrupoUsuarioCrud _Crud;

        public static void Atualizar(GrupoUsuarioTO entidadeTO)
        {
            _Crud = CrudService<GrupoUsuarioCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(GrupoUsuarioTO entidadeTO)
        {
            _Crud = CrudService<GrupoUsuarioCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static GrupoUsuarioTO Obter(int identificador)
        {
            _Crud = CrudService<GrupoUsuarioCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<GrupoUsuarioCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaGrupoUsuarioTO Listar()
        {
            _Crud = CrudService<GrupoUsuarioCrud>.ObterInstancia();
            return _Crud.Listar();
        }
    }
}
