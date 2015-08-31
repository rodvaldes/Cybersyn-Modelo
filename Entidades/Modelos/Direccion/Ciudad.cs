using System;
using System.Collections;


namespace Cybersyn.Modelo.ZonaGeografica
{
    public class Ciudad 
    {
        private Int32 id;
        private String nombre;

        public Ciudad()
        {
        }

        public virtual Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
