using System;
using System.Collections.Generic;
using TesteDotNet.InterfacesEEntidades.Entidades;
using TesteDotNet.InterfacesEEntidades.Interfaces.Repositorio;
using TesteDotNet.InterfacesEEntidades.Interfaces.Servico;

namespace TesteDotNet.Servico
{
    public class CaminhaoServico : ICaminhaoServico
    {
        private ICaminhaoRepositorio _caminhaoRepositorio { get; }
        public CaminhaoServico(ICaminhaoRepositorio caminhaoRepositorio)
        {
            _caminhaoRepositorio = caminhaoRepositorio;
        }
        public Caminhao AlterarCaminhao(Caminhao caminhao) => _caminhaoRepositorio.AlterarCaminhao(caminhao);
        public void ExcluirCaminhao(Caminhao caminhao) => _caminhaoRepositorio.ExcluirCaminhao(caminhao);
        public Caminhao InserirCaminhao(Caminhao caminhao) => _caminhaoRepositorio.InserirCaminhao(caminhao);
        public Caminhao RecuperarCaminhao(Guid id) => _caminhaoRepositorio.RecuperarCaminhao(id);
        public IEnumerable<Caminhao> RecuperarCaminhoes(string descricao = null, string modelo = null, int? anoFabricacao = null, int? anoModelo = null) => _caminhaoRepositorio.RecuperarCaminhoes(descricao, modelo, anoFabricacao, anoModelo);

    }
}
