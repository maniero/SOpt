public static Func<int,int> Func() {
    var x = 1;
    Func<int, int> inc = p => {
                                x++;
                                return p + x;
                            };
    return inc;
}

//Compilaria para algo mais ou menos assim

private class Closure { 
    public int x;
    public int AnonymousFunction(int p) {
        this.x++;
        return p + this.x;
    }
}
public static Func<int,int> Func() {
    Closure c = new Closure();
    c.x = 1;
    Func<int, int> inc = c.AnonymousFunction;
    return inc;
}

//https://pt.stackoverflow.com/q/34907/101
