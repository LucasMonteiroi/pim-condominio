﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIM.Database.DatabaseModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntidadePIM : DbContext
    {
        public EntidadePIM()
            : base("name=EntidadePIM")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aluguel> Aluguel { get; set; }
        public virtual DbSet<Apartamento> Apartamento { get; set; }
        public virtual DbSet<Contrato> Contrato { get; set; }
        public virtual DbSet<Dependente> Dependente { get; set; }
        public virtual DbSet<Estacionamento> Estacionamento { get; set; }
        public virtual DbSet<Morador> Morador { get; set; }
        public virtual DbSet<Ocorrencia> Ocorrencia { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<TipoReserva> TipoReserva { get; set; }
        public virtual DbSet<Colaborador> Colaborador { get; set; }
        public virtual DbSet<GrupoUsuario> GrupoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}