class HelloWorld {
	public static void main (String[] args)	{
		int x = -100;
		x >>= 2;
		System.out.println(x);
		x = 100;
		x >>= 2;
		System.out.println(x);
		x = -100;
		x >>>= 2;
		System.out.println(x);
		x = 100;
		x >>>= 2;
		System.out.println(x);
	}
}

//http://pt.stackoverflow.com/q/192874/101
