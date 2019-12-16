void a(int tamanho, ...) {
    va_list valist;
    va_start(valist, tamanho);
    for (int i = 0; i < tamanho; i += 2) {
        setColor(va_arg(valist, int));
        printf("%s", va_arg(valist, char *));
        setColor(15); //Seleciona a cor Branca
    }
    va_end(valist);
}

//https://pt.stackoverflow.com/q/120145/101
