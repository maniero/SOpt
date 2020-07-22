public class A {
    public A() {
        var nameToWrite = "thisdoesntmatter";
        B.WriteName(nameof(nameToWrite));
    }
}

public class B {
    public static WriteName(string name) => WriteLine(name));
}

//https://pt.stackoverflow.com/q/308400/101
