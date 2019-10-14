var operacoes = new Dictionary<string, Func<int, int, int>> {
    {"+", (op1, op2) => op1 + op2 },
    {"-", (op1, op2) => op1 - op2 },
    {"*", (op1, op2) => op1 * op2 },
    {"/", (op1, op2) => op1 / op2 }
};
Write(operacoes["+"](10, 20)); //imprime 30

//https://pt.stackoverflow.com/q/90058/101
