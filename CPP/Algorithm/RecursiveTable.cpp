#include <stdio.h>

struct t { int hasColided; }
table[] = { 
	{ .hasColided = 0 }, 
    { .hasColided = 1 },
    { .hasColided = 1 },
    { .hasColided = 1 },
    { .hasColided = 1 },
    { .hasColided = 0 },
    { .hasColided = 1 } };
int size = 7;

int getNumPastasColididas(int i, int c) {
    return (i < size) ? table[i].hasColided + getNumPastasColididas(i + 1, c) : c;
}
    
int main(void) {
	printf("%d", getNumPastasColididas(0, 0));
}

//https://pt.stackoverflow.com/q/138497/101
