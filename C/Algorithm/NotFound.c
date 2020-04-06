void mostraUsuario(int codigo) {
    for (int i = 0; i < quant; i++) {
        if (dados[i].matricula == codigo) {
            printf("Aluno: %d\n",i);
            printf("Nome: %s\n",dados[i].nome);
            printf("CPF: %s\n",dados[i].cpf);
            printf("Matricula: %d\n",dados[i].matricula);
            printf("Idade: %d\n",dados[i].idade);
            printf("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            return;
        }
        printf("pesquisa invalida, tente novamente! \n");
        return;
    }
}

//https://pt.stackoverflow.com/q/444547/101
