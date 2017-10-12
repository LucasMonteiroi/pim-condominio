namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;
    using System;
    using System.Linq;

    public static class EstacionamentoService
    {
        private static EstacionamentoCrud _Crud;

        public static void Atualizar(EstacionamentoTO entidadeTO)
        {
            _Crud = CrudService<EstacionamentoCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(EstacionamentoTO entidadeTO)
        {
            _Crud = CrudService<EstacionamentoCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static EstacionamentoTO Obter(int identificador)
        {
            _Crud = CrudService<EstacionamentoCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<EstacionamentoCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaEstacionamentoTO Listar()
        {
            _Crud = CrudService<EstacionamentoCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaEstacionamentoTO ListarPorApartamento(int idApartamento)
        {
            _Crud = CrudService<EstacionamentoCrud>.ObterInstancia();
            ListaEstacionamentoTO retorno = new ListaEstacionamentoTO();

            try
            {
                retorno = _Crud.Listar();

                if (retorno.Valido)
                {
                    retorno.Lista = retorno.Lista.Where(x => x.IdApartamento == idApartamento).ToList();
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
