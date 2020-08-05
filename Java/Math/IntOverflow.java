class Loop {
	public static void main(String[] a) {
		int cont = 0;
		for (int i = 1; i < 10000000000000000L; i *= 2, cont++) { System.out.println("i:" + i); }
		System.out.println("cont:"+cont);
	}
}

//https://pt.stackoverflow.com/q/326539/101
