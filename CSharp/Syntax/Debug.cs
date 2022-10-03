public static bool IsDebug() {
    #if DEBUG
        return true;
    #else
        return false;
    #endif
}

[Conditional("DEBUG")]
public void Foo() {}

//https://pt.stackoverflow.com/q/566136/101
