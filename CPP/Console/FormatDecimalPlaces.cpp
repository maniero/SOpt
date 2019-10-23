#include <iostream>
using namespace std;

int main() {
    float num = 3.14159;
    cout << fixed;
    cout.precision(2);
    cout << num << endl;
    printf("%.2f", num); //apenas se for usar em C puro, não use em C++
}

//https://pt.stackoverflow.com/q/94564/101
