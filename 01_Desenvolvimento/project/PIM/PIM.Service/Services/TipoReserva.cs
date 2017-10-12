namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;

    public static class TipoTipoReserva
    {
        private static TipoReservaCrud _Crud;

        public static void Atualizar(TipoReservaTO entidadeTO)
        {
            _Crud = CrudService<TipoReservaCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(TipoReservaTO entidadeTO)
        {
            _Crud = CrudService<TipoReservaCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static TipoReservaTO Obter(int identificador)
        {
            _Crud = CrudService<TipoReservaCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<TipoReservaCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaTipoReservaTO Listar()
        {
            _Crud = CrudService<TipoReservaCrud>.ObterInstancia();
            return _Crud.Listar();
        }
    }
}
