<?php
// definições de host, database, usuário e senha
$server = "";
$usuario = "";
$banco   = "";
$senha = "";
// conecta ao banco de dados
$conexao = mysql_connect($server, $usuario, $senha);
$conexao = mysql_select_db("$banco",$conexao);
if(!$conexao) {
    echo mysql_error();
    exit;
}

$conexao = mysql_query("select * from settingsMDP");

//********************************************mudei aqui*****************************
$exibe = mysql_fetch_assoc($conexao);
?>

<form method="post" action="<?php $_PHP_SELF ?>">
    <table width="400" border="0" cellspacing="1" cellpadding="2">
        <tr>
            <td width="100">Nome do MDP: </td>
            <td><input name="name" type="text" id="name" value="<?php echo $exibe["name"]; ?>"></td>
        </tr>
        <tr>
            <td width="100">Versão: </td>
            <td><input name="name" type="text" id="name" value="<?php echo $exibe["version"]; ?>"></td>
        </tr>
        <tr>
            <td width="100">Abertura do painel:</td>
            <td><input name="start_acp" type="text" id="startacp" value="<?php echo $exibe["startacp"]; ?>"></td>
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

//https://pt.stackoverflow.com/q/45105/101
