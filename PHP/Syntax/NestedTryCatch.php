try {
    $bancoDeDados = new Bd();
    $bancoDeDados->createCreateEntidade($valor1,$valor2);
    $this->geraPdf($valor1,$valor2);
}
catch (PDOException $e) {
    //faz alguma coisa
}
catch(ExceptionSeiLa $e) {
    //faz alguma coisa
}

//https://pt.stackoverflow.com/q/34787/101
