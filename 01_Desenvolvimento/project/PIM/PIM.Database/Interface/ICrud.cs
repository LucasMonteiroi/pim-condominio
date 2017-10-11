namespace PIM.Database.Interface
{
    using PIM.Database.Infra;
    using PIM.Database.Modelo;

    public interface ICrud<T> where T : class
    {
        void Cadastrar(EntidadePIM contexto, T to);
        T Obter(EntidadePIM contexto, int identificador);
        void Atualizar(EntidadePIM contexto, T to);
        RetornoTO Remover(EntidadePIM contexto, int identificador);
    }
}
