#include<stdio.h>

int main() {
	int fat = 1;
    for (int termo = 2; termo <= 20; termo += 2) {
        fat *= termo - 1;
        fat *= termo;
        printf("%d\n", fat);
    }
}

//https://pt.stackoverflow.com/q/461176/101
