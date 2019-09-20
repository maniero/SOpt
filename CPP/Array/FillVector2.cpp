#include <iostream>
#include <vector>

using namespace std;

int main() {
	int size_vector;
    cin >> size_vector;
    vector<int> values(size_vector);
    for (int i = 0; i < size_vector; i++) {
        cin >> values[i];
    }
    for (auto item : values) cout << item << endl;
}

//https://pt.stackoverflow.com/q/411591/101
