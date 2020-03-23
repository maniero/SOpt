typedef struct {
    size_t size;
    CACHE *vector;
} VectorCache

VectorCache *createCache(CACHEDESC desc) {
    VectorCache *vec = malloc(desc.number_of_lines * (sizeof CACHE));
    int associatividade = desc.associativity
    int contador = 0;
    for (int i = 0; i < desc.number_of_lines; i++) {
        CACHE auxiliar;
        auxiliar.tag = 0;
        auxiliar.index = contador;
        auxiliar.data = 0;
        auxiliar.time = clock();//start times
        memcpy(vec.vector[i], auxiliar, sizeof(auxiliar));
        --associatividade;
        if (associatividade == 0) {
            associatividade = desc.associativity;
            contador++;
        }
    }
    return vec;
}

void printaCache(VectorCache vec) {
    for (int i = 0; i < vec.size; i++) printf("%d \t %d \t %d \t %d\n", i, vec.vector[i].tag, vec.vector[i].index, vec.vector[i].time);
}

//https://pt.stackoverflow.com/q/166204/101
