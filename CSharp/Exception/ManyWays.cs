if (Autenticacao.Validador(senhaNumerica)) {
    return (Autenticador.Senha = true);
} else {
    WriteLine("Senha não segue regras.");
    return false; //indica que não autenticou
}

if (Autenticacao.Validador(senhaNumerica) is SenhaException excessao) {
    Autenticador.Senha = true;
    return true;
} else {
    WriteLine($"Senha não segue regras. Motivo: {excessao.Message}. Veja o erro\n{excecao.StackTrace()}");
    return false;
}

public SenhaException Validador(string senha) {
    if (!int.TryParse(SenhaNumerica, out var senhaConvertida)) return new SenhaException("A senha não é numérica");
    if (senha.Length <= 5) return new SenhaException("Senha não numérica.");
    if (senhaConvertida[0]) < 4) return new SenhaException("Não pode começar com número abaixo de 4.");
    if (!senha.Any(ch => !Char.IsLetterOrDigit(ch)) return new SenhaException("Não foi encontrado nenhum caractere especial");
}

var erros = Autenticacao.Validador(senhaNumerica);
if (erros.Count == 0) return (Autenticador.Senha = true);
foreach (var erro in erros) WriteLine(erro.Message);
return (Autenticador.Senha = false);

public List<ValidationError> Validador(string senha) {
    var erros = new List<ValidationError>();
    if (!int.TryParse(SenhaNumerica, out var senhaConvertida)) erros.Add(new ValidationError(SenhaNaoNumerica, "A senha não é numérica"));
    if (senha.Length <= 5) erros.Add(new ValidationError(SenhaMuitoPequena, "Senha não numérica."));
    if (senhaConvertida[0]) < 4) erros.Add(new ValidationError(SenhaInicioAbaixoDe4, "Não pode começar com número abaixo de 4."));
    if (!senha.Any(ch => !Char.IsLetterOrDigit(ch)) erros.Add(new ValidationError(SenhaSemCaractereEspecial, "Não foi encontrado nenhum caractere especial"));
    return erros;
}

var 
    Autenticador.Senha = SenhaNumerica;
} catch (SenhaNaoNumericaException) {
    Console.WriteLine("A senha não é numérica");
} catch (SenhaMuitoPequenaException) {
    Console.WriteLine("Senha não numérica.");
} catch (SenhaInicioAbaixoDe4Exception) {
    Console.WriteLine("Não pode começar com número abaixo de 4.");
} catch (SenhaSemCaractereEspecialException) {
    Console.WriteLine("Não foi encontrado nenhum caractere especial");
}

if (!int.TryParse(senhaNumerica, out var senhaValida)) WriteLine("A senha não é numérica");

//https://pt.stackoverflow.com/q/243107/101
