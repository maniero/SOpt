class Main {
	public static void main (String[] args) {
		String frase = "Daniel Henrique";
		int[] quantidades = new int[26];
		for (int i = 0; i < frase.length(); i++) {
		    if (frase.charAt(i) > 64 && frase.charAt(i) < 91) quantidades[frase.charAt(i) - 65]++;
		    if (frase.charAt(i) > 96 && frase.charAt(i) < 123) quantidades[frase.charAt(i) - 97]++;
		}
		for (int i = 0; i < quantidades.length; i++) System.out.println((char)(i + 65) + " => " + quantidades[i]);
	}
}

//https://pt.stackoverflow.com/q/422127/101
