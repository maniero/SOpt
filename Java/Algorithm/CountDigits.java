class Main {
	static int countZeros(int n) {
	    int count = 0;
	    while (n % 10 == 0) {
	        count++;
	        n /= 10;
	    }
	    return count;
	}
	public static void main (String[] args) {
		System.out.println(countZeros(123000));
		System.out.println(countZeros(102030));
	}
}

//https://pt.stackoverflow.com/q/112972/101
