$consulta = $mysqli->prepare("UPDATE tabela SET $campo = ? WHERE ID = ?");
$consulta->bind_param("ss", $valor, $id);

//https://pt.stackoverflow.com/q/47539/101
