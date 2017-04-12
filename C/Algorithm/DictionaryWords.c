#include <stdio.h>
#include <stdbool.h>

struct dicionario {     
    char palavra[21];
    char definicao[51];     
};

bool compararpalavras (const char palavra1[], const char palavra2[]) {      
    int x = 0;      
    while (palavra1[x] == palavra2[x] && palavra1[x] != '\0' && palavra2[x] !='\0') {
        ++x;                
    }
    return palavra1[x] == '\0' && palavra2[x] == '\0';
}

int procurarpalavras (const struct dicionario lingua[], const char palavra[], const int numdepalavras) {        
    bool compararpalavras (const char palavra1[], const char palavra2[]);       
    int x = 0;      
    while (x < numdepalavras) {         
        if (compararpalavras(palavra, lingua[x].palavra)) {                
            return x;               
        } else {                
             ++x;               
        }       
    }
    return -1;  
}

int main (void) {
    int procurarpalavras(const struct dicionario lingua[], const char palavra[], const int numdepalavras);
    const int NUMERODEDEFINICOES = 7;
    char palavra[21] = {'\0'};
    int resultadopesquisa;
    const struct dicionario portugues[7] = {
	    {"pao", "alimento a base de farinha"},
	    {"mortadela", "tipo de carne"}, 
	    {"feijao", "comida brasileira"},
	    {"tropeiro", "tipo de feijao"},
	    {"queijo", "de minas"},
	    {"macarronada", "massa gostosa"},
	    {"pizza", "tipico da italia"}};
    printf ("digite uma palavra: ");
    scanf ("%s", palavra);
    resultadopesquisa = procurarpalavras (portugues, palavra, NUMERODEDEFINICOES);
    if (resultadopesquisa != -1) {
        printf ("%s\n", portugues[resultadopesquisa].definicao);
    } else {
        printf ("\npalavra nao encontrada\n");
    }
}

//http://pt.stackoverflow.com/q/30938/101
