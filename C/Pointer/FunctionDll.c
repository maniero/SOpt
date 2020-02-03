int FuncaoASerUsada(void *lhs, void *rhs) {
    unsigned int a = *((unsigned int*)lhs);
    unsigned int b = *((unsigned int*)rhs);
    return (b - a);
}
dllInsertAfterSpec(l, data, key, FuncaoASerUsada);

//https://pt.stackoverflow.com/q/137773/101
