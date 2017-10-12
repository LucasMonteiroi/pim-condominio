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

    public static class UsuarioService
    {
        private static UsuarioCrud _Crud;

        public static void Atualizar(UsuarioTO entidadeTO)
        {
            _Crud = CrudService<UsuarioCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(UsuarioTO entidadeTO)
        {
            _Crud = CrudService<UsuarioCrud>.ObterInstancia();
            entidadeTO.Senha = UtilitarioService.GerarHashMD5(entidadeTO.Senha);
            _Crud.Cadastrar(entidadeTO);
        }

        public static UsuarioTO Obter(int identificador)
        {
            _Crud = CrudService<UsuarioCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<UsuarioCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaUsuarioTO Listar()
        {
            _Crud = CrudService<UsuarioCrud>.ObterInstancia();
            return _Crud.Listar();
        }

        public static ListaUsuarioTO ListarPorGrupo(int idGrupo)
        {
            _Crud = CrudService<UsuarioCrud>.ObterInstancia();
            ListaUsuarioTO retorno = new ListaUsuarioTO();

            try
            {
                retorno = _Crud.Listar();

                if (retorno.Valido)
                {
                    retorno.Lista = retorno.Lista.Where(x => x.IdGrupo == idGrupo).ToList();
                }
            }
            catch (Exception ex)
            {
                retorno.Valido = false;
                retorno.Mensagem = string.Format("Erro: {0}", ex.Message);
            }

            return retorno;
        }

        public static UsuarioTO RealizarLogin(string login, string senha)
        {
            _Crud = CrudService<UsuarioCrud>.ObterInstancia();
            UsuarioTO retorno = new UsuarioTO();

            try
            {
                senha = UtilitarioService.GerarHashMD5(senha);
                ListaUsuarioTO listaUsuarioTO = new ListaUsuarioTO();
                listaUsuarioTO = _Crud.Listar();

                retorno = listaUsuarioTO.Lista.FirstOrDefault(x => x.Login == login && x.Senha == senha);

                if(retorno == null)
                {
                    retorno.Valido = false;
                    retorno.Mensagem = "Login e/ou senha inválidos.";

                    return retorno;
                }

                retorno.Valido = true;
                retorno.Mensagem = "Usuário autorizado!";
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
