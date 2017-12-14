import java.util.Scanner;

public class Caixa {
   	static private Conta minhaConta;
    static private Scanner entrada = new Scanner(System.in);
    public static void main(String[] args) {
        int opcao = -1;
        do {
	        System.out.println("\t Escolha a opção desejada");
	        if (minhaConta != null) {
		        System.out.println("1 - Consultar Saldo");
		        System.out.println("2 - Sacar");
		        System.out.println("3 - Depositar");
	        }
	        System.out.println("4 - Abrir Conta");
	        System.out.println("0 - Sair\n");
	        System.out.print("Opção: ");
            opcao = lerInt();
            if (minhaConta == null && opcao != 0) opcao = 4;
	        switch (opcao) {
            case 1:
                System.out.println("SALDO");
		        System.out.println("Nome: " + minhaConta.getNome());
		        System.out.println("Número da conta: " + minhaConta.getConta());
		        System.out.printf("Saldo atual: %.2f\n", minhaConta.getSaldo());
		        System.out.println("Saques realizados: " + minhaConta.getSaques() + "\n");
                break;
            case 2:
                if (minhaConta.podeSacar()) {
                    System.out.print("Quanto deseja sacar: ");
                    int ok = minhaConta.sacar(lerInt());
                    if (ok >= 0) {
                        System.out.println("Sacado: " + ok);
				        System.out.println("Novo saldo: " + minhaConta.getSaldo() + "\n");
                    } else if (ok == -1) System.out.println("Não pode ser negativo\n");
                    else if (ok == -2) System.out.println("Saldo insuficiente. Faça um depósito\n");
                     else if (ok == -3) System.out.println("Limite de saques atingidos.\n");
                } else System.out.println("Limite de saques atingidos.\n");
                break;
            case 3:
                System.out.print("Quanto deseja depositar: ");
                int ok = minhaConta.depositar(lerInt());
                if (ok >= 0) {
                    System.out.println("Depositado: " + ok);
			        System.out.println("Novo saldo: " + minhaConta.getSaldo() + "\n");
                } else System.out.print("Não pode ser negativo");
                break;
            case 4: 
		        System.out.println("Cadastrando novo cliente.");
		        System.out.print("Ente com seu nome: ");
		        System.out.print("Entre com o valor inicial depositado na conta: ");
		        minhaConta = new Conta(entrada.nextLine(), lerInt());
                break;
            case 0: break;
            default:
                System.out.println("Opção inválida");
	        }
        } while (opcao != 0);
    }
    private static int lerInt() {
        while (true) {
            String lido = entrada.nextLine().trim();
            try {
                return Integer.parseInt(lido);
            } catch (NumberFormatException e) {
                System.out.println("Desculpe, mas " + lido + " não é um número inteiro. Tente novamente.");
            }
        }
    }
}

class Conta {
	static private int ultimaConta;
    private String nome;
    private int conta, saques;
    private double saldo;
    public String getNome() { return nome; }
    public double getConta() { return conta; }
    public double getSaldo() { return saldo; }
    public int getSaques() { return saques; }
    public boolean podeSacar() { return saques < 3; }
    public Conta(String nome, int saldoInicial) {
        this.nome = nome;
        conta = ++ultimaConta;
        saldo = saldoInicial < 0 ? 0 : saldoInicial;
    }
    public int sacar(int valor) {
    	if (valor < 1) return -1;
        if (saldo < valor) return -2;
        if (!podeSacar()) return -3;
        saldo -= valor;
        saques++;
        return valor;
    }
    public int depositar(int valor) {
    	if (valor < 1) return -1;
        saldo += valor;
        return valor;
    }
}

//https://pt.stackoverflow.com/q/262849/101
