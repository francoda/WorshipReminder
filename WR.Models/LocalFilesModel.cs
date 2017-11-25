using System;
using System.IO;

namespace WR.Models
{
    public class LocalFilesModel
    {
        private static string local = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static void Save(string json, string name)
        {
            if (!Directory.Exists(Path.Combine(local, "WorshipReminder")))
                Directory.CreateDirectory(Path.Combine(local, "WorshipReminder"));
            if (!File.Exists(Path.Combine(local, "WorshipReminder", name)))
                File.Create(Path.Combine(local, "WorshipReminder", name));
            File.WriteAllText(Path.Combine(local, "WorshipReminder", name), json);
        }

        public static string Load(string name)
        {
            string text = string.Empty;

            if (File.Exists(Path.Combine(local, "WorshipReminder", name)))
                text = File.ReadAllText(Path.Combine(local, "WorshipReminder", name));
            if (text == string.Empty)
            {
                return "[]"; //Json.Empty
            } else
            {
                return text;
            }
        }

        public static string SaveFile(string ruta)
        {
            if (!Directory.Exists(Path.Combine(local, "WorshipReminder", "Recursos")))
                Directory.CreateDirectory(Path.Combine(local, "WorshipReminder", "Recursos"));
            if (File.Exists(Path.Combine(local, "WorshipReminder", "Recursos", Path.GetFileName(ruta))))
                File.Delete(Path.Combine(local, "WorshipReminder", "Recursos", Path.GetFileName(ruta)));
            File.Copy(ruta, Path.Combine(local, "WorshipReminder", "Recursos", Path.GetFileName(ruta)));
            return Path.Combine(local, "WorshipReminder", "Recursos", Path.GetFileName(ruta));
        }

    }
}
