while(true) {
    System.out.println("Escolha \"1\" para cadastro; \"2\" para informar salário; \"3\" para calcular imposto; \"0\" para sair!");
    choice = scan.nextInt();
    switch(choice) {
    case 1:
        Cadastro();
        break;
    case 2:
        Salario();
        break;
    case 3:
        Imposto();
        break;
    case 0:
        System.out.println("O programa será finalizado!");
        break mainProgram; //dá para fazer melhor que isto, mas não vi o resto
    }
}

//Depois:

private void Cadastro() {
    System.out.println("Informe o nome do indivíduo: ");
    listaFuncionarios.add(scan.nextLine());
}
private void Salario() {
    System.out.println("Informe o nome: ");
    nome = scan.nextLine().toLowerCase();
    for (int i = 0; i < listaFuncionarios.size(); i++) {
        if (listaFuncionarios.equals(nome)) {
            indice = i;
            status = true;
            break;
        } else if ((i + 1) == listaFuncionarios.size() && !status) {
            System.out.println("Nome não encontrado!");
            break;
        }
    }
    System.out.println("Informe o salário de " + listaFuncionarios.get(indice));
    listaSalario.set(indice, scan.nextDouble());
}
private void Imposto() {
    System.out.println("Informe o nome do indivíduo que deseja calcular o imposto sobre salário: ");
    nome = scan.nextLine()nome.toLowerCase();
    for (int i = 0; i < listaFuncionarios.size(); i++) {
        if (listaFuncionarios.equals(nome)) {
            indice = i;
            valor = listaSalario.get(indice);
            status = true;
            break;
        } else if ((i + 1) == listaFuncionarios.size() && !status) {
            System.out.println("Nome não encontrado!");
            break;
        }
    }
    System.out.println(listaFuncionarios.get(indice) + " recebe " + listaSalario.get(indice) + "\nCalculando o desconto do imposto, seu salário final é: " + Operacoes.Imposto(valor));
}

//https://pt.stackoverflow.com/q/229206/101
