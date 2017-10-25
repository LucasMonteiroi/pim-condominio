namespace PIM.Service.Services
{
    using PIM.Database.Cruds;
    using PIM.Database.Infra;
    using PIM.Database.Interface;
    using PIM.Database.TO;
    using PIM.Service.Infra;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class AdvertenciaService
    {
        private static AdvertenciaCrud _Crud;

        public static void Atualizar(AdvertenciaTO entidadeTO)
        {
            _Crud = CrudService<AdvertenciaCrud>.ObterInstancia();
            _Crud.Atualizar(entidadeTO);
        }

        public static void Criar(AdvertenciaTO entidadeTO)
        {
            _Crud = CrudService<AdvertenciaCrud>.ObterInstancia();
            _Crud.Cadastrar(entidadeTO);
        }

        public static AdvertenciaTO Obter(int identificador)
        {
            _Crud = CrudService<AdvertenciaCrud>.ObterInstancia();
            return _Crud.Obter(identificador);
        }

        public static RetornoTO Remover(int identificador)
        {
            _Crud = CrudService<AdvertenciaCrud>.ObterInstancia();
            return _Crud.Remover(identificador);
        }

        public static ListaAdvertenciaTO Listar()
        {
            _Crud = CrudService<AdvertenciaCrud>.ObterInstancia();
            return _Crud.Listar();
        }
    }
}
