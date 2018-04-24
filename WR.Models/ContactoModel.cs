using System;
using System.Linq;

namespace WR.Models
{
    public class Contacto
    {
        public string NombreApellido { get; set; } = "Nuevo Contacto";
        public string Email { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;

        public override bool Equals(Object that)
        {
            if (!(that is Contacto))
                return false;
            return NombreApellido.Equals(((Contacto)that).NombreApellido);
        }
        public override int GetHashCode()
        {
            return NombreApellido.GetHashCode();
        }
    }
}
