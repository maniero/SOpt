int i = 0;
int tamanho = 5;
int array[tamanho];
FILE * arquivo = fopen("file.txt", "r");
while (fscanf(arquivo, "%d", &array[i++]) == 1);

//https://pt.stackoverflow.com/q/126395/101
