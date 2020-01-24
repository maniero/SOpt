#include <stdio.h>
int main(void) { for (int x = 9; x > 0; x--) printf("%.*s%.*s\n", 9 - x, "         ", x * 2 - 1, "*****************"); }

//https://pt.stackoverflow.com/q/136861/101
