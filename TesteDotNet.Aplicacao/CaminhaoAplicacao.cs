using System;
using System.Linq;
using System.Collections.Generic;
using TesteDotNet.InterfacesEEntidades.Entidades;
using TesteDotNet.InterfacesEEntidades.Interfaces.Servico;
using TesteDotNet.InterfacesEEntidades.Interfaces.Aplicacao;

namespace TesteDotNet.Aplicacao
{
    public class CaminhaoAplicacao : ICaminhaoAplicacao
    {
        private readonly string[] ModelosValidos = new string[] { "FH", "FM" };

        private ICaminhaoServico _caminhaoServico { get; }

        public CaminhaoAplicacao(ICaminhaoServico caminhaoServico)
        {
            _caminhaoServico = caminhaoServico;
        }

        public Caminhao AlterarCaminhao(Caminhao caminhao)
        {
            if (caminhao == null ||
             (caminhao.Descricao == null && caminhao.AnoFabricacao == 0
             && caminhao.AnoModelo == 0 && caminhao.Modelo == null
             && caminhao.Id == new Guid()))
                throw new ArgumentNullException("Objeto inválido");

            if (!ModeloValido(caminhao.Modelo))
                throw new ArgumentOutOfRangeException("Os modelos permitidos são: ", string.Join(", ", ModelosValidos));

            if (string.IsNullOrEmpty(caminhao.Descricao))
                throw new ArgumentNullException("A descrição é obrigatoria");

            if (caminhao.Descricao.Length > 250)
                throw new ArgumentOutOfRangeException("A descrição deve ter no máximo 250 caracteres");

            var dadoAtual = RecuperarCaminhao(caminhao.Id);

            if (caminhao.AnoFabricacao != dadoAtual.AnoFabricacao && !AnoFabricacaoValido(caminhao.AnoFabricacao))
                throw new ArgumentOutOfRangeException("O ano de fabricação deve ser igual ao atual");

            if (caminhao.AnoModelo != dadoAtual.AnoModelo && !AnoModeloValido(caminhao.AnoModelo))
                throw new ArgumentOutOfRangeException("O ano do modelo deve ser igual ao atual ou o subsequente");

            caminhao.DataCadastro = dadoAtual.DataCadastro;
            caminhao.UltimaAtualizacao = DateTime.Now;

            _caminhaoServico.AlterarCaminhao(caminhao);
            return caminhao;
        }

        private bool AnoFabricacaoValido(int anoModelo)
        {
            return (anoModelo == DateTime.Now.Year);
        }

        private bool AnoModeloValido(int anoModelo)
        {
            return (anoModelo == DateTime.Now.Year || anoModelo == (DateTime.Now.Year + 1));
        }

        public void ExcluirCaminhao(Guid id)
        {
            if (id == new Guid())
                throw new ArgumentException("Id Inválido");

            var caminhao = RecuperarCaminhao(id);

            if (caminhao == null)
                throw new ArgumentException("Nenhum caminhão cadastrado com o Id informado");

            _caminhaoServico.ExcluirCaminhao(caminhao);
        }

        public Caminhao InserirCaminhao(Caminhao caminhao)
        {
            if (caminhao == null ||
                (caminhao.Descricao == null && caminhao.AnoFabricacao == 0
                && caminhao.AnoModelo == 0 && caminhao.Modelo == null
                && caminhao.Id == new Guid()))
                throw new ArgumentNullException("Objeto inválido");

            if (!AnoFabricacaoValido(caminhao.AnoFabricacao))
                throw new ArgumentOutOfRangeException("O ano de fabricação deve ser igual ao atual");

            if (!AnoModeloValido(caminhao.AnoModelo))
                throw new ArgumentOutOfRangeException("O ano do modelo deve ser igual ao atual ou o subsequente");

            if (!ModeloValido(caminhao.Modelo))
                throw new ArgumentOutOfRangeException("Os modelos permitidos são: ", string.Join(", ", ModelosValidos));

            if (string.IsNullOrEmpty(caminhao.Descricao))
                throw new ArgumentNullException("A descrição é obrigatoria");

            if (caminhao.Descricao.Length > 250)
                throw new ArgumentOutOfRangeException("A descrição deve ter no máximo 250 caracteres");

            caminhao.Id = Guid.NewGuid();
            caminhao.DataCadastro = DateTime.Now;
            caminhao.UltimaAtualizacao = DateTime.Now;
            _caminhaoServico.InserirCaminhao(caminhao);
            return caminhao;
        }

        private bool ModeloValido(string modelo)
        {
            return ModelosValidos.Contains(modelo);
        }

        public Caminhao RecuperarCaminhao(Guid id)
        {
            if (id == new Guid())
                throw new ArgumentException("Id Inválido");

            return _caminhaoServico.RecuperarCaminhao(id);
        }

        public IEnumerable<Caminhao> RecuperarCaminhoes(string descricao = null, string modelo = null, int? anoFabricacao = null, int? anoModelo = null) => _caminhaoServico.RecuperarCaminhoes(descricao, modelo, anoFabricacao, anoModelo);


    }
}
