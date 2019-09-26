using static System.Console;

public class Program {
  public static void Main() {
    var resultado = "2";
    if (int.TryParse(resultado, out var numero)) resultado = (numero + 1).ToString();
    WriteLine(resultado);
    resultado = "A";
    if (int.TryParse(resultado, out numero)) resultado = (numero + 1).ToString();
    WriteLine(resultado);
  }
}

 //https://pt.stackoverflow.com/q/82477/101
