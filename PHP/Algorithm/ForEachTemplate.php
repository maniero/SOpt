<?php
$nota1 = $_POST["matematica"];
$nota2 = $_POST["portugues"];
$nota3 = $_POST["quimica"];
$nota4 = $_POST["fisica"];
$nota5 = $_POST["geografia"];
$nota6 = $_POST["historia"];

$notas = [$nota1, $nota2, $nota3, $nota4, $nota5, $nota6];

function calculaAprovacao($nota){
    return $nota >= 60 ? "Aprovado" : "Reprovado";
}
include "cabecalho.php"
?>

<table border="1px">
     <tr>
        <th>Matemática</th>
        <td><?php echo calculaAprovacao($notas[0]); ?></td>
    </tr>
    <tr>
        <th>Português</th>
        <td><?php echo calculaAprovacao($notas[1]); ?></td>
    </tr>
    <tr> 
        <th>Química</th>
        <td><?php echo calculaAprovacao($notas[2]); ?></td>
    </tr>
    <tr>
        <th>Física</th>
        <td><?php echo calculaAprovacao($notas[3]); ?></td>
    </tr>
    <tr>
        <th>Geografia</th>
        <td><?php echo calculaAprovacao($notas[4]); ?></td>
    </tr>
    <tr>
        <th>História</th>
        <td><?php echo calculaAprovacao($notas[5]); ?></td>
    </tr>
</table>
</body>
</html>

//https://pt.stackoverflow.com/q/53355/101
