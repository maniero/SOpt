#include <stdio.h>

int main() {
    int day, year;
    char weekday[20], month[20], dtm[100];
    printf(
        "\n\tDigite Dia Mes a ano em string"
        "\n\tex.(Saturday March 25 1989): "
    );
    scanf("%[^\n]s80", dtm);
    printf("%s\n", dtm);
    sscanf(dtm, "%s %s %d  %d", weekday, month, &day, &year);
    printf("%s %d, %d = %s\n", month, day, year, weekday);
} 

//https://pt.stackoverflow.com/q/223997/101
