using System;
public class C {
    bool M1(object x) => x is null;
    bool M2(object x) => x == null;
}

using System;

public class C {
    bool M1(C x) => x is null;
    bool M2(C x) => x == null;

    int x;
    public C(int x){this.x=x;}
    public static bool operator== (C o1, C o2) => o1.x == o2.x;
    public static bool operator!= (C o1, C o2)=> o1.x != o2.x;
    public override bool Equals(object o2) => ((C)o2).x == x;
    public override int GetHashCode() => x.GetHashCode();
}

bool IsNull<T>(T item) => item is null; // Compile error: CS0403
bool IsNull<T>(T item) => item == null;
bool IsNull<T>(T item) where T : class => item is null;

//https://pt.stackoverflow.com/q/577137/101
