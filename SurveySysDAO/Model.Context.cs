﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurveySysDAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class surveySysEntities : DbContext
    {
        public surveySysEntities()
            : base("name=surveySysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Alternativa> AlternativaSet { get; set; }
        public DbSet<Cliente> ClienteSet { get; set; }
        public DbSet<Pergunta> PerguntaSet { get; set; }
        public DbSet<Questionario> QuestionarioSet { get; set; }
        public DbSet<Resposta> RespostaSet { get; set; }
        public DbSet<TipoPergunta> TipoPerguntaSet { get; set; }
        public DbSet<TipoUsuario> TipoUsuarioSet { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}