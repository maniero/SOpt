using System;
using System.Collections;

class Test {
    static IEnumerator GetCounter() {
        for (int count = 0; count < 10; count++) {
            yield return count;
        }
    }
}

//https://pt.stackoverflow.com/q/44293/101
