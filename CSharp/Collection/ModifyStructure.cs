var lista = Enumerable.Range(1, 10).ToList();
Parallel.ForEach(lista, (item, state, indice) => {
    Console.WriteLine(string.Format("indice: {0}, value: {1}", indice, item));
});

var lista = Enumerable.Range(1, 10).ToList();
Parallel.For(0, lista.Count, (indice, state) => {
    lista[indice] *= 2;
});

foreach(var item in lista) {
    Console.WriteLine(string.Format("value: {0}", item));
}

//https://pt.stackoverflow.com/q/142740/101
