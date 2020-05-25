#include <iostream>
#include <string>
using namespace std;

int main() {
   time_t Capture = time(0);
   char text[20];
   strftime(text, 20, "%d/%m/%Y %T", localtime(&Capture)); // 25/05/2020 12:51:00
   string Data_Hora(text);
   cout << Data_Hora;
}

//https://pt.stackoverflow.com/q/453789/101
