import java.math.*;

class Main {
	public static void main(String[] args)	{
		BigDecimal valor = new BigDecimal("10.00");
		valor.setScale(2);
		System.out.println(valor);
	}
}

//https://pt.stackoverflow.com/q/30701/101
