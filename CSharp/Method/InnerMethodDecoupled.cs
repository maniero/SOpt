public Roll OnlyEvens() {
    scores = scores.Where(x => x % 2);
    return this; //imagino que este método existe em algum lugar e faça o esperado
}
public Roll Above(int threshold) {
    scores = scores.Where(x =>, x > threshold);
    return this;
}

//https://pt.stackoverflow.com/q/121450/101
