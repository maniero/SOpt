private String formatar_data(int inteiro, int casas) { //mudei o tipo do retorno
    NumberFormat nf = NumberFormat.getCurrencyInstance(new Locale( "pt", "BR" )); 
    String formatado = nf.format(inteiro / (Math.pow(10, casas)));
    System.out.println(formatado); //imagino que isto é só para testar
    return formatado; //eu eliminaria esta variável
}

//https://pt.stackoverflow.com/q/118407/101
