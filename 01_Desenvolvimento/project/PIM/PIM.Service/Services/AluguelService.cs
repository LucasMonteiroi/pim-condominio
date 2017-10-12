namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;

    public static class AluguelService
    {
        private static AluguelCrud _Crud;

        public static void Atualizar(AluguelTO entidadeTO)
        {
            _Crud = CrudService<AluguelCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(AluguelTO entidadeTO)
        {
            _Crud = CrudService<AluguelCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static AluguelTO Obter(int identificador)
        {
            _Crud = CrudService<AluguelCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<AluguelCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaAluguelTO Listar()
        {
            _Crud = CrudService<AluguelCrud>.ObterInstancia();
            return _Crud.Listar();
        }
    }
}
