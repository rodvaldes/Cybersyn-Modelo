using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cybersyn.Modelo
{
       [Serializable]
       public class Usuario
        {
            public int UsuarioId { get; set; }
            public bool esPrimerIngreso { get; set; }
            public string password { get; set; }
            public bool esCambioClave { get; set; }
            public bool estaActivo { get; set; }
            public List<Perfil> PerfilesAcceso;
            public Perfil PerfilPredeterminado;

     }
}

  