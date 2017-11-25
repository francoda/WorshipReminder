using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WR.Models;

namespace WR.Testing
{
    [TestClass]
    public class BibliaModelTest
    {
        [TestMethod]
        public void GetAll()
        {
            List<BibliaModel.Version> versiones = BibliaModel.GetVersiones();
            List<BibliaModel.Libro> libros = BibliaModel.GetLibros(versiones[0].Id);
            List<BibliaModel.Capitulo> capitulos = BibliaModel.GetCapitulos(libros[0].Id);
            List<BibliaModel.Versiculo> versiculos = BibliaModel.GetVersiculos(capitulos[0].Id);
            //List<BibliaModel.Pasaje> pasajes = BibliaModel.GetVersiculos(versiones[0].Id, versiculos[0], versiculos[1]);
        }
    }
}
