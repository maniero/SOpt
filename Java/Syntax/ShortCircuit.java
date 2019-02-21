public class Program {
	public static void main(String[] args) {
		if (teste("1", false) & teste("2", true)) System.out.println("false & true entrou");
		if (teste("3", false) && teste("4", true)) System.out.println("false && true entrou");
		if (teste("5", true) & teste("6", false)) System.out.println("true & false entrou");
		if (teste("7", true) && teste("8", false)) System.out.println("true && false entrou");
		if (teste("9", false) | teste("10", true)) System.out.println("false | true entrou");
		if (teste("11", false) || teste("12", true)) System.out.println("false || true entrou");
		if (teste("13", true) | teste("14", false)) System.out.println("true | false entrou");
		if (teste("15", true) || teste("16", false)) System.out.println("true || false entrou");
	}
	public static boolean teste(String mensagem, boolean valor) {
		System.out.println(mensagem);
		return valor;
	}
}

//https://pt.stackoverflow.com/q/363837/101
