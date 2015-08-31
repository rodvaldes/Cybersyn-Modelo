using Cybersyn.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos.Automatización
{
    public class Stack
    {
        public int StackId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Entorno Entorno { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Usuario Creador { get; set; }

    }
}
