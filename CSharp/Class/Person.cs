class Pessoa {
    string Nome;
}
class Cliente {
    Pessoa pessoa;
    decimal credito;
}
class Faturamento {
    Venda(Cliente cliente) => Write(cliente.pessoa.Nome);
}

class Pessoa {
    string Nome;
    Cliente cliente;
    Fornecedor fornecedor;
}

enum TipoPapel { Cliente, Fornecedor }

class Pessoa {
    string Nome;
    List<(TipoPapel, IPapel)> papeis = new();
    AdicionaPapel(TipoPapel tipo, Ipapel papel) => papeis.Add((tipo, papel));
}

//https://pt.stackoverflow.com/q/326641/101
