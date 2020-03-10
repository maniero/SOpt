struct Mutable {
    private int x;
    public int Mutate() {
        this.x = this.x + 1;
        return this.x;
    }
}

class Test {
    public readonly Mutable m = new Mutable();
    static void Main(string[] args) {
        Test t = new Test();
        System.Console.WriteLine(t.m.Mutate());
        System.Console.WriteLine(t.m.Mutate());
        System.Console.WriteLine(t.m.Mutate());
    }
}

//https://pt.stackoverflow.com/q/155448/101
