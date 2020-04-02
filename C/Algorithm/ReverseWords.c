#include<stdio.h>
#include<stdlib.h>
int main() {
	char name[50];
	printf("Tell me a word: \n");
	scanf("%s", name);
	int i;
	for (i = 0; name[i] != '\0'; i++);
	if (name[i] == '\0') printf("The number of letters is %d\n", i);
	printf("The word is the reverse order is\n");
	for (int j = i; j >= 0; j--) printf("%c", name[j]);
}

//https://pt.stackoverflow.com/q/172967/101
