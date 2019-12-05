using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TesteDotNet.InterfacesEEntidades.Entidades;
using TesteDotNet.InterfacesEEntidades.Interfaces.Repositorio;

namespace TesteDotNetRepositorio
{
    public class RepositorioContext : DbContext//, IRepositorioContext
    {
        private IConfiguration Configuration { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = 
    ConfigurationExtensions
   .GetConnectionString(this.Configuration, "Principal");
            optionsBuilder.UseSqlServer(connString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caminhao>().Property(t => t.Descricao).IsRequired().HasColumnType("VARCHAR").HasMaxLength(250);
            modelBuilder.Entity<Caminhao>().Property(t => t.Modelo).IsRequired().HasColumnType("CHAR").HasMaxLength(2);
            modelBuilder.Entity<Caminhao>().Property(t => t.DataCadastro).IsRequired().HasDefaultValueSql("GetDate()");
            modelBuilder.Entity<Caminhao>().Property(t => t.UltimaAtualizacao).IsRequired().HasDefaultValueSql("GetDate()").ValueGeneratedOnUpdate();
        }
    }
}
