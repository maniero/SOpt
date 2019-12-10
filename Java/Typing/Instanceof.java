import java.util.*;

class InstanciaDe {
	public static void main( String[] args ) {
		int contaF = 0;
		int contaJ = 0;
	    ContaF Rafael = new ContaF();
	    ContaJ Roberto = new ContaJ();
	    ContaJ Carlos = new ContaJ();
	    ArrayList<Conta> lista = new ArrayList<Conta>();        
	    lista.add(Rafael);
	    lista.add(Roberto);
	    lista.add(Carlos);
	    for(int i = 0 ; i < lista.size() ; i++) {
	        if (lista.get(i) instanceof ContaF) {
	            contaF++;
	        }       
	        if (lista.get(i) instanceof ContaJ) {
	            contaJ++;
	        }
	    }
	    System.out.println(contaF);
	    System.out.println(contaJ);
	}
}
class Conta {}
class ContaF extends Conta {}
class ContaJ extends Conta {}

//https://pt.stackoverflow.com/q/118285/101
