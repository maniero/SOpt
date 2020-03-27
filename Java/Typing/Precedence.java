class Main {
	public static void main (String[] args) {
		System.out.println(123 * 100.0 / 123);
		System.out.println(123 * (100.0 / 123));
		System.out.println((double)123 * 100.0 / 123);		
		System.out.println(123 * 100.0 / (double)123);
		System.out.println(123 * 100 / 123);
		System.out.println(123 / 123 * 100.0);
		System.out.println(123 / (123 * 100.0));
		System.out.println((double)123 / 123 * 100.0);
		System.out.println(123 / (double)123 * 100.0);
		System.out.println(123 / 123 * 100);
	}
}

//https://pt.stackoverflow.com/q/442111/101
