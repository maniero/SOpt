import java.util.*;

class Ideone {
	public static void main (String[] args) {
		    ArrayList<String> posicoes = new ArrayList<String>();
		    posicoes.add("Ricardo;01051509912;gmail");
		    posicoes.add("Renato;123456789123;hotmail");
		    posicoes.add("Rodrigo;09873923121;yahoo");
		    System.out.println(BuscaString(posicoes, "01051509912"));
		    System.out.println(BuscaString(posicoes, "123456789123"));
	}
	public static int BuscaString(ArrayList<String> lista, String busca) {
	    for (int i = 0; i < lista.size(); i++) if (lista.get(i).contains(busca)) return i;
        return -1;
	}
}

//https://pt.stackoverflow.com/q/233378/101
