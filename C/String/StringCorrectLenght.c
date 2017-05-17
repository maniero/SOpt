#include <stdio.h>
#include <string.h>

int main (void) {
    char correct_pass[] = "test";
    char typed_pass[10];
    do {     
        printf ("\nTo unlock your last tip, enter the correct password: ");
        scanf ("%s", typed_pass);
    } while (strcmp(typed_pass, correct_pass));
    printf ("\nOK!");
}

//https://pt.stackoverflow.com/q/205228/101
