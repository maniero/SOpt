class OutExample {
    static void Method(out int i) {
        i = 44;
    }
    static void Main() {
        int value;
        Method(out value);
        // value is now 44
    }
}

//https://pt.stackoverflow.com/q/82630/101
