using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    { 
        public int ID { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
       // NullableDateTime FechaNacimiento{get; set;}
        Int32 Edad{get; set;}
        string Nacionalidad{get; set;}
        string Sexo{get; set;}     
       

    }
}




