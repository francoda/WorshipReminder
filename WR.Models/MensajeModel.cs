using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace WR.Models
{
    public class Mensaje
    {
        public String Titulo { get; set; } = "Nuevo Mensaje";
        public string Descripcion { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new List<string>();
        public SortedSet<BibliaModel.Versiculo> Pasajes { get; set; } = new SortedSet<BibliaModel.Versiculo>();
        public Lista<Archivo> Archivos { get; set; } = new Lista<Archivo>();
        
        public int CantidadArchivos => Archivos.Count;
        public int CantidadContenido => Descripcion.Length;

        public override bool Equals(Object that)
        {
            if (!(that is Mensaje))
                return false;
            return Titulo.Equals(((Mensaje)that).Titulo);
        }
        public override int GetHashCode()
        {
            return Titulo.GetHashCode();
        }
    }
}
