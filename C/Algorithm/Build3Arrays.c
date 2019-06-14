void leitura(struct medialunos alunos[tf], int aprovados[tf], int reprovados[tf]) {
    for (int i = 0, aprovado = 0, reprovado = 0; i < tf; i++) {
        printf("\nEntre com a matricula: ");
        scanf("%d", &alunos[i].matricula);
        printf("\nEntre com o nome: ");
        fgets(alunos[i].nome, 20, stdin);
        printf("\nEntre com a media final: ");
        scanf("%lf", &alunos[i].mediafinal);
        printf("\n_____________________________________________\n");
        if (alunos[i].mediafinal >= 6) aprovados[aprovado++] = alunos[i];
        else reprovados[reprovado++] = alunos[i];
    }
}

//https://pt.stackoverflow.com/q/391107/101
