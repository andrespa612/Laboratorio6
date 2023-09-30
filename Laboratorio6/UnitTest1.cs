

namespace Laboratorio6
{
    public class UnitTest1
    {
        [Fact]
        public void TestSuma()
        {
            Operaciones.Calculadora calculadora = new Operaciones.Calculadora();
            Assert.Equal(3, calculadora.Suma(1, 2));
        }

        [Fact]
        public void TestResta()
        {
            Operaciones.Calculadora calculadora = new Operaciones.Calculadora();
            Assert.Equal(3, calculadora.Resta(5, 2));
        }

        [Fact]
        public void TestMulti()
        {
            Operaciones.Calculadora calculadora = new Operaciones.Calculadora();
            Assert.Equal(3, calculadora.Multiplicar(1, 3));
        }

        [Fact]
        public void TestDivision()
        {
            Operaciones.Calculadora calculadora = new Operaciones.Calculadora();
            Assert.Equal(3, calculadora.Dividir(9, 3));
        }
    }
}