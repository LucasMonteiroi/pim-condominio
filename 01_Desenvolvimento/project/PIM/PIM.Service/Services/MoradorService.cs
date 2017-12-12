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

    public static class MoradorService
    {
        private static MoradorCrud _Crud;

        public static void Atualizar(MoradorTO entidadeTO)
        {
            _Crud = CrudService<MoradorCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(MoradorTO entidadeTO)
        {
            _Crud = CrudService<MoradorCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static MoradorTO Obter(int identificador)
        {
            _Crud = CrudService<MoradorCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<MoradorCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaMoradorTO Listar()
        {
            _Crud = CrudService<MoradorCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaMoradorTO PesquisarPorNome(string nomeMorador)
        {
            _Crud = CrudService<MoradorCrud>.ObterInstancia();
            ListaMoradorTO retorno = new ListaMoradorTO();

            try
            {
                retorno = _Crud.Listar();

                if (retorno.Valido)
                {
                    retorno.Lista = retorno.Lista.Where(x => x.Nome.Contains(nomeMorador)).ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Valido = false;
                retorno.Mensagem = string.Format("Erro: {0}", ex.Message);
            }

            return retorno;
        }

        public static MoradorTO LoginMorador(string cpf)
        {
            _Crud = CrudService<MoradorCrud>.ObterInstancia();
            MoradorTO retorno = new MoradorTO();

            try
            {
                ListaMoradorTO listaMoradorTO = new ListaMoradorTO();
                listaMoradorTO = _Crud.Listar();

                retorno = listaMoradorTO.Lista.FirstOrDefault(x => x.CPF == cpf);

                if (retorno == null)
                {
                    retorno = new MoradorTO();
                    retorno.Valido = false;
                    retorno.Mensagem = "Não há moradores cadastrados na base de dados";

                    return retorno;
                }

                retorno.Mensagem = "Morador obtido com sucesso.";
                retorno.Valido = true;
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
