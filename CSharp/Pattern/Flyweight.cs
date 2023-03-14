class Produto { // existirão alguns, talvez milhares
    int Id;
    string Nome;
    decimal Preco;
    Cor Cor;
    .
    .
    .
}

class Item { // potencialmente existirão milhões
    int Id;
    int ProdutoId; //compõe aqui
    string Serial;
    DateTime Validade;
}

//https://pt.stackoverflow.com/q/164960/101
