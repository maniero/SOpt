#include <iostream>
using namespace std;

string red(string stream) {
    return "\033[0;31m" + stream + "\033[0m";
}

string red2(const string& stream) {
    return "\033[0;31m" + stream + "\033[0m";
}

int main() {
	auto str = "hello, world";
	cout << red(str) << endl;
	cout << red("hello, world") << endl;
	cout << red2(str) << endl;
	cout << red2("hello, world") << endl;
}

//https://pt.stackoverflow.com/q/559382/101
