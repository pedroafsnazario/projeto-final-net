namespace CalculadoraTestes;

public class UnitTest1
{

   public Calculadora construirClasse() {
      string data  = "02/02/2020";
      Calculadora calc = construirClasse();

      return calc;
   }



    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
       Calculadora calc = construirClasse();

       int resultadoC = calc.somar(val1, val2);

       Assert.Equal(resultado, resultadoC);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData(5, 5, 0)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
       Calculadora calc = construirClasse();

       int resultadoC = calc.subtrair(val1, val2);

       Assert.Equal(resultado, resultadoC);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
       Calculadora calc = construirClasse();

       int resultadoC = calc.multiplicar(val1, val2);

       Assert.Equal(resultado, resultadoC);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
       Calculadora calc = construirClasse();

       int resultadoC = calc.dividir(val1, val2);

       Assert.Equal(resultado, resultadoC);
    }


    [Fact]
    public void Test2()
    {
       Calculadora calc = construirClasse();

       int resultado = calc.somar(1, 2);

       Assert.Equal(3, resultado);
    }

    [Fact]
    public void TestarDivisaoPorZero(){
      Calculadora calc = construirClasse();

      Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0));

    }


    [Fact]
    public void TestarHistorico(){
      Calculadora calc = construirClasse();

      calc.somar(1, 2);
      calc.somar(2, 8);
      calc.somar(8, 9);
      calc.somar(4, 1);

      var lista = calc.historico();

      Assert.NotEmpty(lista);
      Assert.Equal(3, lista.Count);

    }
}