void imprimeSoma(int valor1, int valor2) { //preferi mudar o nome do que mudar a função
    printf("\n\nSoma: %d", valor1 + valor2);
}
void imprimeSubtracao(int valor1, int valor2) { //se mantiver subtrai, não poderia imprimir
    printf("\n\nSubtracao: %d", valor1 - valor2);
}
int pegaValor(char * texto) {
    printf(texto);
    int valor;
    scanf("%d", &valor);
    return valor;
}
int main(void) {
    int valor1 = pegaValor("Valor 1: "); //é mais procedural deixar a variável local
    int valor2 = pegaValor("Valor 2: ");
    imprimeSoma(valor1, valor2); //os dados devem ser locais e passados para funções
    imprimeSubtracao(valor1, valor2); //a função comunica com parâmetros
    return 0;
}

//https://pt.stackoverflow.com/q/122430/101
