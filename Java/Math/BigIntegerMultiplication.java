import java.math.*;

class Main {
	public static void main (String[] args) {
		int p = 1274403499;
		int q = 1155563989;
		BigInteger n1 = BigInteger.valueOf(p);
		BigInteger n2 = BigInteger.valueOf(q);
		BigInteger n = n1.multiply(n2);
		System.out.println(n);
	}
}

//https://pt.stackoverflow.com/q/126016/101
