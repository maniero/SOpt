import java.util.ArrayList;
import java.text.*;

import javax.swing.text.MaskFormatter;

class GeraCPF {
    private ArrayList<Integer> listaAleatoria = new ArrayList<Integer>();
    private ArrayList<Integer> listaNumMultiplicados = null;
    public int geraNumAleatorio() {
        return (int)(Math.random() * 10);
    }   
    public ArrayList<Integer> geraCPFParcial() {
        for (int i = 0; i < 9; i++) listaAleatoria.add(geraNumAleatorio());
        return listaAleatoria;
    }
    public ArrayList<Integer> geraDigito() {
        listaNumMultiplicados = new ArrayList<Integer>();
        int primeiroDigito;
        int totalSomatoria = 0;
        int restoDivisao;
        int peso = 10;
        for (int item : listaAleatoria) listaNumMultiplicados.add(item * peso--);
        for (int item : listaNumMultiplicados) totalSomatoria += item;
        restoDivisao = (totalSomatoria % 11);
        primeiroDigito = restoDivisao < 2 ? 0 : 11 - restoDivisao;
        listaAleatoria.add(primeiroDigito);
        return listaAleatoria;
    }
    public String geraCPFFinal() throws ParseException {
        //Primeiro executamos os metodos de geracao
        geraCPFParcial();
        geraDigito();
        geraDigito();
        String cpf = "";
        String texto = "";
        for (int item : listaAleatoria) texto += Integer.toString(item);
        MaskFormatter mf = new MaskFormatter("###.###.###-##");  
        mf.setValueContainsLiteralCharacters(false);
        cpf = mf.valueToString(texto);
        return cpf; 
    }
	public static void main(String[] args) throws ParseException {
		System.out.println(new GeraCPF().geraCPFFinal());
	}
}

//https://pt.stackoverflow.com/q/108289/101
