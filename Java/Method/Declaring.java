import java.util.Arrays;

class OrdenaArgumentos {
    public static void main() {
	    String [] nomes = new String []{ " rafael cosentino ", " jonas hirata ", " marcelo martins "};
	    java.util.Arrays.sort(nomes);
        for (String nome : nomes) System.out.println(nome);
    }
}

//https://pt.stackoverflow.com/q/103587/101
