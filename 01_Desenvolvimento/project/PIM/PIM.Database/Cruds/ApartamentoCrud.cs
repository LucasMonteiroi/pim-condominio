namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.Interface;
    using PIM.Database.DatabaseModel;
    using PIM.Database.TO;
    using System.Collections.Generic;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;

    public class ApartamentoCrud : ICrud<ApartamentoTO>
    {
        private EntidadePIM _Contexto;
        
        public void Cadastrar(ApartamentoTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Apartamento entidade = new Apartamento();

            to.PreencherEntidade(entidade);

            _Contexto.Apartamento.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Apartamento");

            return;

        }

        public ApartamentoTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ApartamentoTO retorno = new ApartamentoTO();

            Apartamento entidade = _Contexto.Apartamento.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Apartamento", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Apartamento", true);

            return retorno;
        }

        public void Atualizar(ApartamentoTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Apartamento", false);

                return;
            }

            Apartamento entidade = _Contexto.Apartamento.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Apartamento", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Apartamento", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Apartamento entidade = _Contexto.Apartamento.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Apartamento", false);

                return retorno;
            }

            _Contexto.Apartamento.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Apartamento");

            return retorno;
        }

        public ListaApartamentoTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaApartamentoTO retorno = new ListaApartamentoTO();

            List<Apartamento> listaApartamento = _Contexto.Apartamento.ToList();

            if (listaApartamento == null || listaApartamento.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Apartamento", false);

                return retorno;
            }

            ApartamentoTO to;

            foreach (Apartamento entidade in listaApartamento)
            {
                to = new ApartamentoTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Apartamento", true);

            return retorno;
        }
    }

}
