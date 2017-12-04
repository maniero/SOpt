#include <iostream>
#include <memory>

int main() {
    auto str = std::make_unique<std::string>("Testando Smart Pointers");
    std::cout << *str.get() << " size: " << str->size() << std::endl; 
}

//https://pt.stackoverflow.com/q/260076/101
