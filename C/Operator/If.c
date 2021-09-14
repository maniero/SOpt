if (n == 0) {
    return 0;
} else {
    return x0 + sum_arithmetic(x0 + r, r, n-1);
}

//https://pt.stackoverflow.com/q/34200/101
