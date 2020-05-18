class Main {
	public static void main (String[] args) {
		for (int i = 0; i < 32; i++) System.out.println("" + i / 16 % 2 + i / 8 % 2 + i / 4 % 2 + i / 2 % 2 + i % 2);
	}
}

//https://pt.stackoverflow.com/q/205295/101
