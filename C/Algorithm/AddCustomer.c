int main(void) {
    int opcao;
    clientes cadastro[100];
    int i = 1;
    do {
        printf("\n\n1 - Cadastrar Novo Cliente\n");
        printf("2 - Cliente\n");
        printf("3 - Alterar Cliente\n");
        printf("4 - Excluir Cliente\n");
        printf("5 - Cadastrar Automovel\n");
        printf("6 - Automovel\n");
        printf("7 - Alterar Automovel\n");
        printf("8 - Excluir Automovel\n");
        printf("9 - Locacao\n");
        printf("\n  Selecione uma opcao por favor: ");
        scanf("%d", &opcao);
        getchar();
        switch (opcao) {
        case 1: // Codigo do Cadastro de Clientes
            do  {
                char sair_cad;
                system("cls");
                cadastro[i].codigo_cliente = i;
                printf("\n\nCodigo do cliente:  %d", i);
                printf("\nNome:  ");
                scanf("%[^\n]s", &cadastro[i].nome);
                setbuf(stdin, NULL);
                printf("RG:  ");
                scanf("%s", &cadastro[i].rg);
                setbuf(stdin, NULL);
                printf("CPF:  ");
                scanf("%s", &cadastro[i].cpf);
                setbuf(stdin, NULL);
                printf("Endereco:  ");
                scanf("%[^\n]s", &cadastro[i].endereco);
                setbuf(stdin, NULL);
                printf("Data de Nascimento:  ");
                scanf("%s", &cadastro[i].data_nasc);
                setbuf(stdin, NULL);
                printf("Registro Habilitacao:  ");
                scanf("%s", &cadastro[i].registo_habilitacao);
                setbuf(stdin, NULL);
                getchar();
                system("cls");
                printf("\n\n\t\t\t\tCadastro Salvo com Sucesso!");
                printf("\n\n Deseja realizar outro cadastro: S/N ?:   ");
                scanf("%c", &sair_cad);
                setbuf(stdin, NULL);
                i++;
            } while (sair_cad != 'n');
        case 2:
        } while (opcao != 0);
        system("cls");
    }
}

//https://pt.stackoverflow.com/q/247522/101
