try {
    MetodoQueTentaFazerUmCadastro();
    TudoDeuCerto(); //se der a exceção no método anterior nem executará isto
} catch (OracleException ex) when (ex.ErrorCode == 1) { //C# 6
    WriteLine("Este CPF já está cadastrando entre os funcionários");
}

//https://pt.stackoverflow.com/q/141550/101
