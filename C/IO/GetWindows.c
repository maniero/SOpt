#include <iostream>
#include <windows.h>
using namespace std;

BOOL CALLBACK EnumWindowsProc(HWND hwnd, LPARAM lParam);

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PSTR pCmdLine, int iCmdShow) {
    EnumWindows(EnumWindowsProc, NULL);
    return 0;
}

BOOL CALLBACK EnumWindowsProc(HWND hwnd, LPARAM lParam) {
    char class_name[80];
    char title[80];
    GetClassName(hwnd,class_name, sizeof(class_name));
    GetWindowText(hwnd,title,sizeof(title));
    cout <<"Window title: "<<title<<endl;
    cout <<"Class name: "<<class_name<<endl<<endl;    
    return TRUE;
}

//https://pt.stackoverflow.com/q/43003/101
