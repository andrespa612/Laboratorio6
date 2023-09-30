

namespace Laboratorio6
{
    public class UnitTest1
    {
        [Fact]
        public void Calculadora_Suma_Caso()
        {
            Operaciones.Calculadora calculadora = new Operaciones.Calculadora();
            Assert.Equal(3, calculadora.Suma(1, 2));
        }

        [Fact]
        public void Calculadora_Resta_Caso()
        {
            Operaciones.Calculadora calculadora = new Operaciones.Calculadora();
            Assert.Equal(3, calculadora.Resta(5, 2));
        }

        [Fact]
        public void Calculadora_Multiplicacion_Caso()
        {
            Operaciones.Calculadora calculadora = new Operaciones.Calculadora();
            Assert.Equal(3, calculadora.Multiplicar(1, 3));
        }

        [Fact]
        public void Calculadora_Division_Caso()
        {
            Operaciones.Calculadora calculadora = new Operaciones.Calculadora();
            Assert.Equal(3, calculadora.Dividir(9, 3));
        }
    }
}