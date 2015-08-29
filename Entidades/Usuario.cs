using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cybersyn.Modelo
{
    public class Usuario
    {
       {
    [Serializable]
    public class UsuarioApp
    {
        public int UsuarioId { get; set; }
        public bool esPrimerIngreso { get; set; }
        public bool esCambioClave { get; set; }
        public bool estaActivo { get; set; }
        public List<Perfil> PerfilesAcceso;
        public EnumPerfil PerfilPredeterminado;

    }
}

    }
}
