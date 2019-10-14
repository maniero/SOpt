var acoes = new Dictionary<string, Action<int>> {
    {"Criar", (parametro) => Criar(parametro) },
    {"Editar", (parametro) => Editar(parametro) },
    {"Apagar", (parametro) => Apagar(parametro) },
    {"Imprimir", (parametro) => Imprimir(parametro) }
};
acoes["Criar"](1); //executará o método Criar

//https://pt.stackoverflow.com/q/90058/101
