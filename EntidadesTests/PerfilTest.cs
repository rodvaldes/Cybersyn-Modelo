using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cybersyn.Modelo;

namespace EntidadesTests
{
    [TestClass]
    public class PerfilTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Perfil perfilTest = new Perfil(1, "Administrador");
            Assert.AreEqual(perfilTest.NombrePerfil, "Administrador");
        }
    }
}
