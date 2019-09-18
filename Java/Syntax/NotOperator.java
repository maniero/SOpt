if(livro.aplicaDescontoDe(0.3)) {
    System.out.println("Valor no livro com desconto: " + livro.getValor());
} else {
    System.out.println("Desconto no livro nao pode ser maior que 30%");
}

System.out.println(livro.aplicaDescontoDe(0.3) ? 
          "Valor no livro com desconto: " + livro.getValor() :
          "Desconto no livro nao pode ser maior que 30%");
          
//https://pt.stackoverflow.com/q/77728/101
