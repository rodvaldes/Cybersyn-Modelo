using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cybersyn.Modelo;

namespace EntidadesTests
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void UsuarioNoNulo()
        {
            Usuario usuario = new Usuario();
            Assert.IsNotNull(usuario);
        }
       // [TestMethod]
    //    public void 
    }
}
