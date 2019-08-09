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
            var autor = new Autor(1, "josé de alencar");
            Assert.IsTrue(autor.NomeExibicao == "ALENCAR, José de");
        }

        [TestMethod]
        public void AutorComNomeExibicaoComNetoValido()
        {
            var autor = new Autor(1, "josé alencar neto");
            Assert.IsTrue(autor.NomeExibicao == "ALENCAR NETO, José");
        }

        [TestMethod]
        public void AutorComNomeExibicaoComDeValido()
        {
            var autor = new Autor(1, "JOÃO Cabral DE MELO NETO");
            Assert.IsTrue(autor.NomeExibicao == "MELO NETO, João Cabral de");
        }

        [TestMethod]
        public void AutorComNomeExibicaoInvalido()
        {
            var autor = new Autor(1, "João Guimarães Rosa");
            Assert.IsFalse(autor.NomeExibicao == "Rosa, João Guimarães");
        }
    }
}
