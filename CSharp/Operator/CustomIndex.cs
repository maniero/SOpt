propriedade[indice]
propriedade[indice] = 1;

public int this[int index] {
    get => 42 + index;
    set => WriteLine($"abusei {index}");
}

[System.Runtime.CompilerServices.IndexerName("NomeDoIndexador")]

//https://pt.stackoverflow.com/q/249945/101
