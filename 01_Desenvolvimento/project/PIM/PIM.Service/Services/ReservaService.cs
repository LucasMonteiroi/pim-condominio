namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;
    using System;
    using System.Linq;

    public static class ReservaService
    {
        private static ReservaCrud _Crud;

        public static void Atualizar(ReservaTO entidadeTO)
        {
            _Crud = CrudService<ReservaCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(ReservaTO entidadeTO)
        {
            _Crud = CrudService<ReservaCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static ReservaTO Obter(int identificador)
        {
            _Crud = CrudService<ReservaCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<ReservaCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaReservaTO Listar()
        {
            _Crud = CrudService<ReservaCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaReservaTO ListarPorMorador(int idMorador)
        {
            _Crud = CrudService<ReservaCrud>.ObterInstancia();
            ListaReservaTO retorno = new ListaReservaTO();

            try
            {
                retorno = _Crud.Listar();

                if (retorno.Valido)
                {
                    retorno.Lista = retorno.Lista.Where(x => x.IdMorador == idMorador).ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Valido = false;
                retorno.Mensagem = string.Format("Erro: {0}", ex.Message);
            }

            return retorno;
        }

        public static ListaReservaTO ListarPorTipoReserva(int idTipoReserva)
        {
            _Crud = CrudService<ReservaCrud>.ObterInstancia();

            ListaReservaTO retorno = new ListaReservaTO();

            try
            {
                retorno = _Crud.Listar();

                if (retorno.Valido)
                {
                    retorno.Lista = retorno.Lista.Where(x => x.IdTipoReserva == idTipoReserva).ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Valido = false;
                retorno.Mensagem = string.Format("Erro: {0}", ex.Message);
            }

            return retorno;
        }
    }
}
