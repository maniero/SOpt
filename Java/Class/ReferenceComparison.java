class Ideone {
	public static void main (String[] args)	{
		Object x = 3044;
		Object y = x;
		System.out.println(saoIguais(x, y));
	}
	public static boolean saoIguais(Object obj, Object obj2) {
	    return obj == obj2;
	}
}

//https://pt.stackoverflow.com/q/237794/101
