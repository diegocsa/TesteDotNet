using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.InterfacesEEntidades.Entidades;

namespace TesteDotNet.InterfacesEEntidades.Interfaces.Repositorio
{
    public interface ICaminhaoRepositorio
    {
        IEnumerable<Caminhao> RecuperarCaminhoes(string descricao = null, string modelo = null, int? anoFabricacao = null, int? anoModelo = null);
        Caminhao RecuperarCaminhao(Guid id);
        void ExcluirCaminhao(Caminhao caminhao);
        Caminhao InserirCaminhao(Caminhao caminhao);
        Caminhao AlterarCaminhao(Caminhao caminhao);
    }
}
