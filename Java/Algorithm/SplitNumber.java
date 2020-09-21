import java.util.*;

class Main {
	public static void main (String[] args)	{
		ImprimeLista(SeparaDigitos(12345));
		ImprimeLista(SeparaDigitos(-123));
		ImprimeLista(SeparaDigitosNegativo(-123));
		ImprimeLista(SeparaDigitosNegativo(123));
	}
	public static List<Integer> SeparaDigitos(int valor) {
		List<Integer> numerosGerados = new ArrayList<>();
        int positivo = Math.abs(valor);
		int tamanho = (int)(Math.log10(positivo) + 1);
		int posicao = 0;
		while(posicao < tamanho) {
			int digito = valor / (int)Math.pow(10, tamanho - posicao - 1) * Integer.signum(valor);
			numerosGerados.add(digito);
			valor %= digito * Math.pow(10, tamanho - posicao - 1);
			posicao++;
		}
    	return numerosGerados;
	}
	public static List<Integer> SeparaDigitosNegativo(int valor) {
		List<Integer> numerosGerados = new ArrayList<>();
        int positivo = Math.abs(valor);
		int tamanho = (int)(Math.log10(positivo) + 1);
		int posicao = 0;
		while(posicao < tamanho) {
			int digito = valor / (int)Math.pow(10, tamanho - posicao - 1) * (posicao == 0 ? 1 : Integer.signum(valor));
			numerosGerados.add(digito);
			valor %= digito * Math.pow(10, tamanho - posicao - 1);
			posicao++;
		}
    	return numerosGerados;
	}
	public static void ImprimeLista(List<Integer> lista) {
 		for (int item : lista) {
			System.out.println(item);
		}
		System.out.println();
	}
}

//https://pt.stackoverflow.com/q/53225/101
