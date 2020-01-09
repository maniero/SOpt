void vender() {
    system("cls");
    printf("------------------------------------------\n");
    printf("------------Seja bem vindo----------------\n");
    printf("------------------------------------------\n");
    printf("Por favor entre com o codigo de cliente:  \n");
    int cod;
    scanf("%d", &cod);
    system("cls");
    int client = -1;
    for (int i = 0; i < max; i++) {
        if (cd[i].codigo == cod) {
            client = i;
            break; //se achou não precisa continuar procurando
        }
    }
    if (client == -1) { //se ainda é -1 não acho a posição do cliente, então não existe
        printf("Usuario nao cadastrado, deseja cadastrar?[s/n]: ");
        char resp;
        scanf("%s", &resp);
        if (resp == 's') {
            cad_cliente();
        } else {
            return;
        }
    }
    system("cls");
    printf("-------------------------------------------\n");
    printf("Cod: %d\n", cd[client].codigo);
    printf("Nome: %s\n", cd[client].nome);
    printf("Tel: %s\n", cd[client].tel);
    printf("-------------------------------------------\n");
}

//https://pt.stackoverflow.com/q/127448/101
