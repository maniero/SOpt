// Abre o arquivo em modo de escrita estendida (leitura/gravação)
// e retorna um ponteiro para um file stream (fluxo de arquivo).
FILE *file = fopen("arquivo.txt", "w+");
char str[101];
// Lê 101 bytes do arquivo texto e joga na variável str.
fscanf(file, "%s", str);
// Exibe em tela o conteúdo lido do arquivo texto.
printf("|%s|\n", str);
// Fecha o arquivo texto.
fclose(file);

//https://pt.stackoverflow.com/q/345010/101
