using static System.Console;
using static System.Math;

abstract class Figura {
    public virtual double CalculoArea() => CalculoArea();
}

class Quadrado : Figura {
    public double Lado { get; set; } = 0;
    public override double CalculoArea() => Pow(Lado, 4);
}

class Triangulo : Figura {
    public double Altura { get; set; }
    public double Base { get; set; }
    public override double CalculoArea() => Altura * Base / 2;
}

class Circunferencia : Figura {
    public double Raio { get; set; } = 0;
    public override double CalculoArea() => PI * Pow(Raio, 2);
}

class Imprimir {
    static int Main() {
        var quadrado = new Quadrado();
        var triangulo = new Triangulo();
        var circulo = new Circunferencia();
        WriteLine("Classe Quadrado");
        Write("Digite o lado do quadrado: ");
        if (!double.TryParse(ReadLine(), out var digitelado)) return 1;
        quadrado.Lado = digitelado;
        WriteLine();
        WriteLine("Classe Triângulo");
        Write("Digite a altura do triângulo: ");
        if (!double.TryParse(ReadLine(), out var digitealtura)) return 1;
        triangulo.Altura = digitealtura;
        Write("Digite a base do triângulo: ");
        if (!double.TryParse(ReadLine(), out var digitebase)) return 1;
        triangulo.Base = digitebase;
        WriteLine();
        WriteLine("Classe Círculo");
        Write("Digite o raio do círculo: ");
        if (!double.TryParse(ReadLine(), out var digiteraio)) return 1;
        circulo.Raio = digiteraio;
        WriteLine();
        WriteLine($"O cálculo da área do quadrado é {quadrado.CalculoArea()}cm2");
        WriteLine($"O cálculo da área do triângulo é {triangulo.CalculoArea()}cm2");
        WriteLine($"O cálculo da área do círculo é {circulo.CalculoArea()}cm2");
        return 0;
    }
}

//https://pt.stackoverflow.com/q/425005/101
