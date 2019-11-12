function deletar($tabela, $where = NULL) {
    if(!function_exists("conectar")) {
        echo "Não há uma conexão ativa com o seu banco de dados!\n<br><i>Inclua a página ../conexao.php<br>";
        return false;
    }
    if(!$tabela) {
        echo "<br>Não foi indicada nenhum tabela.<br>";
        return false;
    }
    $tabela = "DELETE FROM ".$tabela." ";
    $where = minwhere($where);
    echo $sql = $tabela . $where;
    if(!($conn = conectar())) {
        echo "<br>Não foi possível conectar-se ao banco de dados!<br>\n<i>Verifique as variáveis do arquivo ../conexao.php</i>";
        return false;
    }
    if($result = $conn->query($sql)) {
        $stmt = $conn->prepare( $sql );
        echo ($result = $stmt->execute()) ? "<br>Deletado!<br>" : "<br>Query inválida!<br>";
        $conn = null; //isto provavelmente é um erro
        return true;
    }
    echo "<br>Query inválida!<br>";
    return false;
}

//https://pt.stackoverflow.com/q/105604/101
