import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		int soma = 0, somaM = 0, somaF = 0, contM = 0, contF = 0, contJ = 0;
		for (int x = 0; x < 3; x++) {
			System.out.println("Digite o sexo: ");
			int sexo = entrada.nextInt();
			System.out.println("Digite a idade: ");
			int idade = entrada.nextInt();
			System.out.println("Digite a altura: ");
			int altura = entrada.nextInt();
			soma += idade;
			if (sexo == 1) {
				somaM += idade;
				contM++;
			} else if (sexo == 0) {
				somaF += altura;
				contF++;
			}
			if (idade >= 18 && idade <= 35) contJ++;
		}
		System.out.println("Média da idade (geral) " + ((double)soma / 3));
		System.out.println("Média da altura (feminino) " + ((double)somaF / contF));
		System.out.println("Média da idade (masculino) " + ((double)somaM / contM));
		System.out.println("Percentual de pessoas com idade entre 18-35 anos: " + (100 / 3 * (double)contJ));
	}
}

//https://pt.stackoverflow.com/q/319183/101
