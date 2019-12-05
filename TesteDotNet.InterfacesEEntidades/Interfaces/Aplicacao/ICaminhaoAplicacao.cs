using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.InterfacesEEntidades.Entidades;

namespace TesteDotNet.InterfacesEEntidades.Interfaces.Aplicacao
{
    public interface ICaminhaoAplicacao
    {
        IEnumerable<Caminhao> RecuperarCaminhoes(string descricao = null, string modelo = null, int? anoFabricacao = null, int? anoModelo=null);
        Caminhao RecuperarCaminhao(Guid id);
        void ExcluirCaminhao(Guid id);
        Caminhao InserirCaminhao(Caminhao caminhao);
        Caminhao AlterarCaminhao(Caminhao caminhao);
    }
}
