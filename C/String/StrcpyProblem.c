while ((fscanf (arq, "%s %f %f", nome, &nota1, &nota2)) != EOF){
    char * temp = malloc(15);
    strcpy (temp, nome);
    std[i].name = temp
    std[i].nota1 = nota1;
    std[i].nota2 = nota2;
    std[i].media = (nota1+nota2)/2; 
    i++;
}

std = malloc(cont * sizeof(aluno));

//https://pt.stackoverflow.com/q/83026/101
