<?php
// definições de host, database, usuário e senha
$server = "";
$usuario = "";
$banco   = "";
$senha = "";
// conecta ao banco de dados
$conexao = mysqli_connect($server, $usuario, $senha);
mysqli_select_db($conexao, $banco);
if(!$conexao) {
    echo mysqli_error();
    exit;
}

if ($_POST["update"] == "Salvar") {
    $name = mysqli_real_escape_string($conexao, $_POST["name"]);
    $version = mysqli_real_escape_string($conexao, $_POST["version"]);
    $startacp = mysqli_real_escape_string($conexao, $_POST["startacp"]);
    $resultado = mysqli_query($conexao, "update settingsMDP set name='$name', version='$version', startacp='$startacp' WHERE id='1'") or die (mysqli_error());
    echo "Gravou";
} else {
    $resultado = mysqli_query($conexao, "select * from settingsMDP");
    $exibe = mysqli_fetch_array($resultado, MYSQLI_ASSOC);
?>

<form method="post">
    <table width="400" border="0" cellspacing="1" cellpadding="2">
        <tr>
            <td width="100">Nome do MDP: </td>
            <td><input name="name" type="text" id="name" value="<?php echo $exibe["name"]; ?>"></td>
        </tr>
        <tr>
            <td width="100">Versão: </td>
            <td><input name="version" type="text" id="version" value="<?php echo $exibe["version"]; ?>"></td>
        </tr>
        <tr>
            <td width="100">Abertura do painel:</td>
            <td><input name="startacp" type="text" id="startacp" value="<?php echo $exibe["startacp"]; ?>"></td>
        </tr>
        <tr>
            <td width="100"> </td>
            <td> </td>
        </tr>
        <tr>
            <td width="100"> </td>
            <td><input name="update" type="submit" id="update" value="Salvar"></td>
        </tr>
    </table>
</form>
<?php
}
?>

//https://pt.stackoverflow.com/q/45189/101
