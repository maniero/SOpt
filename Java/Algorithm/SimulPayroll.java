import java.util.Scanner;

class CalculoSalarioLiquido {
    public static void main (String args []) {
        System.out.println("Programa para calcular o Salário Líquido: ");
        System.out.println("Escreva o Número de Horas Trabalhadas pelo Funcionário: ");
        Scanner sc = new Scanner (System.in);
        double numerodehorastrabalhadas = sc.nextInt();
        System.out.println("Escreva o Número de Horas Extras Trabalhadas pelo Funcionário: ");
        double numerodehorasextras = sc.nextInt();
                double salariobruto = calcularsalariodofuncionario(numerodehorastrabalhadas, numerodehorasextras);
		double impostoderenda = calcularImpostoDeRenda(salariobruto);
		double seguridadesocial = calcularSeguridadeSocial(salariobruto);
        System.out.println("Salário Bruto: " + salariobruto);
        System.out.println("Imposto de Renda: " + impostoderenda);
        System.out.println("Seguro Social: " + seguridadesocial);
        System.out.println("Salário Líquido: " + calcularSalarioLiquido(salariobruto, seguridadesocial, impostoderenda));
    }

    public static double calcularsalariodofuncionario(double numeroDeHorasTrabalhadas, double numeroDeHorasExtras) {
        double salarioinicial = numeroDeHorasTrabalhadas * 18.6;
        double salariosdashorasextras = 5.7 * numeroDeHorasExtras;
        double salariobruto = salarioinicial + salariosdashorasextras;
        return salariobruto;
    }

    public static double calcularImpostoDeRenda(double salariobruto) {
        double impostoderenda = salariobruto * 0.49;
        return impostoderenda;
    }

    public static double calcularSeguridadeSocial(double salariobruto) {
        double seguridadesocial = salariobruto * 0.94;
        return seguridadesocial;
    }

    public static double calcularSalarioLiquido(double salariobruto, double seguridadesocial, double impostoderenda) {
	    double salarioliquido = salariobruto - seguridadesocial - impostoderenda;
	    return salarioliquido;
    }
}

//https://pt.stackoverflow.com/q/141064/101
