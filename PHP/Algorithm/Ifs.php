if (!empty($_GET['faixa_de_preco'])) {

    $valor = $_GET['faixa_de_preco'];

    if ($valor == 1) {
        $result = "< 1000000.00";
    } else if ($valor == 2) {
        $result = ">= 1000000.00 AND price <= 2000000.00";
    } else if ($valor == 3) {
        $result = ">= 2000000.00 AND price <= 3000000.00";
    } else {
        $result = "";
    }
    $filter .= " AND price {$result}";
}

//https://pt.stackoverflow.com/q/471869/101
