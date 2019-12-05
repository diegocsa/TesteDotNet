using System;
using System.Linq;
using System.Collections.Generic;
using TesteDotNet.InterfacesEEntidades.Entidades;
using TesteDotNet.InterfacesEEntidades.Interfaces.Repositorio;

namespace TesteDotNet.Repositorio
{
    public class CaminhaoRepositorio : ICaminhaoRepositorio
    {
        private readonly RepositorioContext _context;

        public CaminhaoRepositorio(RepositorioContext context)
        {
            _context = context;

        }

        public Caminhao AlterarCaminhao(Caminhao caminhao)
        {
            var item = _context.Caminhao.First(x => x.Id == caminhao.Id);
            item.AnoFabricacao = caminhao.AnoFabricacao;
            item.AnoModelo = caminhao.AnoModelo;
            item.Modelo = caminhao.Modelo;
            item.Descricao = caminhao.Descricao;
            item.UltimaAtualizacao = caminhao.UltimaAtualizacao;
            _context.SaveChanges();
            return caminhao;

        }

        public void ExcluirCaminhao(Caminhao caminhao)
        {
            _context.Remove(caminhao);
            _context.SaveChanges();
        }

        public Caminhao InserirCaminhao(Caminhao caminhao)
        {
            var entity = _context.Add(caminhao).Entity;
            _context.SaveChanges();
            return entity;
        }

        public Caminhao RecuperarCaminhao(Guid id)
        {
            return _context.Find<Caminhao>(id);
        }

        public IEnumerable<Caminhao> RecuperarCaminhoes(string descricao = null, string modelo = null, int? anoFabricacao = null, int? anoModelo = null)
        {
            return _context.Caminhao.Where(x =>
               ((string.IsNullOrEmpty(descricao) || x.Descricao == descricao)
               && (string.IsNullOrEmpty(modelo) || x.Modelo == modelo)
               && (anoFabricacao == null || x.AnoFabricacao == anoFabricacao.Value)
               && (anoModelo == null || x.AnoModelo == anoModelo.Value)
               )
            );
        }
    }
}
