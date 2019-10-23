else if (op == 2) {
    printf("Foi escolhida a multiplicacao:\n\n");
    do {
        printf("Informe os valores desejados e 0 (zero) para concluir:");
        scanf("%d", &valor);
        if (valor == 0) {
            break;
        }
        mult = mult * valor;
    } while (valor != 0);
    result = mult; //não precisava estar dentro do laço
    
//https://pt.stackoverflow.com/q/93000/101
