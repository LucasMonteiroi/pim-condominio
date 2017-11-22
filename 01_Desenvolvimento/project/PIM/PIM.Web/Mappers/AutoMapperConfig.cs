namespace PIM.Web.Mappers
{
    using AutoMapper;
    using PIM.Database.DatabaseModel;
    using PIM.Database.TO;
    using PIM.Web.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Morador, MoradorVM>();
                x.CreateMap<MoradorVM, Morador>();
                x.CreateMap<MoradorTO, Morador>();
            });
        }
    }
}