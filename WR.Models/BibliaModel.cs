using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text.RegularExpressions;

namespace WR.Models
{
    public class BibliaModel
    {
        private const string token = "Dl7CSvEZKeEzaxsfdt67fKMLd66b5CHz24EzEurC";

        public static List<Version> GetVersiones()
        {
            return JsonConvert.DeserializeObject<List<Version>>(Get("https://es.bibles.org/v2/versions.js?language=spa")["versions"].ToString());
        }

        public static List<Libro> GetLibros(string idVersion)
        {
            return JsonConvert.DeserializeObject<List<Libro>>(Get($"https://es.bibles.org/v2/versions/{idVersion}/books.js")["books"].ToString());
        }

        public static List<Capitulo> GetCapitulos(string idLibro)
        {
            return JsonConvert.DeserializeObject<List<Capitulo>>(Get($"https://es.bibles.org/v2/books/{idLibro}/chapters.js")["chapters"].ToString());
        }

        public static List<Versiculo> GetVersiculos(string idCapitulo)
        {
            return JsonConvert.DeserializeObject<List<Versiculo>>(Get($"https://es.bibles.org/v2/chapters/{idCapitulo}/verses.js")["verses"].ToString());
        }

        //public static List<Pasaje> GetVersiculos(string idVersion, Seccion seccion1, Seccion seccion2)
        //{
        //    seccion1.Id = seccion1.Id + "-" + seccion2.Id.Split('.').Last();
        //    return JsonConvert.DeserializeObject<List<Pasaje>>(Get($"https://es.bibles.org/v2/passages.js?q[]={seccion1.Id}&version={idVersion}")["search"]["result"].ToString());
        //}
        

        private static JToken Get(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Credentials = new NetworkCredential(token, "x");

            try
            {
                WebResponse resp = request.GetResponse();
                string jsonString = string.Empty;

                using (StreamReader srRead = new StreamReader(resp.GetResponseStream()))
                    jsonString = srRead.ReadToEnd();

                return JObject.Parse(jsonString)["response"];
            }
            catch (WebException ex)
            {
                string jsonString = string.Empty;

                using (StreamReader srRead = new StreamReader(ex.Response.GetResponseStream()))
                    jsonString = srRead.ReadToEnd();
                throw new Exception(ex.Message);
            }
        }

        public class Version
        {
            public string Path { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public string Lang { get; set; }
            public string Lang_code { get; set; }
            public string Contact_url { get; set; }
            public string Audio { get; set; }
            public string Copyright { get; set; }
            public string Info { get; set; }
            public string Lang_name { get; set; }
            public string Lang_name_eng { get; set; }
            public string Abbreviation { get; set; }
            public string Updated_at { get; set; }
        }

        public class Seccion
        {
            public string Path { get; set; }
            public string Id { get; set; }
            public Version Parent { get; set; }
            public Seccion Next { get; set; }
            public Seccion Previous { get; set; }
            public string Osis_end { get; set; }
            public string Copyright { get; set; }
        }

        public class Libro : Seccion
        {
            public string Name { get; set; }
            public string Version_id { get; set; }
            public string Book_group_id { get; set; }
            public string Abbr { get; set; }
            public string Testament { get; set; }
            public string Ord { get; set; }
        }

        public class Capitulo : Seccion
        {
            public string Chapter { get; set; }
            public string Label { get; set; }
            public string Auditid { get; set; }
        }

        public class Versiculo : Seccion
        {
            public string Reference { get; set; }
            public string Text { get; set; }
            public string Label { get; set; }
            public string Auditid { get; set; }
            public string Verse { get; set; }
            public string Lastverse { get; set; }
        }

        public class Pasaje
        {
            public string Copyright { get; set; }
            public string Text { get; set; }
            public string End_verse_id { get; set; }
            public string Version { get; set; }
            public string Path { get; set; }
            public string Version_abbreviation { get; set; }
            public string Start_verse_id { get; set; }
            public string Display { get; set; }
        }
    }
}
