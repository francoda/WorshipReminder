using System;
using Newtonsoft.Json;
using System.Linq;

namespace WR.Models
{
    public class Iglesia
    {
        public int Id { get; set; } = IglesiaModel.Last_IdIglesia;
        public string Nombre { get; set; } = GetLastDefaultNombre();
        public string Direccion { get; set; } = string.Empty;
        public string Localidad { get; set; } = string.Empty;
        public Coleccion<Contacto> Contactos { get; set; } = new Coleccion<Contacto>();
        public Coleccion<Mensaje> Mensajes { get; set; } = new Coleccion<Mensaje>();

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
        private static string GetLastDefaultNombre()
        {
            int contador = 1;
            if (IglesiaModel.ListaIglesias is null)
                return "Nueva Iglesia";
            while (IglesiaModel.ListaIglesias.Any(x => x.Nombre == "Nueva Iglesia " + contador))
            {
                contador++;
            }
            return "Nueva Iglesia " + contador;
        }
    }

    public class Contacto
    {
        public int Id { get; set; } = IglesiaModel.Last_IdContacto;
        public string NombreApellido { get; set; } = GetLastDefaultNombre();
        public string Email { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;

        public override bool Equals(Object that)
        {
            if (!(that is Contacto))
                return false;
            return Id.Equals(((Contacto)that).Id);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        private static string GetLastDefaultNombre()
        {
            int contador = 1;
            if (IglesiaModel.ListaIglesias is null)
                return "Nueva Iglesia";
            while (IglesiaModel.ListaIglesias.Any(x => x.Contactos.Any(y => y.NombreApellido == "Nuevo Contacto " + contador)))
            {
                contador++;
            }
            return "Nuevo Contacto " + contador;
        }
    }

    public static class IglesiaModel
    {
        public static Coleccion<Iglesia> ListaIglesias { get; } = JsonConvert.DeserializeObject<Coleccion<Iglesia>>(LocalFilesModel.Load("Iglesias"));
        public static int Last_IdIglesia => ListaIglesias is null || ListaIglesias.Count == 0 ? 0 : ListaIglesias.Max(x => x.Id) + 1;
        public static int Last_IdContacto => ListaIglesias is null || ListaIglesias.Count == 0 ? 0 : ListaIglesias.Max(x => x.Contactos.Count == 0 ? 0 : x.Contactos.Max(y => y.Id)) + 1;

        public static void Save()
        {
            LocalFilesModel.Save(JsonConvert.SerializeObject(ListaIglesias), "Iglesias");
        }
    }

}
