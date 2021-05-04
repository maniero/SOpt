#include <iostream>
#include <string>
using namespace std;

int main(){
    for (auto letra : "Pedro") cout << tolower(letra, locale());
}

//https://pt.stackoverflow.com/q/507739/101
