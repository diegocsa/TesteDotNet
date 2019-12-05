using System;
using System.Linq;
using Moq;
using NUnit.Framework;
using TesteDotNet.Aplicacao;
using TesteDotNet.InterfacesEEntidades.Entidades;
using TesteDotNet.InterfacesEEntidades.Interfaces.Servico;

namespace Tests
{
    public class CaminhaoAplicacaoTeste
    {
        CaminhaoAplicacao _caminhaoAplicacao;
        Mock<ICaminhaoServico> _interfaceServico;

        [SetUp]
        public void Setup()
        {
            _interfaceServico = new Mock<ICaminhaoServico>();
            _interfaceServico.Setup(x => x.InserirCaminhao(It.IsAny<Caminhao>())).Returns(new Caminhao());
            _interfaceServico.Setup(x => x.AlterarCaminhao(It.IsAny<Caminhao>())).Returns(new Caminhao());
            _interfaceServico.Setup(x => x.RecuperarCaminhao(It.IsAny<Guid>())).Returns(new Caminhao() { Id = new Guid("b40273d7-846a-4274-a04f-4f28dfe0388a"), AnoFabricacao = 2000, AnoModelo = 2000, DataCadastro = DateTime.Now, Descricao = "Teste", Modelo = "FH", UltimaAtualizacao = DateTime.Now });
            _caminhaoAplicacao = new CaminhaoAplicacao(_interfaceServico.Object);
        }
        /*
             if (!AnoFabricacaoValido(caminhao.AnoFabricacao))
                throw new ArgumentOutOfRangeException("O ano de fabricação deve ser igual ao atual");

           if(!AnoModeloValido(caminhao.AnoModelo))
                throw new ArgumentOutOfRangeException("O ano do modelo deve ser igual ao atual ou o subsequente");

            if (!ModeloValido(caminhao.Modelo))
                throw new ArgumentOutOfRangeException("Os modelos permitidos são:
             */



        [Test]
        public void InserirCaminhao_ObjetoValido_ChamaInserirCaminhaServico()
        {
            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year, Modelo = "FM", Descricao = "Teste" };
            _caminhaoAplicacao.InserirCaminhao(caminhao);

