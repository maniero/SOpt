class Program {
	public static void main (String[] args) {
		for (int x = 0; x < 10; x++) {
			if (x == 6) continue;
			if (x == 8) break;
			switch (x) {
			case 0:
				System.out.println("zero");
				continue;
			case 1:
				System.out.println("um");
				continue;
			case 2:
				System.out.println("dois");
				break;
			default:
				System.out.println(x);
				break;
			}
		}
	}
}

//https://pt.stackoverflow.com/q/318636/101
