namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;
    using System;
    using System.Linq;

    public static class DependenteService
    {
        private static DependenteCrud _Crud;

        public static void Atualizar(DependenteTO entidadeTO)
        {
            _Crud = CrudService<DependenteCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(DependenteTO entidadeTO)
        {
            _Crud = CrudService<DependenteCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static DependenteTO Obter(int identificador)
        {
            _Crud = CrudService<DependenteCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<DependenteCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaDependenteTO Lista()
        {
            _Crud = CrudService<DependenteCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaDependenteTO ListarPorMorador(int idMorador)
        {
            _Crud = CrudService<DependenteCrud>.ObterInstancia();
            ListaDependenteTO retorno = new ListaDependenteTO();

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

        public static ListaDependenteTO PesquisarPorNome(string nomeDependente)
        {
            _Crud = CrudService<DependenteCrud>.ObterInstancia();
            ListaDependenteTO retorno = new ListaDependenteTO();

            try
            {
                retorno = _Crud.Listar();

                if (retorno.Valido)
                {
                    retorno.Lista = retorno.Lista.Where(x => x.Nome.Contains(nomeDependente)).ToList();
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
