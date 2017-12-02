namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;
    using System;
    using System.Linq;

    public static class ColaboradorService
    {
        private static ColaboradorCrud _Crud;

        public static void Atualizar(ColaboradorTO entidadeTO)
        {
            _Crud = CrudService<ColaboradorCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(ColaboradorTO entidadeTO)
        {
            _Crud = CrudService<ColaboradorCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static ColaboradorTO Obter(int identificador)
        {
            _Crud = CrudService<ColaboradorCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<ColaboradorCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaColaboradorTO Listar()
        {
            _Crud = CrudService<ColaboradorCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaColaboradorTO PesquisarPorNome(string nomeColaborador)
        {
            _Crud = CrudService<ColaboradorCrud>.ObterInstancia();
            ListaColaboradorTO retorno = new ListaColaboradorTO();

            try
            {
                retorno = _Crud.Listar();

                if (retorno.Valido)
                {
                    retorno.Lista = retorno.Lista.Where(x => x.Nome.Contains(nomeColaborador)).ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Valido = false;
                retorno.Mensagem = string.Format("Erro: {0}", ex.Message);
            }

            return retorno;
        }

        public static ListaColaboradorTO PesquisarPorFuncao(string funcao)
        {
            _Crud = CrudService<ColaboradorCrud>.ObterInstancia();
            ListaColaboradorTO retorno = new ListaColaboradorTO();

            try
            {
                retorno = _Crud.Listar();

                if (retorno.Valido)
                {
                    retorno.Lista = retorno.Lista.Where(x => x.Funcao.Contains(funcao)).ToList();
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
