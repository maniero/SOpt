import java.util.*;

public class Program {
	public static void main (String[] args) {
		String texto = "99E65A78";
		List<String> partes = new ArrayList<String>();
		for (int i = 0; i < texto.length(); i += 2) partes.add(texto.substring(i, Math.min(i + 2,texto.length())));
		for (int i = 0; i < partes.size(); i++) System.out.println(partes.get(i));
	}
}

//https://pt.stackoverflow.com/q/257349/101
