namespace PIM.Database.Cruds
{
    using PIM.Database.Infra;
    using PIM.Database.Interface;
    using PIM.Database.Modelo;
    using PIM.Database.TO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static PIM.Database.Infra.Utilitario;

    public class ContratoCrud : ICrud<ContratoTO>
    {
        public void Cadastrar(EntidadePIM contexto, ContratoTO to)
        {
            Contrato entidade = new Contrato();

            to.PreencherEntidade(entidade);

            contexto.Contrato.Add(entidade);
            contexto.SaveChanges();

            to.PreencherTO(entidade);

            to.Valido = true;
            to.Mensagem = Utilitario.Mensagem.Cadastro("Contrato");

            return;

        }

        public ContratoTO Obter(EntidadePIM contexto, int identificador)
        {
            ContratoTO retorno = new ContratoTO();

            Contrato entidade = contexto.Contrato.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Contrato", false);

                return retorno;
            }

            retorno.PreencherTO(entidade);

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Obter("Contrato", true);

            return retorno;
        }

        public void Atualizar(EntidadePIM contexto, ContratoTO to)
        {
            if (to.Identificador == 0 || to == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Atualizacao("Contrato", false);

                return;
            }

            Contrato entidade = contexto.Contrato.FirstOrDefault(x => x.Identificador == to.Identificador);

            if (entidade == null)
            {
                to.Valido = false;
                to.Mensagem = Mensagem.Obter("Contrato", false);

                return;
            }

            to.PreencherEntidade(entidade);

            contexto.SaveChanges();

            to.PreencherTO(entidade);
            to.Valido = true;
            to.Mensagem = Mensagem.Atualizacao("Contrato", true);

            return;
        }

        public RetornoTO Remover(EntidadePIM contexto, int identificador)
        {
            RetornoTO retorno = new RetornoTO();

            Contrato entidade = contexto.Contrato.FirstOrDefault(x => x.Identificador == identificador);

            if (entidade == null)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Obter("Contrato", false);

                return retorno;
            }

            contexto.Contrato.Remove(entidade);
            contexto.SaveChanges();

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Exclusao("Contrato");

            return retorno;
        }

        public ListaContratoTO Listar(EntidadePIM contexto)
        {
            ListaContratoTO retorno = new ListaContratoTO();

            List<Contrato> listaContrato = contexto.Contrato.ToList();

            if (listaContrato == null || listaContrato.Count == 0)
            {
                retorno.Valido = false;
                retorno.Mensagem = Mensagem.Lista("Contrato", false);

                return retorno;
            }

            ContratoTO to;

            foreach (Contrato entidade in listaContrato)
            {
                to = new ContratoTO();
                to.PreencherTO(entidade);

                retorno.Lista.Add(to);
            }

            retorno.Valido = true;
            retorno.Mensagem = Mensagem.Lista("Contrato", true);

            return retorno;
        }
    }
}
