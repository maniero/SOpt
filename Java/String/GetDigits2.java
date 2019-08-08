import java.lang.*;

class Program {
	public static void main (String[] args) {
		System.out.println(PegaPrimirosDigitos(12345678, 4));
		System.out.println(PegaPrimirosDigitos(-12345678, 4));
		System.out.println(PegaPrimirosDigitos(123, 4));
		System.out.println(PegaPrimirosDigitos(-12, 4));
		System.out.println(PegaPrimirosDigitos(0, 0));
	}
	public static int PegaPrimirosDigitos(int valor, int digitos) {
		digitos = Math.max(1, digitos);
		int positivo = Math.abs(valor);
		int tamanho = (int)(Math.log10(positivo) + 1);
        if(digitos > tamanho) {
            return valor;
        }
		return valor / (int)Math.pow(10, tamanho - digitos);
	}
}

//https://pt.stackoverflow.com/q/53055/101
