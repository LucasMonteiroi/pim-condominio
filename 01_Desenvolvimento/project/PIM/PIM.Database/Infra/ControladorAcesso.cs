namespace PIM.Database.Infra
{
    using PIM.Database.Modelo;

    internal class ControladorAcesso
    {
        internal EntidadePIM ObterContexto()
        {
            return new EntidadePIM();
        }
    }
}
