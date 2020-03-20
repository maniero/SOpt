Cliente cliente = new Cliente();

public Pedido paraOCliente(String nome){
    Cliente cliente = new Cliente(nome);
    return this;
}

public Pedido paraOCliente(String nome){
    cliente = new Cliente(nome);
    return this;
}

//https://pt.stackoverflow.com/q/165453/101
