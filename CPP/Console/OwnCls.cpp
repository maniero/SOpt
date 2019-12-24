#include <windows.h>

void cls() {
   HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
   COORD coordScreen = { 0, 0 };
   DWORD cCharsWritten;
   CONSOLE_SCREEN_BUFFER_INFO csbi; 
   DWORD dwConSize;
   if (!GetConsoleScreenBufferInfo(hConsole, &csbi)) {
      return;
   }
   dwConSize = csbi.dwSize.X * csbi.dwSize.Y;
   if (!FillConsoleOutputCharacter(hConsole, (TCHAR) ' ', dwConSize, coordScreen, &cCharsWritten
       || !GetConsoleScreenBufferInfo( hConsole, &csbi)
       || !FillConsoleOutputAttribute(hConsole, csbi.wAttributes, dwConSize, coordScreen, &cCharsWritten))) {
      return;
   }
   SetConsoleCursorPosition(hConsole, coordScreen);
}

//https://pt.stackoverflow.com/q/123413/101
