namespace PIM.Database.Cruds
{
    using PIM.Database.Interface;
    using PIM.Database.TO;
    using System;
    using PIM.Database.Infra;
    using PIM.Database.Modelo;
    using System.Linq;
    using static PIM.Database.Infra.Utilitario;
    using System.Collections.Generic;

    public class AluguelCrud : ICrud<AluguelTO>
    {
        public void Cadastrar(EntidadePIM contexto, AluguelTO to)
        {
            Aluguel entidade = new Aluguel();

            to.PreencherEntidade(entidade);

            contexto.Aluguel.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Mensagem.Cadastro("Aluguel");

            return;

        }

        public AluguelTO Obter(EntidadePIM contexto, int identificador)
        {
            AluguelTO retorno = new AluguelTO();

            Aluguel entidade = contexto.Aluguel.FirstOrDefault(x => x.Identificador == identificador);

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

        public void Atualizar(EntidadePIM contexto, AluguelTO to)
        {
            if(to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Aluguel", false);

                return;
            }

            Aluguel entidade = contexto.Aluguel.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Aluguel", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Aluguel", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Aluguel entidade = contexto.Aluguel.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Aluguel", false);

                return retorno;
            }

            contexto.Aluguel.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Aluguel");

            return retorno;
        }

        public ListaAluguelTO Listar(EntidadePIM contexto)
        {
            ListaAluguelTO retorno = new ListaAluguelTO();

            List<Aluguel> listaAluguel = contexto.Aluguel.ToList();

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
