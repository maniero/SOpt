import java.util.*;

class Main {
	public static void main(String[] args) {
	    Scanner in = new Scanner (System.in);
	    Map<String,Integer> mapa = new HashMap<String,Integer>();
	    mapa.put("45 - Jose"  , 0); //A "Key" deve ser o numero do Candidato,        
	    mapa.put("13 - Maria" , 0); // e  o "Value" o contador  que vai 
	    mapa.put("20 - Pedro" , 0); // contabilizar os votos,  porem nao sei
	    mapa.put("50 - Carol" , 0); // como criar  o contador aqui.      
	    for (Map.Entry<String, Integer> conteudo : mapa.entrySet()) {
	        System.out.println(conteudo.getKey());
	        System.out.printf("Votos = %d \n", conteudo.getValue());
	    }
	    String continuar;
	    do {
		    System.out.println("\nEm que candidato deseja votar? ");
		    String key =  in.nextLine();
		    if (mapa.containsKey(key)) {
		        mapa.put(key, mapa.get(key) + 1);
		        System.out.printf("\nCandidato: %s \nVotos = %d \n", key, mapa.get(key));  
		    } else {
		        System.err.printf("\nCandidato %s nao encontrado.\n", key);
		    }
		    System.out.println("\nDeseja continuar: (s/n)");
		    continuar = in.nextLine();
	    } while ("s".equalsIgnoreCase(continuar));

	}
}

//https://pt.stackoverflow.com/q/128681/101
