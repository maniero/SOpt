using static System.Console;

public class Program {
    public static void Main() {
        var p0 = 1.20M;
        var p1 = 1.15M;
        var p2 = 1.10M;
        var p3 = 1.05M;
        WriteLine("Digite o valor do salário do funcionário: ");
        if (!decimal.TryParse(ReadLine(), out var salario)) return; //deu erro
        decimal perc;
        if (salario < 280) perc = p0;
        else if (salario >= 280 && salario < 700) perc = p1;
        else if (salario >= 700 && salario < 1500) perc = p2;
        else perc = p3;
        WriteLine($"O salário do funcionário é: {salario *= perc}");
        WriteLine($"O percentual de aumento aplicado foi: {perc}");
    }
}

//https://pt.stackoverflow.com/q/348157/101
