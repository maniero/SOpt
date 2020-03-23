void apaga(struct endereco **primeiro, struct endereco **ultimo) {
    struct endereco *info;
    struct endereco *encontra(); // =============> declaração aqui
    char s[80];
    printf("Entre o nome: ");
    gets(s);
    info = encontra(s);
    
//https://pt.stackoverflow.com/q/166100/101
