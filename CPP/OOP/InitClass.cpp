#include <iostream>
#include <string.h>
using namespace std;

class human {
    public:
        string name;
        int age;
        human(string, int);
};

human::human(string name, int age) {
    this->name = name;
    this->age = age;
}

int main() {
    human gabriel("Gabriel Sales", 16);
    cout << gabriel.name;
}

//https://pt.stackoverflow.com/q/44627/101
