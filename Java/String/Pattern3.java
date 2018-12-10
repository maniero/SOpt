class Program {
    public static void main (String[] args) {
        String texto = "(:TEXTOQUALQUER NADA DO FOI :TEXTOQQDENOVO SERÁ DE NOVO :TEXTOQQMAIS DO JEITO QUE UM DIA :TEXTO3343)";
        String[] textos = texto.split(":");
        for (String item : textos) System.out.println(item);
    }
}

//https://pt.stackoverflow.com/q/43717/101
