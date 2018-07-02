import java.util.StringTokenizer;

class Ideone {
    public static void main (String[] args) {
        System.out.println(new StringTokenizer(" ").countTokens() > 1);
        System.out.println(new StringTokenizer(" a").countTokens() > 1);
        System.out.println(new StringTokenizer("a ").countTokens() > 1);
        System.out.println(new StringTokenizer(" a ").countTokens() > 1);
        System.out.println(new StringTokenizer("a").countTokens() > 1);
        System.out.println(new StringTokenizer(" a b").countTokens() > 1);
        System.out.println(new StringTokenizer("a b").countTokens() > 1);
    }
}

//https://pt.stackoverflow.com/q/311376/101
