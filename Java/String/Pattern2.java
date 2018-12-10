import java.util.*;

class Program {
    public static void main (String[] args) {
        String texto = "(:TEXTOQUALQUER NADA DO FOI :TEXTOQQDENOVO SERÁ DE NOVO :TEXTOQQMAIS DO JEITO QUE UM DIA :TEXTO3343)";
        List<String> textos = new ArrayList<String>();
        while (texto.length() > 0) {
            texto = texto.substring(texto.indexOf(":") + 1);
            int posicaoParentese = texto.indexOf(")");
            int posicaoEspaco = texto.indexOf(" ");
            int posicaoFinal = Math.min((posicaoParentese == -1 ? Integer.MAX_VALUE : posicaoParentese), (posicaoEspaco == -1 ? Integer.MAX_VALUE : posicaoEspaco));
            textos.add(texto.substring(0, posicaoFinal));
            texto =  texto.substring(posicaoFinal + 1);
        }
        for (String item : textos) System.out.println(item);
    }
}

//https://pt.stackoverflow.com/q/43717/101
