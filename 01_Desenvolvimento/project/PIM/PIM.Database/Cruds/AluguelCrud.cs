namespace PIM.Database.Cruds
{
    using PIM.Database.Interface;
    using PIM.Database.TO;
    using PIM.Database.Infra;
    using PIM.Database.DatabaseModel;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;
    using System.Collections.Generic;

    public class AluguelCrud : ICrud<AluguelTO>
    {
        private EntidadePIM _Contexto;

        public void Cadastrar(AluguelTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            Aluguel entidade = new Aluguel();

            to.PreencherEntidade(entidade);

            _Contexto.Aluguel.Add(entidade);
            _Contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Aluguel");

            return;

        }

        public AluguelTO Obter(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            AluguelTO retorno = new AluguelTO();

            Aluguel entidade = _Contexto.Aluguel.FirstOrDefault(x => x.Identificador == identificador);

            if(entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Aluguel", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Aluguel", true);

            return retorno;
        }

        public void Atualizar(AluguelTO to)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Aluguel", false);

                return;
            }

            Aluguel entidade = _Contexto.Aluguel.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Aluguel", false);

                return;
            }

            to.PreencherEntidade(entidade);

            _Contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Aluguel", true);

            return;
        }

        public RetornoTO Remover(int identificador)
        {
            _Contexto = ControladorAcesso.ObterContexto();

            RetornoTO retorno = new RetornoTO();

            Aluguel entidade = _Contexto.Aluguel.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Aluguel", false);

                return retorno;
            }

            _Contexto.Aluguel.Remove(entidade);
            _Contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Aluguel");

            return retorno;
        }

        public ListaAluguelTO Listar()
        {
            _Contexto = ControladorAcesso.ObterContexto();

            ListaAluguelTO retorno = new ListaAluguelTO();

            List<Aluguel> listaAluguel = _Contexto.Aluguel.ToList();

            if(listaAluguel == null || listaAluguel.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Aluguel", false);

                return retorno;
            }

            AluguelTO to;

            foreach(Aluguel entidade in listaAluguel)
            {
                to = new AluguelTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Aluguel", true);

            return retorno;
        }
    }
}
