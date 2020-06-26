import java.util.Scanner;

class Main {
	public static void main (String[] args)	{
		Scanner sc = new Scanner(System.in);
		System.out.println("Informe dois valores: ");
		Calculadora calc = new Calculadora(sc.nextDouble(), sc.nextDouble());
		System.out.println(calc.soma());
		System.out.println(calc.subtracao());
		System.out.println(calc.multiplicacao());
		System.out.println(calc.divisao());
	}
}

class Calculadora {
	protected double x;
	protected double y;

	Calculadora(double x, double y) {
		this.x = x;
		this.y = y;
	}
	double soma() {
	    return x + y;
	}
	double subtracao() {
	    return x - y;
	}
	double multiplicacao() {
	    return x * y;
	}
	double divisao() {
	    return x / y;
	}
}

//https://pt.stackoverflow.com/q/254244/101
