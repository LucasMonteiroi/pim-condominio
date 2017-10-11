namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.Interface;
    using PIM.Database.Modelo;
    using PIM.Database.TO;
    using System.Collections.Generic;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;

    public class EstacionamentoCrud : ICrud<EstacionamentoTO>
    {
        public void Cadastrar(EntidadePIM contexto, EstacionamentoTO to)
        {
            Estacionamento entidade = new Estacionamento();

            to.PreencherEntidade(entidade);

            contexto.Estacionamento.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Estacionamento");

            return;

        }

        public EstacionamentoTO Obter(EntidadePIM contexto, int identificador)
        {
            EstacionamentoTO retorno = new EstacionamentoTO();

            Estacionamento entidade = contexto.Estacionamento.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Estacionamento", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Estacionamento", true);

            return retorno;
        }

        public void Atualizar(EntidadePIM contexto, EstacionamentoTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Estacionamento", false);

                return;
            }

            Estacionamento entidade = contexto.Estacionamento.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Estacionamento", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Estacionamento", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Estacionamento entidade = contexto.Estacionamento.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Estacionamento", false);

                return retorno;
            }

            contexto.Estacionamento.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Estacionamento");

            return retorno;
        }

        public ListaEstacionamentoTO Listar(EntidadePIM contexto)
        {
            ListaEstacionamentoTO retorno = new ListaEstacionamentoTO();

            List<Estacionamento> listaEstacionamento = contexto.Estacionamento.ToList();

            if (listaEstacionamento == null || listaEstacionamento.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Estacionamento", false);

                return retorno;
            }

            EstacionamentoTO to;

            foreach (Estacionamento entidade in listaEstacionamento)
            {
                to = new EstacionamentoTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Estacionamento", true);

            return retorno;
        }
    }
}
