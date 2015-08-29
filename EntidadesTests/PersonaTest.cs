using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace EntidadesTests
{
    [TestClass]
    public class PersonaTest
    {
        [TestMethod]
        public void InicializacionTest()
        {
            Persona federico = new Persona();
            Assert.IsNotNull(federico);
        }

        //[TestMethod]
        //public void 
    }
}
