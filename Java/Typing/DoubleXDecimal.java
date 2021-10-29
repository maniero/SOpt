import java.math.*;
import java.text.*;

class Main {
	public static void main (String[] args)	{
		DecimalFormat df = new DecimalFormat("#0.#");
		df.setRoundingMode(RoundingMode.HALF_UP);
		System.out.println("0.55: " + df.format(BigDecimal.valueOf(0.55)));
		System.out.println("1.55: " + df.format(BigDecimal.valueOf(1.55)));
		System.out.println("2.55: " + df.format(BigDecimal.valueOf(0.55)));
		System.out.println("3.55: " + df.format(BigDecimal.valueOf(3.55)));
		System.out.println("4.55: " + df.format(BigDecimal.valueOf(4.55)));
		System.out.println("5.55: " + df.format(BigDecimal.valueOf(5.55)));
	}
}

//https://pt.stackoverflow.com/q/532475/101
