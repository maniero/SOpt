#include <iostream>
using namespace std;

int main () {
    int e[5] = {10, 20, 30, 40, 50};       
    for (int i = 0; i < 100; i++) {
   	    for (int j = 0; j < 5; j++) {
   	    	if (e[j] == i) {
   	    		cout << i;
   	    		break;
   	    	}
   	    }
    }
}

//https://pt.stackoverflow.com/q/336968/101
