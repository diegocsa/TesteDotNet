using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TesteDotNet.Aplicacao;
using TesteDotNet.InterfacesEEntidades.Interfaces.Aplicacao;
using TesteDotNet.InterfacesEEntidades.Interfaces.Servico;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        CaminhaoAplicacao _systemUnderTest;
        ICaminhaoServico _myInterface;

        public Tests()
        {
            _myInterface = new Mock<ICaminhaoServico>().Object;
            _systemUnderTest = new CaminhaoAplicacao(_myInterface);
        }

        [TestMethod]
        public void MyTestMethod()
        {

            _systemUnderTest.AnoModeloValido(2000);
        }
    }
}