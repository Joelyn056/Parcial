using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimerParcial.Entidades;

namespace PrimerParcial.BLL.Tests
{
    [TestClass()]
    public class GrupoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;

            Grupos grupo = new Grupos();
            grupo.GruposID = 0;
            grupo.Descripcion = "Mat";
            grupo.Cantidad = 20;
            grupo.grupos1 = 2;
            grupo.Integrantes = 10;

            paso = BLL.GrupoBLL.Guardar(grupo);

            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso = false;

            Grupos grupo = new Grupos();
            grupo.GruposID = 1;
            grupo.Descripcion = "Matematica";
            grupo.Cantidad = 30;
            grupo.grupos1 = 2;
            grupo.Integrantes = 15;

            paso = BLL.GrupoBLL.Modificar(grupo);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = BLL.GrupoBLL.Eliminar(1);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Grupos grupo = new Grupos();
            grupo = BLL.GrupoBLL.Buscar(2);
            Assert.IsNotNull(grupo);
;        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = BLL.GrupoBLL.GetList(g => true);
            Assert.IsNotNull(lista);
        }
    }
}