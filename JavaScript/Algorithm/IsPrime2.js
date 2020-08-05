function ehPrimo(i) {
    for (var divisor = 2; divisor < i; divisor++) if (i % divisor == 0) return false;
    return true;
}

for (var i = 2; i < 100; i++) if (ehPrimo(i)) document.write(i + '\n');

//https://pt.stackoverflow.com/q/327636/101
