#include <stdio.h>

int main() {
    char *unidades[] = {"I", "II", "III" ,"IV", "V", "VI", "VII", "VIII", "IX"}; 
    char *dezenas[] = {"X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
    char *centenas[] = {"C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
    int numero;
    scanf("%d", &numero);
    int unidade = (numero % 100) % 10;
    int dezena = (numero % 100) / 10;
    int centena = numero / 100;
    if (centena) printf("%s", centenas[centena - 1]);
    if (dezena) printf("%s", dezenas[dezena - 1]);
    if (unidade) printf("%s", unidades[unidade - 1]);
}

//https://pt.stackoverflow.com/q/293839/101
