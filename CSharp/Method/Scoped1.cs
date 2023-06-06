using System;

Span<int> x = stackalloc int[1];
Test obj = new();
obj.Method(x);

public ref struct Test {
    public void Method(scoped Span<int> values) {}
}

//https://pt.stackoverflow.com/q/583421/101
