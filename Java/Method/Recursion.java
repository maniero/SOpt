static int numeroBinario(int n) {
    if (n > 0) { //o número ainda é maior que zero?
        numeroBinario(n / 2); //repete a chamada
        System.out.print(n % 2); //executa uma ação
    }
    return n;
}

int n = 120;
while (n > 0) { //o número ainda é maior que zero?
    System.out.print(n % 2); //executa uma ação
    n /= 2; //muda o próprio número
}

static void imprimeRepresetacaoBinariaParcial(int n) {
    if (n > 0) {
        ImprimeRepresetacaoBinariaParcial(n / 2);
        System.out.print(n % 2);
    }
    return n;
}

static void imprimeFormatoBinario(int n) {
    while (n > 0) {
        System.out.print(n % 2);
        n /= 2;
    }
}

//https://pt.stackoverflow.com/q/459049/101
