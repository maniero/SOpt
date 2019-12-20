using System;
using static System.Console;
					
public class Program {
	public static void Main() => WriteLine(CalcularDataEntrega("04/07/2016")); //não está em formato brasilerio, mas é só questão de configuração.
    private static string CalcularDataEntrega(string dataEntrada) => DateTime.Parse(dataEntrada).AddDays(28).ToString();
}

//https://pt.stackoverflow.com/q/122142/101
