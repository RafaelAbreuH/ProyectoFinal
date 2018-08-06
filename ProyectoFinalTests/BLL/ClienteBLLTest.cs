using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL.Tests
{
    [TestClass()]
    public class ClientesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Cliente cliente = new Cliente
            {
                FechaRegistro = DateTime.Now,
                Nombres = "Rafael",
                Direccion = "Toribio piantini",
                Cedula = "111-111121-1",
                Telefono = "809-541-9654",
                Email = "Rafael@gmail.com"
        };

            bool paso = ClientesBLL.Guardar(cliente);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest1()
        {
            Assert.Fail();
        }
    }
}