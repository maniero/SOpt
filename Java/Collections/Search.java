public Contato pesquisar(String nome) {
    for (int i = 0; i <= qtd; i++) {
        if (nome.equals(lstContatos[i].getNome())) return lstContatos.[i];
    }
    return null;
}

//https://pt.stackoverflow.com/q/117184/101
