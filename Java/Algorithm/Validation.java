public void Menu() {
    while (true) {
        System.out.println("========= MENU ========\n"+
        "1)- Cadastrar livro\n"+
        "2)- Listar livro\n"+
        "3)- Pesquisar livro\n"+
        "4)- Excluir livro\n"+
        "5)- voltar\n"+
        "6)- sair\n"+
        "=======================\n"
        );
        System.out.println("Digite a opção desejada:");
        try {
            opc = inputNumerico.nextInt();
        } catch (InputMismatchException | NoSuchElementException | IllegalStateException e) {
            System.out.println("Digitação inválida, tente novamente");
        }
        switch (opc) {
            case 1:
                //faz aqui a chamada para o método de cadastrar
            case 2:
                //continua fazendo para cada opção
            case 6:
                return; //aqui sai do método
            default:
                System.out.println("Opção inválida, tente novamente");
        }
    }
}

//https://pt.stackoverflow.com/q/220386/101
