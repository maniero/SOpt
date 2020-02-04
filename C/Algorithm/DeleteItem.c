void eliminar() { //o certo é receber o array como parâmetro
    Livro cadas_livro[MAX]; //isto está bem errado, em todas funções
    char Nome_livro[20];
    printf("Insira o nome do livro a eliminar");
    fgets(Nome_livro, 20, stdin);
    for (int i = 0; i <= MAX; i++) { //MAX não vai dar certo se o número é variável
        if (strcmp(cadas_livro[i].Nome_livro, Nome_livro)) {
            for (int j = i; j <= MAX; j++) { //precisa "puxar" todos os seguintes
                cadas_livro[j] = cadas_livro[j + 1];
            }
        } else printf("Livro nao encontrado\n");
    }
}

//https://pt.stackoverflow.com/q/138360/101
