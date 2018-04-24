using System;
using System.Linq;

namespace WR.Models
{
    public class Iglesia
    {
        public string Nombre { get; set; } = "Nueva Iglesia";
        public string Direccion { get; set; } = string.Empty;
        public string Localidad { get; set; } = string.Empty;
        public Lista<Contacto> Contactos { get; set; } = new Lista<Contacto>();
        public Lista<Mensaje> Mensajes { get; set; } = new Lista<Mensaje>();

        public override bool Equals(Object that)
        {
            if (!(that is Iglesia))
                return false;
            return Nombre.Equals(((Iglesia)that).Nombre);
        }
        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
    }

}
