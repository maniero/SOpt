import java.lang.*;

class Calculadora {
    public static int power(int n, int p) {
    	if (n < 0 || p < 0) throw new IllegalArgumentException("n ou p");
        return (int)Math.pow(n, p);
    }
    public static void main(String[] args) {
        System.out.println(power(10, 2));
    }
}

//https://pt.stackoverflow.com/q/118292/101
