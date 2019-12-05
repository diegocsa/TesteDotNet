using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDotNet.InterfacesEEntidades.Entidades;

namespace TesteDotNet.Web.Models
{
    public class CaminhaoItemViewModel
    {
        public CaminhaoItemViewModel()
        {

        }
        public CaminhaoItemViewModel(Caminhao caminhao)
        {
            Id = caminhao.Id;
            Descricao = caminhao.Descricao;
            Modelo = caminhao.Modelo;
            AnoFabricacao = caminhao.AnoFabricacao;
            AnoModelo = caminhao.AnoModelo;
        }
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
    }
}
