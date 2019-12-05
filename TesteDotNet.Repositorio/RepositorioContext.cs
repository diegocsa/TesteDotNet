using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.InterfacesEEntidades.Entidades;

namespace TesteDotNet.Repositorio
{
    public class RepositorioContext : DbContext
    {
        private IConfiguration _configuration { get; }
        public RepositorioContext() { }
        public RepositorioContext(DbContextOptions<RepositorioContext> options) : base(options)
        {
        }

        public virtual DbSet<Caminhao> Caminhao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caminhao>().Property(t => t.Descricao).IsRequired().HasColumnType("nVARCHAR(250)");
            modelBuilder.Entity<Caminhao>().Property(t => t.Modelo).IsRequired().HasColumnType("nCHAR(2)");
            modelBuilder.Entity<Caminhao>().Property(t => t.DataCadastro).IsRequired().HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Caminhao>().Property(t => t.UltimaAtualizacao).IsRequired().HasDefaultValueSql("GetDate()").ValueGeneratedOnUpdate();
        }

    }
}
