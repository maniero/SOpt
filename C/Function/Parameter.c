#include <stdio.h>
#include <string.h>

void outraFuncao(char *temp) {
    strcpy(temp, "11");
    printf("tempTest = %s\n", temp);
}

int main() {
	char tempA[100] = "1111";
    outraFuncao(tempA);
    printf("tempTest = %s\n", tempA);
    strcpy(tempA, "22");
    printf("tempTest = %s\n", tempA);
}

//https://pt.stackoverflow.com/q/153193/101
