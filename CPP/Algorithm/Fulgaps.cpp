#include <iostream>

int main() {
    for (int i = 0; i < 1000; i++) {
        int FirstLastNumber;
        if (i < 100) FirstLastNumber = i % 10;
        else FirstLastNumber = ((i / 100) * 10) + i % 10;
        if (FirstLastNumber == 0 || i % FirstLastNumber == 0) std::cout << i << std::endl;
    }
}

//https://pt.stackoverflow.com/q/449212/101
