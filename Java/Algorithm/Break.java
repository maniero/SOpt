public void pesquisaImovelPorCliente(String telefoneCliente) {
    for (int i = 0; i< qtdeReservas; i++) {
        if (ListaDeReservas[i].cliente.getTelefone().equals(telefoneCliente)) {
            ListaDeReservas[i].exibeDados();
        } else {
            System.out.println ("Não foi localizado nenhuma acomodação para este telefone.");
            break;
        }
    }
}

//https://pt.stackoverflow.com/q/211398/101
