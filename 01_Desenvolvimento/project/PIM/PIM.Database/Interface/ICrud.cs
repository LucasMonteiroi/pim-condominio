namespace PIM.Database.Interface
{
    using PIM.Database.Infra;
    using PIM.Database.Modelo;

    public interface ICrud<T> where T : class
    {
        T Cadastrar(EntidadePIM _Contexto, T _TO);
        T Obter(EntidadePIM _Contexto, int _Identificador);
        T Atualizar(EntidadePIM _Contexto, T _TO);
        RetornoTO Remover(EntidadePIM _Contexto, int _Identificador);
    }
}
