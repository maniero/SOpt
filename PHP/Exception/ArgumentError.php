public function calcularMedia($valor) {
    if ($valor < 0) throw new ValorNegativoException();
    return $valor > 6 ? "Passou" : "Recuperação";
}

public function calcularMedia($valor) {
    if ($valor < 0) throw new Exception("Valor Negativo");
    return $valor > 6 ? "Passou" : "Recuperação";
}

public function calcularMedia($valor) {
    if ($valor < 0) throw new InvalidArgumentException("Valor Negativo");
    return $valor > 6 ? "Passou" : "Recuperação";
}

public function calcularMedia($valor) {
    if ($valor < 0) return false;
    return $valor > 6 ? "Passou" : "Recuperação";
}

//https://pt.stackoverflow.com/q/457733/101
