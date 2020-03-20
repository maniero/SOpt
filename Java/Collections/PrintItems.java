public Pedido ToString() {
     mensagem = "Pedido do Cliente " + cliente.getNome() + "\n";
     for (Item item : lista) mensagem += "Quantidade: " + item.quantidade + " Produto: " + item.nomeProduto + "\n";
     return this;
}

//https://pt.stackoverflow.com/q/165731/101
