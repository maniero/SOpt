#include <string>

std::string a() {
    return "PTSO";
}

//auxiliar.hpp

#include <string>

std::string a();

//main.cpp

#include <iostream>
#include "auxiliar.hpp"

int main() {
    cout << a();
    return 0;
}

//https://pt.stackoverflow.com/q/45021/101
