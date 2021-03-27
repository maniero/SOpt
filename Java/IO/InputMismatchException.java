System.out.println("NOME DO PRODUTO: ");
produto.setNome(entrada.next().trim().replace(" ", "").toUpperCase());
try {
    System.out.print("PREÇO: ");
    produto.setPreco(entrada.nextDouble());
    System.out.print("QUANTIDADE: ");
    item.setQuantidade(entrada.nextInt());
} catch (java.util.InputMismatchException e) {
    System.out.print("ERRO");
}

//https://pt.stackoverflow.com/q/494438/101
