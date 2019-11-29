#include <iostream>
#include <vector>
 
int main () {
    std::vector<int> vec {1, 2, 3, 4, 5, 6, 7, 8, 9};
    auto it = vec.begin();
    vec.insert(it + 3, 10);
    for (auto x: vec) std::cout << ' ' << x;
}

//https://pt.stackoverflow.com/q/110841/101
