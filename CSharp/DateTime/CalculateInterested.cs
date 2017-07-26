public decimal CalcularValorTotal(decimal valorAPagar, string dataVencimento, decimal juros, decimal multa) {
    var vencimento = DateTime.Parse(dataVencimento);
    var hoje = DateTime.Now;
    if (hoje > vencimento) {
        var valorMulta = valorAPagar / 100 * Multa;
        var valorJuros = (hoje.Date - vencimento.Date).Days * juros;
        return valorAPagar + valorMulta + valorJuros;
    }
    return valorAPagar;
}

//https://pt.stackoverflow.com/q/221473/101
