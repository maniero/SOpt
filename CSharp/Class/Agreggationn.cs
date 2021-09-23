class Cliente {
    var contatos = new List<Contato>();
    AdicionarContato(Contato contato) {
        contatos.Add(contato); //este contato independe deste cliente
    }
}

class Cliente {
    var notas = new List<NotaFiscal>();
    EmitirNota(NotaFiscal nota) {
        notas.Add(nota); //a nota existe sempre mesmo que o cliente não exista mais
    }
}

class NotaFiscal {
    var itens = new List<item>();
    AdicionarItem(Produto produto, int quantidade) {
        itens.Add(new Item(produto, quantidade); //este item só existe nesta nota
    }
}

//https://pt.stackoverflow.com/q/86715/101
