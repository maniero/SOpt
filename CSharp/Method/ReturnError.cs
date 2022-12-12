public static ContaBancaria BuscarConta(List<ContaBancaria> listaContas, string numero) {
    foreach (var conta in listaContas) if (conta.Numero == numero) return conta;
    throw new ContaBancariaNaoExisteException(numero);
}

public static Result<ContaBancaria> BuscarConta(List<ContaBancaria> listaContas, string numero) {
    foreach (var conta in listaContas) if (conta.Numero == numero) return Result.Success(conta);
    return Result.Failure;
}

var resultado = BuscarConta(contas, numero);
if (resultado.Ok) Write(resultado.Value);

public static (bool Ok, ContaBancaria? conta) BuscarConta(List<ContaBancaria> listaContas, string numero) {
    foreach (var conta in listaContas) if (conta.Numero == numero) return (true, conta);
    return (false, null);
}

(var ok, var conta) = BuscarConta(contas, numero);
if (ok) Write(conta);

//https://pt.stackoverflow.com/q/572469/101
