using System;
using System.Collections.Generic;
using System.Linq;

namespace WR.Models
{
    public class Iglesia
    {
        public string Nombre { get; set; } = "Nueva Iglesia";
        public string Direccion { get; set; } = string.Empty;
        public string Localidad { get; set; } = string.Empty;
        public List<Contacto> Contactos { get; set; } = new List<Contacto>();
        public List<Mensaje> Mensajes { get; set; } = new List<Mensaje>();

        public bool TieneContactos => Contactos.Count > 0;

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
