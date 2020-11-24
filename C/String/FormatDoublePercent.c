#include <stdio.h>
 
int main(void) {
    printf("Strings:\n");
    const char* s = "Hello";
    printf("\t.%10s.\n\t.%-10s.\n\t.%*s.\n", s, s, 10, s);
    printf("Characters:\t%c %%\n", 65); //olha o duplo aqui, veja o resultado
    printf("Integers\n");
    printf("Decimal:\t%i %d %.6i %i %.0i %+i %i\n", 1, 2, 3, 0, 0, 4, -4);
    printf("Hexadecimal:\t%x %x %X %#x\n", 5, 10, 10, 6);
    printf("Octal:\t%o %#o %#o\n", 10, 10, 4);
    printf("Floating point\n");
    printf("Rounding:\t%f %.0f %.32f\n", 1.5, 1.5, 1.3);
    printf("Padding:\t%05.2f %.2f %5.2f\n", 1.5, 1.5, 1.5);
    printf("Scientific:\t%E %e\n", 1.5, 1.5);
    printf("Hexadecimal:\t%a %A\n", 1.5, 1.5);
}

//https://pt.stackoverflow.com/q/483758/101
