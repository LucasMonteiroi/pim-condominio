namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.TO;
    using PIM.Service.Infra;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ApartamentoService
    {
        private static ApartamentoCrud _Crud;
        
        public static void Atualizar(ApartamentoTO entidadeTO)
        {
            _Crud = CrudService<ApartamentoCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(ApartamentoTO entidadeTO)
        {
            _Crud = CrudService<ApartamentoCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static ApartamentoTO Obter(int identificador)
        {
            _Crud = CrudService<ApartamentoCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<ApartamentoCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaApartamentoTO Listar()
        {
            _Crud = CrudService<ApartamentoCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaApartamentoTO ListarPorContrato(int idContrato)
        {
            _Crud = CrudService<ApartamentoCrud>.ObterInstancia();
            ListaApartamentoTO retorno = new ListaApartamentoTO();

            try
            {
                retorno = _Crud.Listar();

                if (retorno.Valido)
                {
                    retorno.Lista = retorno.Lista.Where(x => x.IdContrato == idContrato).ToList();
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
