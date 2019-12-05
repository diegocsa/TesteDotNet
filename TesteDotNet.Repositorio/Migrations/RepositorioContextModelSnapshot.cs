﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteDotNet.Repositorio;

namespace TesteDotNet.Repositorio.Migrations
{
    [DbContext(typeof(RepositorioContext))]
    partial class RepositorioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TesteDotNet.InterfacesEEntidades.Entidades.Caminhao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnoFabricacao");

                    b.Property<int>("AnoModelo");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nVARCHAR(250)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nCHAR(2)");

                    b.Property<DateTime>("UltimaAtualizacao")
                        .ValueGeneratedOnUpdate()
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Id");

                    b.ToTable("Caminhao");
                });
#pragma warning restore 612, 618
        }
    }
}
