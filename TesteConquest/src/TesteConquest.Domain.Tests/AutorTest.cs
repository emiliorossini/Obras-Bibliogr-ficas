using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteConquest.Domain.Entities;

namespace TesteConquest.Domain.Tests
{
    [TestClass]
    public class AutorTest
    {
        [TestMethod]
        public void AutorComNomeExibicaoValido()
        {
            var autor = new Autor(1, "jos� de alencar");
            Assert.IsTrue(autor.NomeExibicao == "ALENCAR, Jos� de");
        }

        [TestMethod]
        public void AutorComNomeExibicaoComNetoValido()
        {
            var autor = new Autor(1, "jos� alencar neto");
            Assert.IsTrue(autor.NomeExibicao == "ALENCAR NETO, Jos�");
        }

        [TestMethod]
        public void AutorComNomeExibicaoComDeValido()
        {
            var autor = new Autor(1, "JO�O Cabral DE MELO NETO");
            Assert.IsTrue(autor.NomeExibicao == "MELO NETO, Jo�o Cabral de");
        }

        [TestMethod]
        public void AutorComNomeExibicaoInvalido()
        {
            var autor = new Autor(1, "Jo�o Guimar�es Rosa");
            Assert.IsFalse(autor.NomeExibicao == "Rosa, Jo�o Guimar�es");
        }
    }
}
