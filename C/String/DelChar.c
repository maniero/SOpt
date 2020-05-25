char *strdelc(char *s, char ch) {
    int j = 0; //faz a declaração a atribuição junto para ficar claro que a operação está completa
    for (int i = 0; s[i] != '\0'; i++) { //já declarei a variável onde vai usar, é um for clássico
        if (s[i] != ch) { //só entra em certas condições
            s[j++] = s[i]; //aqui há um ordem de precedência do que deve executar, veja abaixo
        }
    }
    s[j] = '\0'; // aqui pega a próxima posição, é a mesma explicação porque funciona o incremento
    return s;
}

//https://pt.stackoverflow.com/q/453221/101
