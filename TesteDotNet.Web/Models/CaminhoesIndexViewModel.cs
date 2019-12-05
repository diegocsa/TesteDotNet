using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDotNet.InterfacesEEntidades.Entidades;

namespace TesteDotNet.Web.Models
{
    public class CaminhoesIndexViewModel
    {
        public IEnumerable<Caminhao> CaminhoesCadastrados { get; set; }
    }
}
