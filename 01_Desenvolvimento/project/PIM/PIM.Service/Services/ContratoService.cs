namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;
    using System;
    using System.Linq;

    public static class ContratoService
    {
        private static ContratoCrud _Crud;
        
        public static void Atualizar(ContratoTO entidadeTO)
        {
            _Crud = CrudService<ContratoCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(ContratoTO entidadeTO)
        {
            _Crud = CrudService<ContratoCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static ContratoTO Obter(int identificador)
        {
            _Crud = CrudService<ContratoCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<ContratoCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaContratoTO Lista()
        {
            _Crud = CrudService<ContratoCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaContratoTO ListarPorMorador(int idMorador)
        {
            _Crud = CrudService<ContratoCrud>.ObterInstancia();
            ListaContratoTO retorno = new ListaContratoTO();

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
