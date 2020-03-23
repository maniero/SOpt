class Main {
	public static void main (String[] args)	{
		int x = 10;
		boolean cond = x == 10;
		System.out.println(cond);
		if (cond) System.out.println("executou");
		cond = metodo();
		System.out.println(cond);
		if (cond) System.out.println("executou");
		System.out.println(x == 10);
		if (x == 10) System.out.println("executou");
		System.out.println(metodo());
		if (metodo()) System.out.println("executou");
	}
	public static boolean metodo() {
		return true;
	}
}

//https://pt.stackoverflow.com/q/165494/101
