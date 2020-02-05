#include <iostream>
#include <bits/stdc++.h>
using namespace std;

int main() {
	int n, cases = 1, a[3];
	cin >> n;
	while (cases != n + 1) {
	    cin >> a[0] >> a[1] >> a[2];
	    sort(a, a + 3);
	    cout << "Sorted array: " << a[0] << " " << a[1] << " " << a[2] << endl;
	    cout << "Case " << cases << ": " << a[1] << endl;
	    cases++;
	}
}

//https://pt.stackoverflow.com/q/139524/101
