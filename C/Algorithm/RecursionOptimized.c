unsigned fac(unsigned n) {
    return fac_tailrec(1, n);
}
unsigned fac_tailrec(unsigned acc, unsigned n) {
    if (n < 2) return acc;
    return fac_tailrec(n * acc, n - 1);
}

//Transforma em algo assim:

unsigned fac_tailrec(unsigned acc, unsigned n) {
TOP:
    if (n < 2) return acc;
    acc = n * acc;
    n = n - 1;
    goto TOP;
}

//Que linearizada fica:

unsigned fac(unsigned n) {
    unsigned acc = 1;
TOP:
    if (n < 2) return acc;
    acc = n * acc;
    n = n - 1;
    goto TOP;
}

//Que na prática é o mesmo que:

unsigned fac(unsigned n) {
    unsigned acc = 1;
    for (; n > 1; --n)
        acc *= n;
    return acc;
}

http://pt.stackoverflow.com/q/184494/101
