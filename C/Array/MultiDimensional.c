#include <stdio.h>
 
int main () {
	int DIM_X = 1000;
	int DIM_Y = 1000;
	int vectorMD[DIM_X][DIM_Y];
	for (int x = 0; x < DIM_X; x++) for (int y = 0; y < DIM_Y; y++) vectorMD[x][y] = x;
}

//https://pt.stackoverflow.com/q/183640/101
