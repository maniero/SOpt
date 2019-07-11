#include <iostream>
using namespace std;

bool replace(std::string& str, const std::string& from, const std::string& to) {
    size_t start_pos = str.find(from);
    if(start_pos == std::string::npos)
        return false;
    str.replace(start_pos, from.length(), to);
    return true;
}

int main() {
	string texto = "gabriel = 1.73,derp = 1.80,";
	replace(texto, "1.73", "1.75");
	cout << texto;
	return 0;
}

//https://pt.stackoverflow.com/q/50418/101
