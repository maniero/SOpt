#include <iostream>
#include <vector>

using namespace std;

int main(){
    int size_vector, new_value;
    cin >> size_vector;
    vector<int> values;
    for (int i = 0; i < size_vector; i++) {
      cin >> new_value;
      values.push_back(new_value);
    }
    for (auto item : values) cout << item << endl;
}

//https://pt.stackoverflow.com/q/411591/101
