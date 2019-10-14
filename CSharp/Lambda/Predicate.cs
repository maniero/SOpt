var compareZero = new Dictionary<string, Predicate<int>> {
    {">", (x) => x > 0 },
    {"<", (x) => x < 0 },
    {"=", (x) => x == 0 }
};
Write(compareZero["="](5)); //imprimirá False

//https://pt.stackoverflow.com/q/90058/101
