void gotoxy(int x, int y) {
    printf("\033[%d;%dH", x, y);
}

//Windows

void gotoxy(int x, int y) { 
    COORD pos = {x, y};
    HANDLE output = GetStdHandle(STD_OUTPUT_HANDLE);
    SetConsoleCursorPosition(output, pos);
}

//https://pt.stackoverflow.com/q/83907/101
