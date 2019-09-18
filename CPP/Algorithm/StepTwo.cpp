#include <iostream>
using namespace std;

int main() {
    int myVector[] = {2,6,4,1,9,5,7,3,8,0};
    for (int i = 0; i < sizeof(myVector) / sizeof(myVector[0]); i += 2) cout << myVector[i+1] << ", ";
}
