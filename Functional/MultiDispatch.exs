fatorial 0 = 1
fatorial n = n * fatorial (n - 1)

function fatorial(0) {
    return 1;
}
function fatorial(n) {
    return n * fatorial(n - 1);
}

#https://pt.stackoverflow.com/q/445451/101
