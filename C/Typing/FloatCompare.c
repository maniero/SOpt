 #include <stdio.h>

 int main() {
    int filial;
    float v1, v2, v3;
    printf("\ndigite o numero da filial: ");
    scanf("%d", &filial);
    printf("Digite o valor do 1 mes de vendas: ");
    scanf("%f", &v1);
    printf("Digite o valor do 2 mes de vendas: ");
    scanf("%f", &v2);
    printf("Digite o valor do 3 mes de vendas: ");
    scanf("%f", &v3);
    float totalf = v1 + v2 + v3;
    if (totalf > 0) printf("\no valor total desta filial sera de: %f", totalf);
    else printf("\nO valor nao podera ser exibido, favor digitar um valor diferente de 0");
}

//https://pt.stackoverflow.com/q/389638/101
