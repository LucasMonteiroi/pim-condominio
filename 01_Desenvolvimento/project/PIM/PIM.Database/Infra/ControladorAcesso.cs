namespace PIM.Database.Infra
{
    using PIM.Database.DatabaseModel;

    internal static class ControladorAcesso
    {
        internal static EntidadePIM ObterContexto()
        {
            return new EntidadePIM();
        }
    }
}
