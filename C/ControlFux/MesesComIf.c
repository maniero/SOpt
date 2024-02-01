#include <string.h>
#include <stdlib.h>

char *mes(int i) {
  char *texto = (char *)malloc(10);
    if (i == 0) {
      strcpy(texto, "janeiro");
    } else if (i == 1) {
      strcpy(texto, "fevereiro");
    } else if (i == 2) {
      strcpy(texto, "marco");
    } else if (i == 3) {
      strcpy(texto, "abril");
    } else if (i == 4) {
      strcpy(texto, "maio");
    } else if (i == 5) {
      strcpy(texto, "junho");
    } else if (i == 6) {
      strcpy(texto, "julho");
    } else if (i == 7) {
      strcpy(texto, "agosto");
    } else if (i == 8) {
      strcpy(texto, "setembro");
    } else if (i == 9) {
      strcpy(texto, "outubro");
    } else if (i == 10) {
      strcpy(texto, "novembro");
    } else if (i == 11) {
      strcpy(texto, "dezembro");
    }
    return texto;
}

//http://pt.stackoverflow.com/a/176676/101
