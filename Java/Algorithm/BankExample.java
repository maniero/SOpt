import java.util.*;

class Main {
	public static void main(String[] args) {
	    Scanner input = new Scanner(System.in);
	    Locale.setDefault(Locale.US);
	    int operacao = 0;
	    System.out.println("Digite o saldo inicial: ");
	    double saldo = input.nextDouble();
	    do {
	        System.out.println("Digite o código da operação (1-deposito, 2-saque, 3-encerrar): ");
	        operacao = input.nextInt();
	        switch (operacao) {
	        case 1:
	            System.out.println("Digite o valor a ser depositado");
	            saldo += input.nextDouble();
	            break;
	        case 2:
	            System.out.println("Digite o valor do saque: ");
	            saldo -= input.nextDouble();
	            break;
	        }
	    } while (operacao != 3);
	    if (saldo == 0) System.out.println("CONTA ZERADA");
	    else if (saldo > 0) System.out.println("CONTA PREFERENCIAL");
	    else System.out.println("CONTA ESTOURADA");
	    System.out.printf("Saldo da conta: R$ %.2f%n", saldo);
	    input.close();
	}
}

//https://pt.stackoverflow.com/q/413254/101
