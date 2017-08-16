#include <iostream>
#include <string>
using namespace std;

string criaString() {
    return "Olá mundo!";
}

int main(){
    string retorno = criaString(); //esta variável nem é necessária
    std::cout << retorno;
}

//https://pt.stackoverflow.com/q/228872/101
