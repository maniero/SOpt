$query = "SELECT * FROM exemplo WHERE TRUE";
if (!empty($condicao1)) {
    $lista = implode(",", $condicao1);
    $query .= " AND ID NOT IN ($lista)";
}
if (!empty($condicao2)) {
    $lista = implode(",", $condicao2);
    $query .= " AND NOME NOT IN ($lista)";
}
if (!empty($condicao3)) {
    $lista = implode(",", $condicao3);
    $query .= " AND CIDADE NOT IN ($lista)";
}

//https://pt.stackoverflow.com/q/78117/101
