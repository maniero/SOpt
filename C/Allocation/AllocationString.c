#include<stdio.h>
#include<stdlib.h>
#include<string.h>

char *str_replace(char *search , char *replace , char *subject) {
    char  *p = NULL , *old = NULL , *new_subject = NULL ;
    int c = 0 , search_size;
    search_size = strlen(search);
    //Count how many occurences
    for (p = strstr(subject , search) ; p != NULL ; p = strstr(p + search_size , search)) {
        c++;
    }
    //Final size
    c = ( strlen(replace) - search_size )*c + strlen(subject);
    //New subject with new size
    new_subject = malloc( c );
    //Set it to blank
    strcpy(new_subject , "");
    //The start position
    old = subject;
    for (p = strstr(subject , search) ; p != NULL ; p = strstr(p + search_size , search)) {
        //move ahead and copy some text from original subject , from a certain position
        strncpy(new_subject + strlen(new_subject) , old , p - old);
        //move ahead and copy the replacement text
        strcpy(new_subject + strlen(new_subject) , replace);
        //The new start position after this search match
        old = p + search_size;
    }
    //Copy the part after the last search match
    strcpy(new_subject + strlen(new_subject) , old);
    return new_subject;
}

int main() {
    char original[100], final[100];
    printf("digite:");
    fgets(original, sizeof(original), stdin);
    strcpy(final, str_replace("toda", "0", original));
    printf("[%s]", final);
}

//https://pt.stackoverflow.com/q/209982/101
