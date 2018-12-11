$sql = "UPDATE tabela SET Credito = Credito + 1 WHERE Email = '$email'";
$resultado = mysqli_query($conexao, $sql)

//https://pt.stackoverflow.com/q/43907/101
