#include <stdio.h>

float rf() {
    float testfloat = 1.3;
    char string['C'];
    printf("'%f' '%s'", testfloat, string);
    return testfloat;
}

char rc() {
    float testfloat = 1.3;
    char string[]; //havia um erro aqui e isso ainda não vai dar certo
    printf("'%f' '%s'", testfloat, string);
    return 'a';
}

void rv() {
    printf("faz algo aqui");
    return;
}
int main() {
    float x = rf();
    char c = rc();
    rv();
}

//https://pt.stackoverflow.com/q/136605/101
