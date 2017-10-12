namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;
    using System;
    using System.Linq;

    public static class OcorrenciaService
    {
        private static OcorrenciaCrud _Crud;

        public static void Atualizar(OcorrenciaTO entidadeTO)
        {
            _Crud = CrudService<OcorrenciaCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(OcorrenciaTO entidadeTO)
        {
            _Crud = CrudService<OcorrenciaCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static OcorrenciaTO Obter(int identificador)
        {
            _Crud = CrudService<OcorrenciaCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<OcorrenciaCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaOcorrenciaTO Listar()
        {
            _Crud = CrudService<OcorrenciaCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaOcorrenciaTO ListarPorMorador(int idMorador)
        {
            _Crud = CrudService<OcorrenciaCrud>.ObterInstancia();

            ListaOcorrenciaTO retorno = new ListaOcorrenciaTO();

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
