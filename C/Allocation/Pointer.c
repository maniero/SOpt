#include <stdio.h>
#include <stdlib.h>
#include <math.h>

typedef struct grid_info {
    int size;
    int fields_total;
    int* grid;
    int rows_mistakes;
    int column_mistakes;
    int sectors_mistakes;
} grid;

void fill_the_(grid* sudoku) {
    sudoku->grid = malloc(sizeof(sudoku->fields_total));
    for (int row = 0; row < sudoku->size; row += (sudoku->fields_total / sudoku->size)) {
        for (int column = row; column < row + sudoku->size; column++) {
         scanf("%d", &sudoku->grid[column]);
        }
    }
}

void welcome_screen(grid* sudoku) {
    do {
        printf("The sudoku grid can only have size of 2 to 9\n"
             "Please enter the number of sudoku: ");
        scanf("%d", &sudoku->size);
    } while (sudoku->size < 2 || sudoku->size >= 10);
    sudoku->fields_total = pow(sudoku->size, 2);
}

int main(int argc, const char* argv[]) {
    grid* sudoku = malloc(sizeof(grid));
    welcome_screen(sudoku);
    fill_the_(sudoku);
    printf("Sudoku size: %d\n", sudoku->size);
    free(sudoku);
}

//https://pt.stackoverflow.com/q/84076/101
