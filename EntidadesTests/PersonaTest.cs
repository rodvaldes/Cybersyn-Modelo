using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cybersyn.Modelo;

namespace Cybersyn.ModeloTests
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
        [TestMethod]
       public void NombreCompletoTest()
        {
            Persona rodrigo = new Persona();
            rodrigo.PrimerNombre = "Rodrigo";
            rodrigo.SegundoNombre = "Eduardo";
            rodrigo.ApellidoPaterno = "Valdés";
            rodrigo.ApellidoMaterno = "Beltrán";
            String nombreCompleto = rodrigo.ObtenerNombreCompleto();
            Assert.AreEqual("Rodrigo Eduardo Valdés Beltrán", nombreCompleto);
        }
    }
}
