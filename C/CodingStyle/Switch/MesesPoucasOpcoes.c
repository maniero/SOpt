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
    }
    return texto;
}

//http://pt.stackoverflow.com/a/176676/101
