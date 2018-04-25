using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace WR.Models
{
    public class Mensaje
    {
        private string descripcion;

        public String Titulo { get; set; } = "Nuevo Mensaje";
        public List<string> Tags { get; set; } = new List<string>();
        public SortedSet<BibliaModel.Versiculo> Pasajes { get; set; } = new SortedSet<BibliaModel.Versiculo>();
        public Lista<Archivo> Archivos { get; set; } = new Lista<Archivo>();

        public string Descripcion
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(descripcion))
                    return descripcion;
                if (Archivos.Any(x => Path.GetExtension(x.Nombre).Remove(0, 1).ToLower().Contains("doc")))
                {
                    string descripcionWord = string.Empty;
                    object objNull = System.Reflection.Missing.Value;
                    Document Doc = new Application().Documents.Open(Archivos.First(x => Path.GetExtension(x.Nombre).Remove(0, 1).ToLower().Contains("doc")).Ruta, objNull, true, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull, objNull);
                    //foreach (Paragraph objParagraph in Doc.Paragraphs)
                    //    try { descripcionWord += objParagraph.Range.Text; } catch { }
                    Doc.ActiveWindow.Selection.WholeStory();
                    Doc.ActiveWindow.Selection.Copy();
                    descripcionWord = System.Windows.Forms.Clipboard.GetDataObject().GetData(System.Windows.Forms.DataFormats.Text).ToString();
                    Doc.Close();
                    return descripcionWord;
                }
                return string.Empty;
            }
            set { descripcion = value; }
        }

        public int CantidadArchivos => Archivos.Count;
        public int CantidadContenido => Descripcion.Length;
        public bool TieneDescripcion => string.IsNullOrWhiteSpace(descripcion);

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
