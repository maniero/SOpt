public void Consumer() {
    foreach(int i in Integers()) {
        Console.WriteLine(i.ToString());
    }
}

public IEnumerable<int> Integers() {
    yield return 1;
    yield return 2;
    yield return 4;
    yield return 8;
    yield return 16;
    yield return 16777216;
}

// Display powers of 2 up to the exponent 8:
foreach (int i in Power(2, 8)) {
    Console.Write("{0} ", i);
}

public static IEnumerable<int> Power(int number, int exponent) {
    int counter = 0;
    int result = 1;
    while (counter++ < exponent) {
        result = result * number;
        yield return result;
    }
}

//https://pt.stackoverflow.com/q/38910/101
