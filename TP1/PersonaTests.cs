using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TP1;

namespace TestsPersonas
{
    public class ElectrodomesticoTests
    {
        private Lavadora _lavadora;
        private Television _television;

        [SetUp]

        public void setup()
        {
            var lavadora = new Lavadora()
            {
                PrecioBase = 700,
                Color = "Blanco",
                ConsumoEnergetico = 'C',
                Peso = 50d,
                Carga = 45
            };
            _lavadora = lavadora;
            var television = new Television()
            {
                PrecioBase = 500,
                Color = "Negro",
                ConsumoEnergetico = 'B',
                Peso = 25d,
                Resolucion = 45
            };
            _television = television;
        }

        [Test]

        public void validarConsumoEnergeticoLavadora_test()
        {
            bool resultado = _lavadora.validarConsumoEnergetico(_lavadora.ConsumoEnergetico);
            Assert.That(resultado, Is.True);
        }

        [Test]
        public void validarConsumoEnergeticoTelevision_test()
        {
            bool resultado = _television.validarConsumoEnergetico(_television.ConsumoEnergetico);
            Assert.That(resultado, Is.True);
        }

        [Test]
        public void comprobarColorLavadora_test()
        {
            bool resultado = _lavadora.comprobarColor(_lavadora.Color);
            Assert.That(resultado, Is.True);
        }

        [Test]
        public void comprobarColorTelevision_test()
        {
            bool resultado = _television.comprobarColor(_television.Color);
            Assert.That(resultado, Is.True);
        }

        [Test]
        public void precioFinalLavadora_test()
        {
            int resultado = _lavadora.precioFinal();
            int esperado = 190;
            Assert.AreEqual(resultado, esperado);
        }

        [Test]
        public void precioFinalTelevision_test()
        {
            int resultado = _television.precioFinal();
            int esperado = 169;
            Assert.AreEqual(resultado, esperado);
        }
    }
}

