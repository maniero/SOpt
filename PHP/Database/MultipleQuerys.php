$resultado = mysqli_query($conexao, "SELECT (SELECT COUNT(*) FROM `tabela`) AS total,
    (SELECT COUNT(*) FROM `tabela` WHERE `valor` > 1) AS totalMaior;");
$campos = mysqli_fetch_array($resultado, MYSQLI_ASSOC);
echo $campos["total"];
echo $campos["totalMaior"];

//https://pt.stackoverflow.com/q/45197/101
