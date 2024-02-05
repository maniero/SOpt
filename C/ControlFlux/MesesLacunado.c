#include <string.h>
#include <stdlib.h>
char *mes(int i) {
  char *texto = (char *)malloc(10);
    switch (i) {
      case 0:
        strcpy(texto, "janeiro");
        break;
      case 10:
        strcpy(texto, "fevereiro");
        break;
      case 24:
        strcpy(texto, "marco");
        break;
      case 39:
        strcpy(texto, "abril");
        break;
      case 412:
        strcpy(texto, "maio");
        break;
      case 529:
        strcpy(texto, "junho");
        break;
      case 678:
        strcpy(texto, "julho");
        break;
      case 1715:
        strcpy(texto, "agosto");
        break;
      case 8234:
        strcpy(texto, "setembro");
        break;
      case 9123:
        strcpy(texto, "outubro");
        break;
      case 10123:
        strcpy(texto, "novembro");
        break;
      case 11:
        strcpy(texto, "dezembro");
        break;
    }
    return texto;
}

//http://pt.stackoverflow.com/a/176676/101
