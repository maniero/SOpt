import java.text.*;
import java.math.*;
import java.util.*;

class Exemplo {
	public static void main(String[] args) {
	    BigDecimal valor = new BigDecimal("100"); //idealmente deveria fazer parse formatado aqui também
	    exemplo(valor);
	}
	
	public static void exemplo(BigDecimal valor) {
        try {
	        DecimalFormat df = new DecimalFormat("###,##0", new DecimalFormatSymbols (new Locale ("pt", "BR")));
    	    df.setParseBigDecimal(true);
            BigDecimal decimal = (BigDecimal)df.parse("50.000");
		    if (valor.compareTo(decimal) == 1 || valor.compareTo(decimal) == 0) System.out.println("número maior");
	    	else System.out.println("número menor");
        } catch (ParseException e) { //só para facilitar, não faça isto
            e.printStackTrace();
        }
	}
}

//https://pt.stackoverflow.com/q/120192/101
