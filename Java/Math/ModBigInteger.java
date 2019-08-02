import java.math.*;

class Program {
	public static void main (String[] args) {
        BigInteger bi1 = new BigInteger("-100");
        System.out.println(bi1.mod(new BigInteger("3")));
    }
}

//https://pt.stackoverflow.com/q/52045/101
