using System.Drawing;
using System.IO;

namespace WR.Models
{
    public class Archivo
    {
        public Archivo() { }
        public Archivo(string Ruta)
        {
            this.Ruta = Ruta;
        }

        public string Ruta { get; set; } = string.Empty;
        public string Nombre { get { try { return Path.GetFileName(Ruta); } catch { return "Error"; } } }
        public Icon Imagen { get { try { return Icon.ExtractAssociatedIcon(Ruta); } catch { return null; } } }
        public string Tamano { get
            {
                try
                {
                    long size = new FileInfo(Ruta).Length;
                    if (size > 1000000000)
                    {
                        return (size / 1000000000).ToString() + "gb";
                    }
                    else if (size > 1000000)
                    {
                        return (size / 100000).ToString() + "mb";
                    }
                    else if(size > 1000)
                    {
                        return (size / 1000).ToString() + "kb";
                    }
                    else
                    {
                        return size.ToString() + "b";
                    }
                }
                catch
                {
                    return "Error";
                }
            }
        }
    }
}
