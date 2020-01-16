#include <vector>
#include <iostream>

using namespace std;
int main() {
    vector<int> v{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    for (auto &i : v) cout << i << " ";
    cout << '\n';
    for (int k = 0; k <= 10; k++) {
	    for (int i = 0; i < v.size(); i++) {
	        if (v[i] == k) {
	            v.erase(v.begin() + i);
	            break;
	        }
	    }
    }
    for (auto &i : v) cout << i << " ";
    cout << '\n';
}

//https://pt.stackoverflow.com/q/131106/101
