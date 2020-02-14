#include <iostream>
using namespace std;

class test {
	int x = 0;
public:
    void pa() {
	    cout << x << "NULL????" << endl;
    }
};

int main() {
    test * t = nullptr;
    t->pa();
    cout << "Hello world!" << endl;
}

//https://pt.stackoverflow.com/q/146308/101
