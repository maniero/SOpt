printf("Selecione a opcao desejada:\n 1 - Destinos \n 2 - Custos \n 3 - Sair\n");
scanf("%d", &op);
switch(op) {
case 1:
    printf("\n1 - Destinos:\n\n Codigo da cidade      Valor da passagem por pessoa\n\n");
    printf(" 1 - Nova York    ===>      R$3.231,00\n");
    printf(" 2 - Londres      ===>      R$3.789,00\n");
    printf(" 3 - Dubai        ===>      R$4.932,00\n\n");
    printf("Informe o numero de seu destino\n");
    scanf("%d", &destino);
    while (destino < 1 || destino > 3) {
         printf("Informe um codigo de cidade valido.\n");
         scanf("%d", &destino);
    }
    
//https://pt.stackoverflow.com/q/309481/101
