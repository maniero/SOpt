public int StableHash(string text) {
    int hash = 23;
    foreach (char c in text) hash *= 31 + c;
    return hash;
}

//https://pt.stackoverflow.com/q/579619/101
