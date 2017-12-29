public function cadastrarUsuarios(parametros) {
    mysqli_query($this->conexao,"INSERT....");
    if (mysqli_affected_rows($this->conexao) > 0) {
        $_SESSION["Sucesso"] = time() + 3;
        return "<script>window.location.href='pagina.php';</script>";
    } else {
        $_SESSION["Erro"] = time() + 3;
        return NULL;
    }
}

$resultado = $metodos->cadastrarUsuarios(parametros);
if (is_null($resultado)) echo "deu erro";
else echo $resultado;

//https://pt.stackoverflow.com/q/265628/101
