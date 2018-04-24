using System;
using System.Drawing;
using System.IO;

namespace WR.Models
{
    public class Archivo
    {
        public static string localpath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Archivo() { }
        public Archivo(string ruta)
        {
            Directory.CreateDirectory(Path.Combine(localpath, "WorshipReminder", "Recursos"));
            if (File.Exists(Path.Combine(localpath, "WorshipReminder", "Recursos", Path.GetFileName(ruta))))
                File.Delete(Path.Combine(localpath, "WorshipReminder", "Recursos", Path.GetFileName(ruta)));
            File.Copy(ruta, Path.Combine(localpath, "WorshipReminder", "Recursos", Path.GetFileName(ruta)));
            Ruta = Path.Combine(localpath, "WorshipReminder", "Recursos", Path.GetFileName(ruta));
        }

        public string Ruta { get; set; } = string.Empty;
        public string Nombre { get { try { return Path.GetFileName(Ruta); } catch { return "Error"; } } }
        public Icon Imagen { get { try { return Icon.ExtractAssociatedIcon(Ruta); } catch { return null; } } }
        public string Tamano
        {
            get
            {
                try
                {
                    long size = new FileInfo(Ruta).Length;
                    if (size > 1000000000)
                        return (size / 1000000000).ToString() + "gb";
                    else if (size > 1000000)
                        return (size / 100000).ToString() + "mb";
                    else if (size > 1000)
                        return (size / 1000).ToString() + "kb";
                    else
                        return size.ToString() + "b";
                }
                catch
                {
                    return "Error";
                }
            }
        }
    }
}