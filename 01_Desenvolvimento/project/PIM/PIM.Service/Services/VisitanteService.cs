namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;
    using System;
    using System.Linq;

    public static class VisitanteService
    {
        private static VisitanteCrud _Crud;

        public static void Atualizar(VisitanteTO entidadeTO)
        {
            _Crud = CrudService<VisitanteCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(VisitanteTO entidadeTO)
        {
            _Crud = CrudService<VisitanteCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static VisitanteTO Obter(int identificador)
        {
            _Crud = CrudService<VisitanteCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<VisitanteCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaVisitanteTO Listar()
        {
            _Crud = CrudService<VisitanteCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaVisitanteTO ListarPorMorador(int idMorador)
        {
            _Crud = CrudService<VisitanteCrud>.ObterInstancia();
            ListaVisitanteTO retorno = new ListaVisitanteTO();

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
    }
}