            Assert.AreEqual(_interfaceServico.Invocations.Count, 1);
            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).First(), "InserirCaminhao");
        }

        [Test]
        public void InserirCaminhao_AnoFabricacaoDiferenteAtual_ExecaoComMensagemApropriadaNaoChamaInserirCaminhaoServico()
        {
            var caminhao = new Caminhao() { AnoFabricacao = 1999 };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.InserirCaminhao(caminhao));
            Assert.That(ex.ParamName, Is.EqualTo("O ano de fabricação deve ser igual ao atual"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void InserirCaminhao_ObjetoNulo_ExecaoComMensagemApropriadaNaoChamaInserirCaminhaoServico()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => _caminhaoAplicacao.InserirCaminhao(null));
            Assert.That(ex.ParamName, Is.EqualTo("Objeto inválido"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void InserirCaminhao_ObjetoVazio_ExecaoComMensagemApropriadaNaoChamaInserirCaminhaoServico()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => _caminhaoAplicacao.InserirCaminhao(new Caminhao()));
            Assert.That(ex.ParamName, Is.EqualTo("Objeto inválido"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void InserirCaminhao_AnoModeloMenorAtual_ExecaoComMensagemApropriadaNaoChamaInserirCaminhaoServico()
        {
            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year - 1 };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.InserirCaminhao(caminhao));
            Assert.That(ex.ParamName, Is.EqualTo("O ano do modelo deve ser igual ao atual ou o subsequente"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void InserirCaminhao_AnoModeloDoisAnosAposAtual_ExecaoComMensagemApropriadaNaoChamaInserirCaminhaoServico()
        {
            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year + 2 };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.InserirCaminhao(caminhao));
            Assert.That(ex.ParamName, Is.EqualTo("O ano do modelo deve ser igual ao atual ou o subsequente"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void InserirCaminhao_ModeloVazioOuNulo_ExecaoComMensagemApropriadaNaoChamaInserirCaminhaoServico()
        {
            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.InserirCaminhao(caminhao));
            Assert.That(ex.ParamName.StartsWith("Os modelos permitidos são:"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void InserirCaminhao_DescricaoVazioOuNulo_ExecaoComMensagemApropriadaNaoChamaInserirCaminhaoServico()
        {
            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year, Modelo = "FH" };
            var ex = Assert.Throws<ArgumentNullException>(() => _caminhaoAplicacao.InserirCaminhao(caminhao));
            Assert.That(ex.ParamName, Is.EqualTo("A descrição é obrigatoria"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void InserirCaminhao_DescricaoMaiorQueMaxima_ExecaoComMensagemApropriadaNaoChamaInserirCaminhaoServico()
        {
            var descricao = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 300)
                    .Select(s => s[new Random().Next(s.Length)]).ToArray());

            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year, Modelo = "FH", Descricao = descricao };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.InserirCaminhao(caminhao));
            Assert.That(ex.ParamName, Is.EqualTo("A descrição deve ter no máximo 250 caracteres"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void InserirCaminhao_ModeloDiferenteDosValidos_ExecaoComMensagemApropriadaNaoChamaInserirCaminhaoServico()
        {
            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year, Modelo = "XX" };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.InserirCaminhao(caminhao));
            Assert.That(ex.ParamName.StartsWith("Os modelos permitidos são:"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }


        [Test]
        public void AlterarCaminhao_ObjetoValido_ChamaAlterarCaminhaoServico()
        {
            var caminhao = new Caminhao() { Id = Guid.NewGuid(), AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year, Modelo = "FM", Descricao = "Teste" };
            _caminhaoAplicacao.AlterarCaminhao(caminhao);
            Assert.AreEqual(_interfaceServico.Invocations.Count, 2);

            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).ToArray()[1], "AlterarCaminhao");
            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).ToArray()[0], "RecuperarCaminhao");
        }

        [Test]
        public void AlterarCaminhao_AnoFabricacaoDiferenteAtualNaoAlteradoOriginal_ChamaAlterarCaminhaoServico() {
            var alterado = new Caminhao()
            {
                Id = new Guid("b40273d7-846a-4274-a04f-4f28dfe0388a"),
                AnoFabricacao = 2000,
                AnoModelo = 2000,
                DataCadastro = DateTime.Now,
                Descricao = "Teste",
                Modelo = "FH",
                UltimaAtualizacao = DateTime.Now
            };

            _caminhaoAplicacao.AlterarCaminhao(alterado);
            Assert.AreEqual(_interfaceServico.Invocations.Count, 2);
            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).ToArray()[0], "RecuperarCaminhao");
            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).ToArray()[1], "AlterarCaminhao");
        }

        [Test]
        public void AlterarCaminhao_AnoModeloMenorAtualNaoAlteradoOriginal_ChamaAlterarCaminhaoServico() {
            var alterado = new Caminhao()
            {
                Id = new Guid("b40273d7-846a-4274-a04f-4f28dfe0388a"),
                AnoFabricacao = 2000,
                AnoModelo = 2000,
                DataCadastro = DateTime.Now,
                Descricao = "Teste",
                Modelo = "FH",
                UltimaAtualizacao = DateTime.Now
            };

            _caminhaoAplicacao.AlterarCaminhao(alterado);
            Assert.AreEqual(_interfaceServico.Invocations.Count, 2);
            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).ToArray()[0], "RecuperarCaminhao");
            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).ToArray()[1], "AlterarCaminhao");
        }

        [Test]
        public void AlterarCaminhao_ObjetoNulo_ExecaoComMensagemApropriadaNaoChamaAlterarCaminhaoServico() {
            var ex = Assert.Throws<ArgumentNullException>(() => _caminhaoAplicacao.AlterarCaminhao(null));
            Assert.That(ex.ParamName, Is.EqualTo("Objeto inválido"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void AlterarCaminhao_ObjetoVazio_ExecaoComMensagemApropriadaNaoChamaAlterarCaminhaoServico()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => _caminhaoAplicacao.AlterarCaminhao(new Caminhao()));
            Assert.That(ex.ParamName, Is.EqualTo("Objeto inválido"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }


        [Test]
        public void AlterarCaminhao_AnoFabricacaoDiferenteAtualAlteradoOriginal_ExecaoComMensagemApropriadaNaoChamaAlterarCaminhaoServico()
        {
            var alterado = new Caminhao()
            {
                Id = new Guid("b40273d7-846a-4274-a04f-4f28dfe0388a"),
                AnoFabricacao = 2002,
                AnoModelo = 2000,
                DataCadastro = DateTime.Now,
                Descricao = "Teste",
                Modelo = "FH",
                UltimaAtualizacao = DateTime.Now
            };

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.AlterarCaminhao(alterado));
            Assert.That(ex.ParamName, Is.EqualTo("O ano de fabricação deve ser igual ao atual"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 1);
            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).ToArray()[0], "RecuperarCaminhao");

        }
                
        [Test]
        public void AlterarCaminhao_AnoModeloMenorAtualAlteradoOriginal_ExecaoComMensagemApropriadaNaoChamaAlterarCaminhaoServico() {
            var alterado = new Caminhao()
            {
                Id = new Guid("b40273d7-846a-4274-a04f-4f28dfe0388a"),
                AnoFabricacao = 2000,
                AnoModelo = 2001,
                DataCadastro = DateTime.Now,
                Descricao = "Teste",
                Modelo = "FH",
                UltimaAtualizacao = DateTime.Now
            };

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.AlterarCaminhao(alterado));
            Assert.That(ex.ParamName, Is.EqualTo("O ano do modelo deve ser igual ao atual ou o subsequente"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 1);
            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).ToArray()[0], "RecuperarCaminhao");
        }

        [Test]
        public void AlterarCaminhao_AnoModeloDoisAnosAposAtual_ExecaoComMensagemApropriadaNaoChamaAlterarCaminhaoServico() {
            var alterado = new Caminhao()
            {
                Id = new Guid("b40273d7-846a-4274-a04f-4f28dfe0388a"),
                AnoFabricacao = 2000,
                AnoModelo = DateTime.Now.Year +2,
                DataCadastro = DateTime.Now,
                Descricao = "Teste",
                Modelo = "FH",
                UltimaAtualizacao = DateTime.Now
            };

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.AlterarCaminhao(alterado));
            Assert.That(ex.ParamName, Is.EqualTo("O ano do modelo deve ser igual ao atual ou o subsequente"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 1);
            Assert.AreEqual(_interfaceServico.Invocations.Select(x => x.Method.Name).ToArray()[0], "RecuperarCaminhao");
        }

        [Test]
        public void AlterarCaminhao_ModeloVazioOuNulo_ExecaoComMensagemApropriadaNaoChamaAlterarCaminhaoServico() {
            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.AlterarCaminhao(caminhao));
            Assert.That(ex.ParamName.StartsWith("Os modelos permitidos são:"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void AlterarCaminhao_DescricaoVazioOuNulo_ExecaoComMensagemApropriadaNaoChamaAlterarCaminhaoServico() {
            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year, Modelo = "FH" };
            var ex = Assert.Throws<ArgumentNullException>(() => _caminhaoAplicacao.AlterarCaminhao(caminhao));
            Assert.That(ex.ParamName, Is.EqualTo("A descrição é obrigatoria"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void AlterarCaminhao_DescricaoMaiorQueMaxima_ExecaoComMensagemApropriadaNaoChamaAlterarCaminhaoServico()
        {
            var descricao = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 300)
                    .Select(s => s[new Random().Next(s.Length)]).ToArray());

            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year, Modelo = "FH", Descricao = descricao };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.AlterarCaminhao(caminhao));
            Assert.That(ex.ParamName, Is.EqualTo("A descrição deve ter no máximo 250 caracteres"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

        [Test]
        public void AlterarCaminhao_ModeloDiferenteDosValidos_ExecaoComMensagemApropriadaNaoChamaAlterarCaminhaoServico() {
            var caminhao = new Caminhao() { AnoFabricacao = DateTime.Now.Year, AnoModelo = DateTime.Now.Year, Modelo = "XX" };
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _caminhaoAplicacao.AlterarCaminhao(caminhao));
            Assert.That(ex.ParamName.StartsWith("Os modelos permitidos são:"));
            Assert.AreEqual(_interfaceServico.Invocations.Count, 0);
        }

    }
}