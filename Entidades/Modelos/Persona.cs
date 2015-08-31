using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersyn.Modelo
{
    public class Persona
    { 
        public int ID { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        DateTime FechaNacimiento{get; set;}
        Int32 Edad{get; set;}
        string Nacionalidad{get; set;}
        string Sexo{get; set;}


        public string ObtenerNombreCompleto()
        {
            return this.PrimerNombre + " " + this.SegundoNombre + " " + this.ApellidoPaterno + " " + this.ApellidoMaterno;
        }
    }
}




