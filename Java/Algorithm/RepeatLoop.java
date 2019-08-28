while (digita != 4) {
    System.out.println("Digite o o número referente ao tamanho da(s) pulseira(s)\n1.Pequena (17cm) - R$180,00\n2.Média (18cm) - R$200,00\n3.Grande (20cm) - R$240,00\n4.Prosseguir para escolha de pingentes.");
    digita = in.nextInt();
    switch(digita) {
        case 1:
            valor += 180;
            tamanhopulseira = 17;
            quantidadepequena += 1;
            break;
        case 2:
            valor += 200;
            tamanhopulseira = 18;
            quantidademedia += 1;
            break;
        case 3:
            valor += 240;
            tamanhopulseira = 20;
            quantidadegrande += 1;
            break;
        case 4:
            if (tamanhopulseira == 0) {
                System.out.println("Você deve escolher pelo menos uma pulseira de qualquer tamanho!");
                digita = 0;
            }
        default:
            System.out.println("Você deve escolher de 1 à 4");
    }
    System.out.println("Total: " +valor);
}

//https://pt.stackoverflow.com/q/56199/101
