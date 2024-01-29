#include <string.h>
#include <stdlib.h>
char *mes(int i) {
  char *texto = (char *)malloc(10);
    switch (i) {
      case 0:
      case 1:
      case 2:
      case 3:
        strcpy(texto, "abril");
        break;
      case 4:
      case 5:
      case 6:
      case 7:
        strcpy(texto, "agosto");
        break;
      case 8:
      case 9:
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
