#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main (int argc, char **argv) {
    FILE *fp = NULL;
    char f_name[100];

    switch(argc) {
        case(1): fgets(f_name, 100, stdin); break;  
        case(2): strncpy(f_name, argv[1], 100); break;   
        default: printf("\nErro de syntax %s", argv[0]); exit(0);
    }

    fputs(f_name, stdout);
    fp = fopen(f_name, "r");
    if (fp == NULL)
        printf("\nNão abriu.\n");
    else 
        printf("\nAbriu\n");
}

//http://pt.stackoverflow.com/q/16006/101
