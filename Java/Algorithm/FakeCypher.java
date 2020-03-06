import java.lang.Math;

class ManipulacaoNumerica {
	public static int GerarC(String a, String b) {
	    if (a == null || b == null) return -2; //inventei isso, não sei o que deveria fazer
        String c = "";
        int limite = Math.max(a.length(), b.length());
        for (int i = 0; i <= limite; i++) {
        	if (i < a.length()) c += a.charAt(i);
        	if (i < b.length()) c += b.charAt(i);
        }
       	return c.length() > 6 ? -1 : Integer.valueOf(c.toString()); //tecnicamente não foi pedido bem isso
	}

	public static void Executa(String a, String b) {
        System.out.println("Valores de Entrada: " + a + " - " + b);
        System.out.println("Valor de Saída: " + GerarC(a, b));
	}

	public static void main(String[] args) {
	    Executa("24", "1999");
	}
}

//https://pt.stackoverflow.com/q/154373/101
