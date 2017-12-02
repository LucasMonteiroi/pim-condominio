namespace PIM.Web.Mappers
{
    using AutoMapper;
    using PIM.Database.TO;
    using PIM.Web.ViewModels;

    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                //Morador
                x.CreateMap<MoradorTO, MoradorVM>();
                x.CreateMap<MoradorVM, MoradorTO>();

                //Colaborador
                x.CreateMap<ColaboradorTO, ColaboradorVM>();
                x.CreateMap<ColaboradorVM, ColaboradorTO>();

                //Dependente
                x.CreateMap<DependenteTO, DependenteVM>();
                x.CreateMap<DependenteVM, DependenteTO>();

                //Advertencia
                x.CreateMap<AdvertenciaTO, AdvertenciaVM>();
                x.CreateMap<AdvertenciaVM, AdvertenciaTO>();

                //Apartamento
                x.CreateMap<ApartamentoTO, ApartamentoVM>();
                x.CreateMap<ApartamentoVM, ApartamentoTO>();

                //Contrato
                x.CreateMap<ContratoTO, ContratoVM>();
                x.CreateMap<ContratoVM, ContratoTO>();

                //Estacionamento
                x.CreateMap<EstacionamentoTO, EstacionamentoVM>();
                x.CreateMap<EstacionamentoVM, EstacionamentoTO>();

                //GrupoUsuario
                x.CreateMap<GrupoUsuarioTO, GrupoUsuarioVM>();
                x.CreateMap<GrupoUsuarioVM, GrupoUsuarioTO>();

                //Ocorrencia
                x.CreateMap<OcorrenciaTO, OcorrenciaVM>();
                x.CreateMap<OcorrenciaVM, OcorrenciaTO>();

                //Reserva
                x.CreateMap<ReservaTO, ReservaVM>();
                x.CreateMap<ReservaVM, ReservaTO>();

                //TipoReserva
                x.CreateMap<TipoReservaTO, TipoReservaVM>();
                x.CreateMap<TipoReservaVM, TipoReservaTO>();

                //Usuario
                x.CreateMap<UsuarioTO, UsuarioVM>();
                x.CreateMap<UsuarioVM, UsuarioTO>();

                //Visitante
                x.CreateMap<VisitanteTO, VisitanteVM>();
                x.CreateMap<VisitanteVM, VisitanteTO>();
            });
        }
    }
}