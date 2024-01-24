#include <string.h>
#include <stdlib.h>
char *mes(int i) {
  char *texto = (char *)malloc(10);
    switch (i) {
      case 0:
        strcpy(texto, "janeiro");
        break;
      case 1:
        strcpy(texto, "fevereiro");
        break;
      case 2:
        strcpy(texto, "marco");
        break;
      case 3:
        strcpy(texto, "abril");
        break;
      case 4:
        strcpy(texto, "maio");
        break;
      case 5:
        strcpy(texto, "junho");
        break;
      case 6:
        strcpy(texto, "julho");
        break;
      case 7:
        strcpy(texto, "agosto");
        break;
      case 8:
        strcpy(texto, "setembro");
        break;
      case 9:
        strcpy(texto, "outubro");
        break;
      case 10:
        strcpy(texto, "novembro");
        break;
      case 11:
        strcpy(texto, "dezembro");
        break;
    }
    return texto;
}

//http://pt.stackoverflow.com/a/176676/101
