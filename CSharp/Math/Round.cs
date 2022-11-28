using static System.Console;
using static System.Math;
					
WriteLine($"O valor de PI é: {Round(Calculadora.PI, 4)}");
WriteLine($"A área é: {Calculadora.CalculaAreaCircunferencia(2):0.####}");

public class Calculadora {
    public static double PI = System.Math.PI;
    public static double CalculaAreaCircunferencia(double raio) => PI * Pow(raio, 2);
}

//https://pt.stackoverflow.com/q/571427/101
