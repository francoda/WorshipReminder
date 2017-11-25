using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WR.Models
{
    public class Mensaje
    {
        public int Id { get; set; } = MensajeModel.Last_Id;
        public String Titulo { get; set; } = GetLastDefaultNombre();
        public string Contenido { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;
        public SortedSet<BibliaModel.Versiculo> Pasajes { get; set; } = new SortedSet<BibliaModel.Versiculo>();
        public Coleccion<Archivo> ListaArchivos { get; set; } = new Coleccion<Archivo>();

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
        private static string GetLastDefaultNombre()
        {
            int contador = 1;
            if (MensajeModel.ListaMensajes is null)
                return "Nuevo Mensaje";
            while (MensajeModel.ListaMensajes.Any(x => x.Titulo == "Nuevo Mensaje " + contador))
            {
                contador++;
            }
            return "Nuevo Mensaje " + contador;
        }
    }

    public class MensajeModel
    {
        public static Coleccion<Mensaje> ListaMensajes { get; } = JsonConvert.DeserializeObject<Coleccion<Mensaje>>(LocalFilesModel.Load("Mensajes"));
        public static int Last_Id => ListaMensajes is null || ListaMensajes.Count == 0 ? 0 : ListaMensajes.Max(x => x.Id) + 1;

        public static void Save()
        {
            LocalFilesModel.Save(JsonConvert.SerializeObject(ListaMensajes), "Mensajes");
        }
    }
}
