class C1 {
    Func<int, int, int> M() => (x, y) => x + y;
}

class C2 {
    static int counter = 0;
    int x = counter++;
    Func<int, int> M() => y => this.x + y;
}

class C3 {
    static int counter = 0;
    int x = counter++;
    Func<int> M(int y) => () => x + y;
}

//https://pt.stackoverflow.com/q/306440/101
