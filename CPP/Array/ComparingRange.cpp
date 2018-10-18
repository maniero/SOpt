#include <iostream>
using namespace std;
 
int main () {
    int e[5] = {10, 20, 30, 40, 50};       
   	for (int i = 0; i < 5; i++) if (e[i] >= 0 && e[i] < 100) cout << e[i];
}

//https://pt.stackoverflow.com/q/336968/101
