(var ok, var result) = TryDivide(4, 0);

WriteLine(TryDivide(4, 0) switch {
    (true, result) => $"deu certo, o valor é {result}",
    (false, _) => "lamento, deu erro" //não usará a variável mesmo, então descarta
});

//https://pt.stackoverflow.com/q/445451/101
