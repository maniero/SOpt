class Main {
	public static void main (String[] args)	{
		int x = 534;
		switch (x / 200) {
			case 0:
				System.out.println("entre 0 e 199");
				break;
			case 1:
				System.out.println("entre 200 e 399");
				break;
			case 2:
				System.out.println("entre 400 e 599");
				break;
			default:
				System.out.println("600 ou mais");
				break;
		}
	}
}

//https://pt.stackoverflow.com/q/258024/101
