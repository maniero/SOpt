#include <iostream>
using namespace std;
template <typename T>
class Interleave {
	T a, b;
	bool check = false;
	public:
		Interleave(T a, T b) {
			this->a = a;
			this->b = b;
		}
	
        T getValue() {
	        check = !check;
    	    return check ? a : b;
    	}
};

int getNumber() {
	static Interleave<int> numero(10, 20);
    return numero.getValue();
}

int main() {
    Interleave<int> numero(10, 20);
    cout << numero.getValue() << endl;
    cout << numero.getValue() << endl;
    cout << numero.getValue() << endl;

    Interleave<string> texto("aaa", "bbb");
    cout << texto.getValue() << endl;
    cout << texto.getValue() << endl;
    cout << texto.getValue() << endl;

    cout << getNumber() << endl;
    cout << getNumber() << endl;
    cout << getNumber() << endl;
}

//https://pt.stackoverflow.com/q/45723/101
