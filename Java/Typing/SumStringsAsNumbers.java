class Program {
	public static void main(String[] args) {
		System.out.println(calculateAverage("10", "20"));
	}
	private static float calculateAverage(String a, String b) {
    	return (Float.parseFloat(a) + Float.parseFloat(b)) / 2;
	}
}

//https://pt.stackoverflow.com/q/355849/101
