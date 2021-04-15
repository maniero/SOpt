class Main {
	public static void main(String[] args) {
		String[][] compras = new String[][] {
				{ "item 1", "1.70" }, { "item 2", "39.90" }, { "item 3", "9.90" }, { "item 4", "4.90" },
				{ "item 5", "7.90" } };
		int soma = 0;
		for (int i = 0; i < compras.length; i++) soma = (int)(soma + Double.parseDouble(compras[i][1]));
		System.out.println("Total das compras: R$ " + soma);
	}
}

//https://pt.stackoverflow.com/q/504945/101
